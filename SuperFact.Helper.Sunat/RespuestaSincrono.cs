using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Helper.Sunat
{
    public class RespuestaSincrono
    {
        public string ConstanciaDeRecepcion { get; set; }
        public bool Exito { get; set; }
        public string MensajeError { get; set; }
    }
}
