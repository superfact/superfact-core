using SuperFact.Helper.Comun;
using SuperFact.Model.Contract.Contratos;

namespace SuperFact.Ubl.Xml
{
    public interface IDocumentoXml
    {
        IEstructuraXml Generar(IDocumentoElectronico request);
    }
}
