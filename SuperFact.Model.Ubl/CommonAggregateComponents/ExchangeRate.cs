﻿using System;

namespace SuperFact.Model.Ubl.CommonAggregateComponents
{
    [Serializable]
    public class ExchangeRate
    {
        public string SourceCurrencyCode { get; set; }

        public string TargetCurrencyCode { get; set; }

        public decimal CalculationRate { get; set; }

        public string Date { get; set; }
    }
}