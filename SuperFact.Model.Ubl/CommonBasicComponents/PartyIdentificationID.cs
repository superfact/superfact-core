using System;

namespace SuperFact.Model.Ubl.CommonBasicComponents
{
    [Serializable]
    public class PartyIdentificationId
    {
        public string SchemeId { get; set; }

        public string Value { get; set; }
    }
}