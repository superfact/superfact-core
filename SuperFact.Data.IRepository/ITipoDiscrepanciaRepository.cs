using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface ITipoDiscrepanciaRepository
    {
        Task<TipoDiscrepanciaModel> Get(int id);
        Task<IEnumerable<TipoDiscrepanciaModel>> GetAll();
        Task<TipoDiscrepanciaModel> Post(TipoDiscrepanciaModel entity);
        Task<TipoDiscrepanciaModel> Put(TipoDiscrepanciaModel entity);
        Task<TipoDiscrepanciaModel> Delete(int id);
    }
}
