using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class TipoOperacionRepository : ITipoOperacionRepository
    {
        private readonly SuperFactDbContext _context;
        public TipoOperacionRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<TipoOperacionModel> Delete(int id)
        {
            var entity = await _context.Set<TipoOperacionModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TipoOperacionModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<TipoOperacionModel> Get(int id)
        {
            return await _context.Set<TipoOperacionModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TipoOperacionModel>> GetAll()
        {
            return await _context.Set<TipoOperacionModel>().AsNoTracking().ToListAsync();
        }

        public async Task<TipoOperacionModel> Post(TipoOperacionModel entity)
        {
            _context.Set<TipoOperacionModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TipoOperacionModel> Put(TipoOperacionModel entity)
        {
            _context.Set<TipoOperacionModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
