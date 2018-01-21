using SuperFact.Model.Contract.Intercambio;
using SuperFact.Model.Contract.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperFact.Business.IService
{
    public interface IComunicacionBajaProvider
    {
        Task<IEnumerable<ComunicacionBaja>> GetAll(string organization);
        Task<ComunicacionBaja> Get(string organization, int id);
        Task<EnviarResumenResponse> Generar(string organization, ComunicacionBaja model);
        Task<ComunicacionBaja> Put(string organization, ComunicacionBaja model);
        Task<ComunicacionBaja> Delete(string organization, int id);
    }
}
