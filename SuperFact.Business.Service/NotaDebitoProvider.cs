using SuperFact.Business.IService;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using SuperFact.Helper.Comun;
using SuperFact.Helper.Provider;
using SuperFact.Helper.Sunat;
using SuperFact.Model.Contract.Intercambio;
using SuperFact.Model.Contract.Modelos;
using SuperFact.Ubl.Signed;
using SuperFact.Ubl.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SuperFact.Business.Service
{
    public class NotaDebitoProvider : INotaDebitoProvider
    {
        private readonly IDocumentoXml _documentoXml;
        private readonly ISerializador _serializador;
        private readonly ICertificador _certificador;
        private readonly IServicioSunatDocumentos _servicioSunatDocumentos;
        private readonly ICertificadoDigitalRepository _repositorycert;
        private readonly IParametroEmpresaRepository _repositoryparam;
        private readonly IEmpresaRepository _repositoryempresa;
        public NotaDebitoProvider(
            IDocumentoXml _documentoXml
            , ISerializador _serializador
            , ICertificador _certificador
            , ICertificadoDigitalRepository _repositorycert
            , IParametroEmpresaRepository _repositoryparam
            , IEmpresaRepository _repositoryempresa
            , IServicioSunatDocumentos _servicioSunatDocumentos)
        {
            this._documentoXml = _documentoXml;
            this._serializador = _serializador;
            this._certificador = _certificador;
            this._servicioSunatDocumentos = _servicioSunatDocumentos;
            this._repositorycert = _repositorycert;
            this._repositoryempresa = _repositoryempresa;
            this._repositoryparam = _repositoryparam;
        }
        public async Task<DocumentoElectronico> Delete(string organization, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<EnviarDocumentoResponse> Generar(string organization, DocumentoElectronico model)
        {
            EmpresaModel empresa = await _repositoryempresa.Get(organization);
            model.Emisor = HelperTo.ToEmisor(empresa);
            IEstructuraXml invoice = _documentoXml.Generar(model);
            string XmlSinFirma = await _serializador.GenerarXml(invoice);
            CertificadoDigitalModel certificado = await _repositorycert.GetCertificate(organization);
            FirmadoRequest firmado = HelperTo.ToSignedModel(certificado, XmlSinFirma, false);
            FirmadoResponse responseFirma = await _certificador.FirmarXml(firmado);
            ParametroEmpresaModel parametro = await _repositoryparam.GetConfiguration(certificado.Empresa);
            EnviarDocumentoRequest request = HelperTo.ToSendDocument(model, parametro, responseFirma);

            File.WriteAllBytes("debit-note.xml", Convert.FromBase64String(responseFirma.TramaXmlFirmado));

            EnviarDocumentoResponse response = new EnviarDocumentoResponse();
            var nombreArchivo = $"{request.Ruc}-{request.TipoDocumento}-{request.IdDocumento}";
            var tramaZip = await _serializador.GenerarZip(request.TramaXmlFirmado, nombreArchivo);

            _servicioSunatDocumentos.Inicializar(new ParametrosConexion
            {
                Ruc = request.Ruc,
                UserName = request.UsuarioSol,
                Password = request.ClaveSol,
                EndPointUrl = request.EndPointUrl
            });

            RespuestaSincrono resultado = _servicioSunatDocumentos.EnviarDocumento(new DocumentoSunat
            {
                TramaXml = tramaZip,
                NombreArchivo = $"{nombreArchivo}.zip"
            });
            if (!resultado.Exito)
            {
                response.Exito = false;
                response.MensajeError = resultado.MensajeError;
            }
            else
            {
                response = await _serializador.GenerarDocumentoRespuesta(resultado.ConstanciaDeRecepcion);
                File.WriteAllBytes("cdr_debit-note.zip", Convert.FromBase64String(response.TramaZipCdr));
                // Quitamos la R y la extensión devueltas por el Servicio.
                response.NombreArchivo = nombreArchivo;
            }
            //guardar la respuesta
            return response;
        }

        public async Task<DocumentoElectronico> Get(string organization, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DocumentoElectronico>> GetAll(string organization)
        {
            throw new NotImplementedException();
        }

        public async Task<DocumentoElectronico> Put(string organization, DocumentoElectronico model)
        {
            throw new NotImplementedException();
        }
    }
}
