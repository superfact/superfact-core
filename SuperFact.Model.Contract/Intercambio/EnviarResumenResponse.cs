using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Intercambio
{
    public class EnviarResumenResponse : RespuestaComunConArchivo
    {
        public string NroTicket { get; set; }
    }
}
