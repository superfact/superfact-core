using SuperFact.Model.Contract.Intercambio;
using System.Threading.Tasks;

namespace SuperFact.Ubl.Signed
{
    public interface ICertificador
    {
        Task<FirmadoResponse> FirmarXml(FirmadoRequest request);
    }
}
