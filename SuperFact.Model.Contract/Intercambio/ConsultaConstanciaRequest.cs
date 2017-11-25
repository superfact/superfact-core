using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Intercambio
{
    public class ConsultaConstanciaRequest : EnvioDocumentoComun
    {
        [JsonProperty(Required = Required.Always)]
        public string Serie { get; set; }

        [JsonProperty(Required = Required.Always)]
        public int Numero { get; set; }
    }
}
