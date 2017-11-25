using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.Repository
{
    public class TipoDocumentoRelacionadoRepository : ITipoDocumentoRelacionadoRepository
    {
        private readonly SuperFactDbContext _context;
        public TipoDocumentoRelacionadoRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<TipoDocumentoRelacionadoModel> Delete(int id)
        {
            var entity = await _context.Set<TipoDocumentoRelacionadoModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TipoDocumentoRelacionadoModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<TipoDocumentoRelacionadoModel> Get(int id)
        {
            return await _context.Set<TipoDocumentoRelacionadoModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TipoDocumentoRelacionadoModel>> GetAll()
        {
            return await _context.Set<TipoDocumentoRelacionadoModel>().AsNoTracking().ToListAsync();
        }

        public async Task<TipoDocumentoRelacionadoModel> Post(TipoDocumentoRelacionadoModel entity)
        {
            _context.Set<TipoDocumentoRelacionadoModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TipoDocumentoRelacionadoModel> Put(TipoDocumentoRelacionadoModel entity)
        {
            _context.Set<TipoDocumentoRelacionadoModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
