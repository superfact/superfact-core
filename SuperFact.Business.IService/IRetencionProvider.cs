using SuperFact.Model.Contract.Intercambio;
using SuperFact.Model.Contract.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperFact.Business.IService
{
    public interface IRetencionProvider
    {
        Task<IEnumerable<DocumentoRetencion>> GetAll(string organization);
        Task<DocumentoRetencion> Get(string organization, int id);
        Task<EnviarDocumentoResponse> Generar(string organization, DocumentoRetencion model);
        Task<DocumentoRetencion> Put(string organization, DocumentoRetencion model);
        Task<DocumentoRetencion> Delete(string organization, int id);
    }
}
