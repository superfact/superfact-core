using System;
using System.Collections.Generic;

namespace SuperFact.Model.Ubl.CommonAggregateComponents
{
    [Serializable]
    public class TransportHandlingUnit
    {
        public string Id { get; set; }

        public List<TransportEquipment> TransportEquipments { get; set; }

        public TransportHandlingUnit()
        {
            TransportEquipments = new List<TransportEquipment>();
        }
    }
}