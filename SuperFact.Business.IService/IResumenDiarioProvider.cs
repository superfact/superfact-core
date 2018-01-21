using SuperFact.Model.Contract.Intercambio;
using SuperFact.Model.Contract.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperFact.Business.IService
{
    public interface IResumenDiarioProvider
    {
        Task<IEnumerable<ResumenDiarioNuevo>> GetAll(string organization);
        Task<ResumenDiarioNuevo> Get(string organization, int id);
        Task<EnviarResumenResponse> Generar(string organization, ResumenDiarioNuevo model);
        Task<ResumenDiarioNuevo> Put(string organization, ResumenDiarioNuevo model);
        Task<ResumenDiarioNuevo> Delete(string organization, int id);
    }
}
