using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Helper.Sunat
{
    public class RespuestaAsincrono
    {
        public string NumeroTicket { get; set; }
        public bool Exito { get; set; }
        public string MensajeError { get; set; }
    }
}
