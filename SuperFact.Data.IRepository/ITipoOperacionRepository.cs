using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface ITipoOperacionRepository
    {
        Task<TipoOperacionModel> Get(int id);
        Task<IEnumerable<TipoOperacionModel>> GetAll();
        Task<TipoOperacionModel> Post(TipoOperacionModel entity);
        Task<TipoOperacionModel> Put(TipoOperacionModel entity);
        Task<TipoOperacionModel> Delete(int id);
    }
}
