using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class TipoImpuestoRepository : ITipoImpuestoRepository
    {
        private readonly SuperFactDbContext _context;
        public TipoImpuestoRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<TipoImpuestoModel> Delete(int id)
        {
            var entity = await _context.Set<TipoImpuestoModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TipoImpuestoModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<TipoImpuestoModel> Get(int id)
        {
            return await _context.Set<TipoImpuestoModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TipoImpuestoModel>> GetAll()
        {
            return await _context.Set<TipoImpuestoModel>().AsNoTracking().ToListAsync();
        }

        public async Task<TipoImpuestoModel> Post(TipoImpuestoModel entity)
        {
            _context.Set<TipoImpuestoModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TipoImpuestoModel> Put(TipoImpuestoModel entity)
        {
            _context.Set<TipoImpuestoModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
