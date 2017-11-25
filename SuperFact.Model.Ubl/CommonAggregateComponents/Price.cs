using System;
using SuperFact.Model.Ubl.CommonBasicComponents;

namespace SuperFact.Model.Ubl.CommonAggregateComponents
{
    [Serializable]
    public class Price
    {
        public PayableAmount PriceAmount { get; set; }

        public Price()
        {
            PriceAmount = new PayableAmount();
        }
    }
}