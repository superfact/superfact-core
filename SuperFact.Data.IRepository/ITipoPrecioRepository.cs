using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface ITipoPrecioRepository
    {
        Task<TipoPrecioModel> Get(int id);
        Task<IEnumerable<TipoPrecioModel>> GetAll();
        Task<TipoPrecioModel> Post(TipoPrecioModel entity);
        Task<TipoPrecioModel> Put(TipoPrecioModel entity);
        Task<TipoPrecioModel> Delete(int id);
    }
}
