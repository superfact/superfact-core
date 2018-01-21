using SuperFact.Entity.Model;
using SuperFact.Model.Contract.Intercambio;
using SuperFact.Model.Contract.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Helper.Provider
{
    public class HelperTo
    {
        public static Contribuyente ToEmisor(EmpresaModel empresa)
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
        public static FirmadoRequest ToSignedModel(CertificadoDigitalModel certificado, string xmlSinFirma, bool node)
        {
            FirmadoRequest model = new FirmadoRequest();
            model.CertificadoDigital = certificado.CertificadoDigital;
            model.PasswordCertificado = certificado.ClaveCertificado;
            model.TramaXmlSinFirma = xmlSinFirma;
            model.UnSoloNodoExtension = node;
            return model;
        }

        public static EnviarDocumentoRequest ToSendDocument(DocumentoElectronico model, ParametroEmpresaModel parametro, FirmadoResponse responseFirma)
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

        public static EnviarDocumentoRequest ToSendSummaryDocument(ResumenDiarioNuevo model, ParametroEmpresaModel parametro, FirmadoResponse responseFirma)
        {
            EnviarDocumentoRequest request = new EnviarDocumentoRequest();
            request.Ruc = model.Emisor.NroDocumento;
            request.UsuarioSol = parametro.UsuarioSol;
            request.ClaveSol = parametro.ClaveSol;
            request.EndPointUrl = "";
            request.IdDocumento = model.IdDocumento;
            //request.TipoDocumento = model.TipoDocumento;
            request.TramaXmlFirmado = responseFirma.TramaXmlFirmado;

            return request;
        }

        public static EnviarDocumentoRequest ToSendGuiaRemisionDocument(GuiaRemision model, ParametroEmpresaModel parametro, FirmadoResponse responseFirma)
        {
            EnviarDocumentoRequest request = new EnviarDocumentoRequest();
            request.Ruc = model.Remitente.NroDocumento;
            request.UsuarioSol = parametro.UsuarioSol;
            request.ClaveSol = parametro.ClaveSol;
            request.EndPointUrl = "";
            request.IdDocumento = model.IdDocumento;
            request.TipoDocumento = model.TipoDocumento;
            request.TramaXmlFirmado = responseFirma.TramaXmlFirmado;

            return request;
        }

        public static EnviarDocumentoRequest ToSendRetentionDocument(DocumentoRetencion model, ParametroEmpresaModel parametro, FirmadoResponse responseFirma)
        {
            EnviarDocumentoRequest request = new EnviarDocumentoRequest();
            request.Ruc = model.Emisor.NroDocumento;
            request.UsuarioSol = parametro.UsuarioSol;
            request.ClaveSol = parametro.ClaveSol;
            request.EndPointUrl = "";
            request.IdDocumento = model.IdDocumento;
            request.TipoDocumento = "20";
            request.TramaXmlFirmado = responseFirma.TramaXmlFirmado;

            return request;
        }

        public static EnviarDocumentoRequest ToSendPerceptionDocument(DocumentoPercepcion model, ParametroEmpresaModel parametro, FirmadoResponse responseFirma)
        {
            EnviarDocumentoRequest request = new EnviarDocumentoRequest();
            request.Ruc = model.Emisor.NroDocumento;
            request.UsuarioSol = parametro.UsuarioSol;
            request.ClaveSol = parametro.ClaveSol;
            request.EndPointUrl = "";
            request.IdDocumento = model.IdDocumento;
            request.TipoDocumento = "40";
            request.TramaXmlFirmado = responseFirma.TramaXmlFirmado;

            return request;
        }

        public static EnviarDocumentoRequest ToSendVoidedDocument(ComunicacionBaja model, ParametroEmpresaModel parametro, FirmadoResponse responseFirma)
        {
            EnviarDocumentoRequest request = new EnviarDocumentoRequest();
            request.Ruc = model.Emisor.NroDocumento;
            request.UsuarioSol = parametro.UsuarioSol;
            request.ClaveSol = parametro.ClaveSol;
            request.EndPointUrl = "";
            request.IdDocumento = model.IdDocumento;
            //request.TipoDocumento = model.TipoDocumento;
            request.TramaXmlFirmado = responseFirma.TramaXmlFirmado;

            return request;
        }
    }
}
