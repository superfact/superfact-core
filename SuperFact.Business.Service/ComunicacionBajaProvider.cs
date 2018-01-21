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
    public class ComunicacionBajaProvider : IComunicacionBajaProvider
    {
        private const string FormatoFecha = "yyyy-MM-dd";
        private readonly IDocumentoXml _documentoXml;
        private readonly ISerializador _serializador;
        private readonly ICertificador _certificador;
        private readonly IServicioSunatDocumentos _servicioSunatDocumentos;
        private readonly ICertificadoDigitalRepository _repositorycert;
        private readonly IParametroEmpresaRepository _repositoryparam;
        private readonly IEmpresaRepository _repositoryempresa;
        public ComunicacionBajaProvider(
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
        public async Task<ComunicacionBaja> Delete(string organization, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<EnviarResumenResponse> Generar(string organization, ComunicacionBaja model)
        {
            EmpresaModel empresa = await _repositoryempresa.Get(organization);

            model.IdDocumento = string.Format("RA-{0:yyyyMMdd}-001", DateTime.Today);
            model.FechaEmision = DateTime.Today.ToString(FormatoFecha);
            model.FechaReferencia = DateTime.Today.AddDays(-1).ToString(FormatoFecha);                    
            model.Emisor = HelperTo.ToEmisor(empresa);
            
            IEstructuraXml summary = _documentoXml.Generar(model);
            string XmlSinFirma = await _serializador.GenerarXml(summary);
            CertificadoDigitalModel certificado = await _repositorycert.GetCertificate(organization);
            FirmadoRequest firmado = HelperTo.ToSignedModel(certificado, XmlSinFirma, true);
            FirmadoResponse responseFirma = await _certificador.FirmarXml(firmado);
            ParametroEmpresaModel parametro = await _repositoryparam.GetConfiguration(certificado.Empresa);
            EnviarDocumentoRequest request = HelperTo.ToSendVoidedDocument(model, parametro, responseFirma);

            File.WriteAllBytes("voided.xml", Convert.FromBase64String(responseFirma.TramaXmlFirmado));

            EnviarResumenResponse response = new EnviarResumenResponse();
            var nombreArchivo = $"{request.Ruc}-{request.IdDocumento}";
            var tramaZip = await _serializador.GenerarZip(request.TramaXmlFirmado, nombreArchivo);

            _servicioSunatDocumentos.Inicializar(new ParametrosConexion
            {
                Ruc = request.Ruc,
                UserName = request.UsuarioSol,
                Password = request.ClaveSol,
                EndPointUrl = request.EndPointUrl
            });

            RespuestaAsincrono resultado = _servicioSunatDocumentos.EnviarResumen(new DocumentoSunat
            {
                NombreArchivo = $"{nombreArchivo}.zip",
                TramaXml = tramaZip
            });

            if (resultado.Exito)
            {
                response.NroTicket = resultado.NumeroTicket;
                response.Exito = true;
                response.NombreArchivo = nombreArchivo;
            }
            else
            {
                response.MensajeError = resultado.MensajeError;
                response.Exito = false;
            }
            //guardar la respuesta
            return response;

        }

        public async Task<ComunicacionBaja> Get(string organization, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ComunicacionBaja>> GetAll(string organization)
        {
            throw new NotImplementedException();
        }

        public async Task<ComunicacionBaja> Put(string organization, ComunicacionBaja model)
        {
            throw new NotImplementedException();
        }
    }
}
