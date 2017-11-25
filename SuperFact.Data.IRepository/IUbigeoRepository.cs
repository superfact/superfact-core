using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface IUbigeoRepository
    {
        Task<UbigeoModel> Get(int id);
        Task<IEnumerable<UbigeoModel>> GetAll();
        Task<UbigeoModel> Post(UbigeoModel entity);
        Task<UbigeoModel> Put(UbigeoModel entity);
        Task<UbigeoModel> Delete(int id);
    }
}
