using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface ITipoDocumentoRepository
    {
        Task<TipoDocumentoModel> Get(int id);
        Task<IEnumerable<TipoDocumentoModel>> GetAll();
        Task<TipoDocumentoModel> Post(TipoDocumentoModel entity);
        Task<TipoDocumentoModel> Put(TipoDocumentoModel entity);
        Task<TipoDocumentoModel> Delete(int id);
    }
}
