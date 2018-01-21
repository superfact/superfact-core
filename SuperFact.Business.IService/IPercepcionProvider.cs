using SuperFact.Model.Contract.Intercambio;
using SuperFact.Model.Contract.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperFact.Business.IService
{
    public interface IPercepcionProvider
    {
        Task<IEnumerable<DocumentoPercepcion>> GetAll(string organization);
        Task<DocumentoPercepcion> Get(string organization, int id);
        Task<EnviarDocumentoResponse> Generar(string organization, DocumentoPercepcion model);
        Task<DocumentoPercepcion> Put(string organization, DocumentoPercepcion model);
        Task<DocumentoPercepcion> Delete(string organization, int id);
    }
}
