using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Intercambio
{
    public class FirmadoResponse : RespuestaComun
    {
        public string TramaXmlFirmado { get; set; }

        public string ResumenFirma { get; set; }

        public string ValorFirma { get; set; }
    }
}
