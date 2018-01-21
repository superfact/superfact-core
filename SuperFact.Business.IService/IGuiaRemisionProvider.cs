using SuperFact.Model.Contract.Intercambio;
using SuperFact.Model.Contract.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperFact.Business.IService
{
    public interface IGuiaRemisionProvider
    {
        Task<IEnumerable<GuiaRemision>> GetAll(string organization);
        Task<GuiaRemision> Get(string organization, int id);
        Task<EnviarDocumentoResponse> Generar(string organization, GuiaRemision model);
        Task<GuiaRemision> Put(string organization, GuiaRemision model);
        Task<GuiaRemision> Delete(string organization, int id);
    }
}
