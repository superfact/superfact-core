using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Helper.Sunat
{
    public interface IServicioSunatDocumentos : IServicioSunat
    {
        RespuestaSincrono EnviarDocumento(DocumentoSunat request);
        RespuestaAsincrono EnviarResumen(DocumentoSunat request);
        RespuestaSincrono ConsultarTicket(string numeroTicket);
    }
}
