using System;

namespace SuperFact.Model.Ubl.CommonAggregateComponents
{
    [Serializable]
    public class TaxCategory
    {
        public string TaxExemptionReasonCode { get; set; }

        public string TierRange { get; set; }

        public TaxScheme TaxScheme { get; set; }

        public string Id { get; set; }

        public TaxCategory()
        {
            TaxScheme = new TaxScheme();
        }
    }
}