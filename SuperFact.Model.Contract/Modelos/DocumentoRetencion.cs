using Newtonsoft.Json;
using SuperFact.Model.Contract.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Modelos
{
    public class DocumentoRetencion : DocumentoSunatBase, IDocumentoElectronico
    {
        [JsonProperty(Order = 7, Required = Required.Always)]
        public string RegimenRetencion { get; set; }

        [JsonProperty(Order = 8, Required = Required.Always)]
        public decimal TasaRetencion { get; set; }

        [JsonProperty(Order = 9, Required = Required.Always)]
        public decimal ImporteTotalRetenido { get; set; }

        [JsonProperty(Order = 10, Required = Required.Always)]
        public decimal ImporteTotalPagado { get; set; }

        [JsonProperty(Order = 11, Required = Required.Always)]
        public List<ItemRetencion> DocumentosRelacionados { get; set; }
    }
}
