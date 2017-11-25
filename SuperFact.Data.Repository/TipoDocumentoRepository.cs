using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class TipoDocumentoRepository : ITipoDocumentoRepository
    {
        private readonly SuperFactDbContext _context;
        public TipoDocumentoRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<TipoDocumentoModel> Delete(int id)
        {
            var entity = await _context.Set<TipoDocumentoModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TipoDocumentoModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<TipoDocumentoModel> Get(int id)
        {
            return await _context.Set<TipoDocumentoModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TipoDocumentoModel>> GetAll()
        {
            return await _context.Set<TipoDocumentoModel>().AsNoTracking().ToListAsync();
        }

        public async Task<TipoDocumentoModel> Post(TipoDocumentoModel entity)
        {
            _context.Set<TipoDocumentoModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TipoDocumentoModel> Put(TipoDocumentoModel entity)
        {
            _context.Set<TipoDocumentoModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
