using SuperFact.Entity.Model;
using SuperFact.Model.Contract.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperFact.Business.IService
{
    public interface IEmpresaProvider
    {
        Task<EmpresaModel> Get(int id);
        Task<IEnumerable<EmpresaModel>> GetAll();
        Task<EmpresaModel> Post(EmpresaModel model);       
        Task<EmpresaModel> Delete(int id);
        Task<EmpresaModel> Put(EmpresaModel model);       
    }
}
