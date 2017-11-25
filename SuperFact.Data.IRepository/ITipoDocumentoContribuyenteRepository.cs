using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface ITipoDocumentoContribuyenteRepository
    {
        Task<TipoDocumentoEmpresaModel> Get(int id);
        Task<IEnumerable<TipoDocumentoEmpresaModel>> GetAll();
        Task<TipoDocumentoEmpresaModel> Post(TipoDocumentoEmpresaModel entity);
        Task<TipoDocumentoEmpresaModel> Put(TipoDocumentoEmpresaModel entity);
        Task<TipoDocumentoEmpresaModel> Delete(int id);
    }
}
