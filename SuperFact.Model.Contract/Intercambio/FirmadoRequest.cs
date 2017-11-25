using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Intercambio
{
    public class FirmadoRequest
    {
        [JsonProperty(Required = Required.Always)]
        public string CertificadoDigital { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string PasswordCertificado { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string TramaXmlSinFirma { get; set; }

        [JsonProperty(Required = Required.Always)]
        public bool UnSoloNodoExtension { get; set; }
    }
}
