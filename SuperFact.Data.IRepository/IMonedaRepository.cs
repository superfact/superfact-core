using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface IMonedaRepository
    {
        Task<MonedaModel> Get(int id);
        Task<IEnumerable<MonedaModel>> GetAll();
        Task<MonedaModel> Post(MonedaModel entity);
        Task<MonedaModel> Put(MonedaModel entity);
        Task<MonedaModel> Delete(int id);
    }
}
