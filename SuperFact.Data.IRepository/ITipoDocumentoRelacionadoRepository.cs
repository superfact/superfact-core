using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface ITipoDocumentoRelacionadoRepository
    {
        Task<TipoDocumentoRelacionadoModel> Get(int id);
        Task<IEnumerable<TipoDocumentoRelacionadoModel>> GetAll();
        Task<TipoDocumentoRelacionadoModel> Post(TipoDocumentoRelacionadoModel entity);
        Task<TipoDocumentoRelacionadoModel> Put(TipoDocumentoRelacionadoModel entity);
        Task<TipoDocumentoRelacionadoModel> Delete(int id);
    }
}
