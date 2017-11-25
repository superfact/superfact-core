﻿using System;
using SuperFact.Model.Ubl.CommonBasicComponents;

namespace SuperFact.Model.Ubl.CommonAggregateComponents
{
    [Serializable]
    public class TaxSubtotal
    {
        public PayableAmount TaxAmount { get; set; }

        public TaxCategory TaxCategory { get; set; }

        public decimal Percent { get; set; }

        public TaxSubtotal()
        {
            TaxAmount = new PayableAmount();
            TaxCategory = new TaxCategory();
        }
    }
}