using System;

namespace SuperFact.Model.Ubl.CommonExtensionComponents
{
    [Serializable]
    public class UblExtension
    {
        public ExtensionContent ExtensionContent { get; set; }

        public UblExtension()
        {
            ExtensionContent = new ExtensionContent();
        }
    }
}