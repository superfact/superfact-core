using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface IEmpresaRepository
    {
        Task<EmpresaModel> Get(int id);
        Task<EmpresaModel> Get(string ruc);
        Task<IEnumerable<EmpresaModel>> GetAll();
        Task<EmpresaModel> Post(EmpresaModel entity);
        Task<EmpresaModel> Delete(int id);
        Task<EmpresaModel> Put(EmpresaModel entity);
    }
}
