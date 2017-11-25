using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class TipoPrecioRepository : ITipoPrecioRepository
    {
        private readonly SuperFactDbContext _context;
        public TipoPrecioRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<TipoPrecioModel> Delete(int id)
        {
            var entity = await _context.Set<TipoPrecioModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TipoPrecioModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<TipoPrecioModel> Get(int id)
        {
            return await _context.Set<TipoPrecioModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TipoPrecioModel>> GetAll()
        {
            return await _context.Set<TipoPrecioModel>().AsNoTracking().ToListAsync();
        }

        public async Task<TipoPrecioModel> Post(TipoPrecioModel entity)
        {
            _context.Set<TipoPrecioModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TipoPrecioModel> Put(TipoPrecioModel entity)
        {
            _context.Set<TipoPrecioModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
