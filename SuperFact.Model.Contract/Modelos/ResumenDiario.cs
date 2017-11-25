using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Modelos
{
    public class ResumenDiario : DocumentoResumen
    {
        [JsonProperty(Required = Required.Always)]
        public List<GrupoResumen> Resumenes { get; set; }
    }
}
