using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface IDireccionSunatRepository
    {
        Task<DireccionSunatModel> Get(int id);
        Task<IEnumerable<DireccionSunatModel>> GetAll();
        Task<DireccionSunatModel> Post(DireccionSunatModel entity);
        Task<DireccionSunatModel> Put(DireccionSunatModel entity);
        Task<DireccionSunatModel> Delete(int id);
    }
}
