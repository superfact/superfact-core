using SuperFact.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface IParametroEmpresaRepository
    {
        Task<ParametroEmpresaModel> Get(string organization, int id);
        Task<ParametroEmpresaModel> GetConfiguration(EmpresaModel pEmpresa);
        Task<IEnumerable<ParametroEmpresaModel>> GetAll(string organization);
        Task<ParametroEmpresaModel> Post(string organization, ParametroEmpresaModel model);
        Task<ParametroEmpresaModel> Delete(string organization, int id);
        Task<ParametroEmpresaModel> Put(string organization, ParametroEmpresaModel model);
    }
}
