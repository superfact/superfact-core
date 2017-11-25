using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Modelos
{
    public class DatoAdicional
    {
        [JsonProperty(Order = 1, Required = Required.Always)]
        public string Codigo { get; set; }

        [JsonProperty(Order = 2, Required = Required.Always)]
        public string Contenido { get; set; }
    }
}
