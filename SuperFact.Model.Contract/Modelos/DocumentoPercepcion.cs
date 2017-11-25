﻿using Newtonsoft.Json;
using SuperFact.Model.Contract.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Modelos
{
    public class DocumentoPercepcion : DocumentoSunatBase, IDocumentoElectronico
    {
        [JsonProperty(Order = 7, Required = Required.Always)]
        public string RegimenPercepcion { get; set; }

        [JsonProperty(Order = 8, Required = Required.Always)]
        public decimal TasaPercepcion { get; set; }

        [JsonProperty(Order = 9, Required = Required.Always)]
        public decimal ImporteTotalPercibido { get; set; }

        [JsonProperty(Order = 10, Required = Required.Always)]
        public decimal ImporteTotalCobrado { get; set; }

        [JsonProperty(Order = 11, Required = Required.Always)]
        public List<ItemPercepcion> DocumentosRelacionados { get; set; }
    }
}
