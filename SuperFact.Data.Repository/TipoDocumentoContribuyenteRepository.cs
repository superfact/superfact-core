using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class TipoDocumentoContribuyenteRepository : ITipoDocumentoContribuyenteRepository
    {
        private readonly SuperFactDbContext _context;
        public TipoDocumentoContribuyenteRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<TipoDocumentoEmpresaModel> Delete(int id)
        {
            var entity = await _context.Set<TipoDocumentoEmpresaModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TipoDocumentoEmpresaModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<TipoDocumentoEmpresaModel> Get(int id)
        {
            return await _context.Set<TipoDocumentoEmpresaModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TipoDocumentoEmpresaModel>> GetAll()
        {
            return await _context.Set<TipoDocumentoEmpresaModel>().AsNoTracking().ToListAsync();
        }

        public async Task<TipoDocumentoEmpresaModel> Post(TipoDocumentoEmpresaModel entity)
        {
            _context.Set<TipoDocumentoEmpresaModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TipoDocumentoEmpresaModel> Put(TipoDocumentoEmpresaModel entity)
        {
            _context.Set<TipoDocumentoEmpresaModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
