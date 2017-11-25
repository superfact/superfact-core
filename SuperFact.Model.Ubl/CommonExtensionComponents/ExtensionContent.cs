using System;
using SuperFact.Model.Ubl.SunatAggregateComponents;

namespace SuperFact.Model.Ubl.CommonExtensionComponents
{
    [Serializable]
    public class ExtensionContent
    {
        public AdditionalInformation AdditionalInformation { get; set; }

        public ExtensionContent()
        {
            AdditionalInformation = new AdditionalInformation();
        }
    }
}