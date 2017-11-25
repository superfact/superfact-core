using SuperFact.Helper.Comun;
using SuperFact.Model.Contract.Intercambio;
using System.Threading.Tasks;

namespace SuperFact.Ubl.Signed
{
    public interface ISerializador
    {
        Task<string> GenerarXml<T>(T objectToSerialize) where T : IEstructuraXml;
        Task<string> GenerarZip(string tramaXml, string nombreArchivo);
        Task<EnviarDocumentoResponse> GenerarDocumentoRespuesta(string constanciaRecepcion);
    }
}
