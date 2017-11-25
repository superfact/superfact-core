using SuperFact.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Business.IService
{
    public interface IDireccionSunatProvider
    {
        Task<DireccionSunatModel> Get(int id);
        Task<IEnumerable<DireccionSunatModel>> GetAll();
        Task<DireccionSunatModel> Post(DireccionSunatModel entity);
        Task<DireccionSunatModel> Put(DireccionSunatModel entity);
        Task<DireccionSunatModel> Delete(int id);
    }
}
