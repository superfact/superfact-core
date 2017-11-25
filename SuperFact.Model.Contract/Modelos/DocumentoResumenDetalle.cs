using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Modelos
{
    public abstract class DocumentoResumenDetalle
    {
        [JsonProperty(Required = Required.Always)]
        public int Id { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string TipoDocumento { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Serie { get; set; }
    }
}
