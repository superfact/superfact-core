using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface IModalidadTransporteRepository
    {
        Task<ModalidadTransporteModel> Get(int id);
        Task<IEnumerable<ModalidadTransporteModel>> GetAll();
        Task<ModalidadTransporteModel> Post(ModalidadTransporteModel entity);
        Task<ModalidadTransporteModel> Put(ModalidadTransporteModel entity);
        Task<ModalidadTransporteModel> Delete(int id);
    }
}
