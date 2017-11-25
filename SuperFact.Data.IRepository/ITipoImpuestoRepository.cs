using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface ITipoImpuestoRepository
    {
        Task<TipoImpuestoModel> Get(int id);
        Task<IEnumerable<TipoImpuestoModel>> GetAll();
        Task<TipoImpuestoModel> Post(TipoImpuestoModel entity);
        Task<TipoImpuestoModel> Put(TipoImpuestoModel entity);
        Task<TipoImpuestoModel> Delete(int id);
    }
}
