using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Modelos
{
    public class Direccion
    {
        [JsonProperty(Required = Required.Always)]
        public string Ubigeo { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string DireccionCompleta { get; set; }
    }
}
