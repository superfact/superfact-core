using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface IProvinciaRepository
    {
        Task<ProvinciaModel> Get(int id);
        Task<IEnumerable<ProvinciaModel>> GetAll();
        Task<ProvinciaModel> Post(ProvinciaModel entity);
        Task<ProvinciaModel> Put(ProvinciaModel entity);
        Task<ProvinciaModel> Delete(int id);
    }
}
