using System;
using SuperFact.Model.Ubl.CommonBasicComponents;

namespace SuperFact.Model.Ubl.CommonAggregateComponents
{
    [Serializable]
    public class AlternativeConditionPrice
    {
        public PayableAmount PriceAmount { get; set; }

        public string PriceTypeCode { get; set; }

        public AlternativeConditionPrice()
        {
            PriceAmount = new PayableAmount();
        }
    }
}