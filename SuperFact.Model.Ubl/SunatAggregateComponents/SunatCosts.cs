using System;

namespace SuperFact.Model.Ubl.SunatAggregateComponents
{
    [Serializable]
    public class SunatCosts
    {
        public SunatRoadTransport RoadTransport { get; set; }

        public SunatCosts()
        {
            RoadTransport = new SunatRoadTransport();
        }
    }
}