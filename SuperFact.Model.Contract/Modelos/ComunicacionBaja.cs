using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Modelos
{
    public class ComunicacionBaja : DocumentoResumen
    {
        [JsonProperty(Required = Required.Always)]
        public List<DocumentoBaja> Bajas { get; set; }
    }
}
