using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Intercambio
{
    public class EnviarDocumentoResponse : RespuestaComunConArchivo
    {
        public string CodigoRespuesta { get; set; }

        public string MensajeRespuesta { get; set; }

        public string TramaZipCdr { get; set; }
    }
}
