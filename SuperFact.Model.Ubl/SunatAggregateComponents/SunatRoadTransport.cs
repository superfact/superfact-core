using System;

namespace SuperFact.Model.Ubl.SunatAggregateComponents
{
    [Serializable]
    public class SunatRoadTransport
    {
        public string LicensePlateId { get; set; }

        public string TransportAuthorizationCode { get; set; }

        public string BrandName { get; set; }
    }
}