using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface ITipoDocumentoAnticipoRepository
    {
        Task<TipoDocumentoAnticipoModel> Get(int id);
        Task<IEnumerable<TipoDocumentoAnticipoModel>> GetAll();
        Task<TipoDocumentoAnticipoModel> Post(TipoDocumentoAnticipoModel entity);
        Task<TipoDocumentoAnticipoModel> Put(TipoDocumentoAnticipoModel entity);
        Task<TipoDocumentoAnticipoModel> Delete(int id);
    }
}
