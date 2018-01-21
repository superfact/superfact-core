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
using System.Text;
using System.Threading.Tasks;

namespace SuperFact.Business.Service
{
    public class ResumenDiarioProvider : IResumenDiarioProvider
    {
        private const string FormatoFecha = "yyyy-MM-dd";
        private readonly IDocumentoXml _documentoXml;
        private readonly ISerializador _serializador;
        private readonly ICertificador _certificador;
        private readonly IServicioSunatDocumentos _servicioSunatDocumentos;
        private readonly ICertificadoDigitalRepository _repositorycert;
        private readonly IParametroEmpresaRepository _repositoryparam;
        private readonly IEmpresaRepository _repositoryempresa;
        public ResumenDiarioProvider(
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
        public async Task<ResumenDiarioNuevo> Delete(string organization, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<EnviarResumenResponse> Generar(string organization, ResumenDiarioNuevo model)
        {
            EmpresaModel empresa = await _repositoryempresa.Get(organization);
            model.IdDocumento = string.Format("RC-{0:yyyyMMdd}-001", DateTime.Today);
            model.FechaEmision = DateTime.Today.ToString(FormatoFecha);
            model.FechaReferencia = DateTime.Today.AddDays(-1).ToString(FormatoFecha);
            model.Emisor = HelperTo.ToEmisor(empresa);
            //  model.Resumenes = new List<GrupoResumenNuevo>()
            IEstructuraXml summary = _documentoXml.Generar(model);
            string XmlSinFirma = await _serializador.GenerarXml(summary);           
            CertificadoDigitalModel certificado = await _repositorycert.GetCertificate(organization);
            FirmadoRequest firmado = HelperTo.ToSignedModel(certificado, XmlSinFirma, true);
            FirmadoResponse responseFirma = await _certificador.FirmarXml(firmado);
            ParametroEmpresaModel parametro = await _repositoryparam.GetConfiguration(certificado.Empresa);
            EnviarDocumentoRequest request =HelperTo.ToSendSummaryDocument(model, parametro, responseFirma);


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

        public async Task<ResumenDiarioNuevo> Get(string organization, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ResumenDiarioNuevo>> GetAll(string organization)
        {
            throw new NotImplementedException();
        }

        public async Task<ResumenDiarioNuevo> Put(string organization, ResumenDiarioNuevo model)
        {
            throw new NotImplementedException();
        }
    }
}
