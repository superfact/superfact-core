using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Helper.Comun
{
    public interface IEstructuraXml
    {
        string UblVersionId { get; set; }
        string CustomizationId { get; set; }
        string Id { get; set; }
        IFormatProvider Formato { get; set; }
    }
}
