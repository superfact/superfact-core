using SuperFact.Business.IService;
using System;
using System.Collections.Generic;
using SuperFact.Model.Contract.Modelos;
using System.Threading.Tasks;
using SuperFact.Model.Contract.Intercambio;
using SuperFact.Ubl.Xml;
using SuperFact.Ubl.Signed;
using SuperFact.Helper.Comun;
using System.IO;
using SuperFact.Helper.Sunat;
using SuperFact.Entity.Model;
using SuperFact.Data.IRepository;

namespace SuperFact.Business.Service
{
    public class FacturaProvider : IFacturaProvider
    {
        private readonly IDocumentoXml _documentoXml;
        private readonly ISerializador _serializador;
        private readonly ICertificador _certificador;
        private readonly IServicioSunatDocumentos _servicioSunatDocumentos;
        private readonly ICertificadoDigitalRepository _repositorycert;
        private readonly IParametroEmpresaRepository _repositoryparam;
        private readonly IEmpresaRepository _repositoryempresa;
        public FacturaProvider(
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

        public Task<EnviarDocumentoResponse> Delete(string organization, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<EnviarDocumentoResponse> Generar(string organization, DocumentoElectronico model)
        {         
            EmpresaModel empresa = await _repositoryempresa.Get(organization);
            model.Emisor = ToEmisor(empresa);
            IEstructuraXml invoice = _documentoXml.Generar(model);
            string XmlSinFirma = await _serializador.GenerarXml(invoice);
            CertificadoDigitalModel certificado = await _repositorycert.GetCertificate(organization);
            FirmadoRequest firmado = ToSignedModel(certificado, XmlSinFirma, false);
            FirmadoResponse responseFirma = await _certificador.FirmarXml(firmado);
            ParametroEmpresaModel parametro = await _repositoryparam.GetConfiguration(certificado.Empresa);
            EnviarDocumentoRequest request = ToSendDocument(model, parametro, responseFirma);

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
                // Quitamos la R y la extensión devueltas por el Servicio.
                response.NombreArchivo = nombreArchivo;
            }

            return response;
        }

        private Contribuyente ToEmisor(EmpresaModel empresa)
        {
            Contribuyente emisor = new Contribuyente();
            emisor.NroDocumento = empresa.NroDocumento;
            emisor.TipoDocumento = empresa.TipoDocumento.Codigo;
            emisor.NombreLegal = empresa.NombreLegal;
            emisor.NombreComercial = empresa.NombreComercial;
            emisor.Ubigeo = empresa.Ubigeo.Codigo;
            emisor.Direccion = empresa.Direccion;
            emisor.Urbanizacion = empresa.Urbanizacion;
            emisor.Departamento = empresa.Ubigeo.Descripcion;
            emisor.Provincia = empresa.Ubigeo.Descripcion;
            emisor.Distrito = empresa.Ubigeo.Descripcion;
            return emisor;
        }

        private EnviarDocumentoRequest ToSendDocument(DocumentoElectronico model, ParametroEmpresaModel parametro, FirmadoResponse responseFirma)
        {
            EnviarDocumentoRequest request = new EnviarDocumentoRequest();
            request.Ruc = model.Emisor.NroDocumento;
            request.UsuarioSol = parametro.UsuarioSol;
            request.ClaveSol = parametro.ClaveSol;
            request.EndPointUrl = "";
            request.IdDocumento = model.IdDocumento;
            request.TipoDocumento = model.TipoDocumento;
            request.TramaXmlFirmado = responseFirma.TramaXmlFirmado;

            return request;
        }



        private FirmadoRequest ToSignedModel(CertificadoDigitalModel certificado, string xmlSinFirma, bool node)
        {
            FirmadoRequest model = new FirmadoRequest();
            model.CertificadoDigital = certificado.CertificadoDigital;
            model.PasswordCertificado = certificado.ClaveCertificado;
            model.TramaXmlSinFirma = xmlSinFirma;
            model.UnSoloNodoExtension = node;
            return model;
        }


        public Task<DocumentoElectronico> Get(string organization, int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DocumentoElectronico>> GetAll(string organization)
        {
            throw new NotImplementedException();
        }

        public Task<EnviarDocumentoResponse> Put(string organization, DocumentoElectronico model)
        {
            throw new NotImplementedException();
        }
    }
}
