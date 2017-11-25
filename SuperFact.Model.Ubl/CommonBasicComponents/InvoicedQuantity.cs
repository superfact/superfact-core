using System;

namespace SuperFact.Model.Ubl.CommonBasicComponents
{
    [Serializable]
    public class InvoicedQuantity
    {
        public string UnitCode { get; set; }

        public decimal Value { get; set; }
    }
}