﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Modelos
{
    public class GrupoResumenNuevo : GrupoResumen
    {
        [JsonProperty(Required = Required.Always)]
        public string IdDocumento { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string TipoDocumentoReceptor { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string NroDocumentoReceptor { get; set; }

        [JsonProperty(Required = Required.Always)]
        public int CodigoEstadoItem { get; set; }

        public string DocumentoRelacionado { get; set; }

        public string TipoDocumentoRelacionado { get; set; }
    }
}
