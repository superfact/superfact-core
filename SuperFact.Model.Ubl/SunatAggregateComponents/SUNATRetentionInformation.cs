using System;
using SuperFact.Model.Ubl.CommonAggregateComponents;
using SuperFact.Model.Ubl.CommonBasicComponents;

namespace SuperFact.Model.Ubl.SunatAggregateComponents
{
    [Serializable]
    public class SunatRetentionInformation
    {
        public PayableAmount SunatRetentionAmount { get; set; }

        public string SunatRetentionDate { get; set; }

        public PayableAmount SunatNetTotalPaid { get; set; }

        public ExchangeRate ExchangeRate { get; set; }

        public SunatRetentionInformation()
        {
            SunatRetentionAmount = new PayableAmount();
            SunatNetTotalPaid = new PayableAmount();
            ExchangeRate = new ExchangeRate();
        }
    }
}