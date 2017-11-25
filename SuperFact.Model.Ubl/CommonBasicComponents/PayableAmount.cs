using System;

namespace SuperFact.Model.Ubl.CommonBasicComponents
{
    [Serializable]
    public class PayableAmount
    {
        public string CurrencyId { get; set; }

        public decimal Value { get; set; }
    }
}