using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface ITipoDatoAdicionalRepository
    {
        Task<TipoDatoAdicionalModel> Get(int id);
        Task<IEnumerable<TipoDatoAdicionalModel>> GetAll();
        Task<TipoDatoAdicionalModel> Post(TipoDatoAdicionalModel entity);
        Task<TipoDatoAdicionalModel> Put(TipoDatoAdicionalModel entity);
        Task<TipoDatoAdicionalModel> Delete(int id);
    }
}
