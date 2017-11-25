using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class MonedaRepository : IMonedaRepository
    {
        private readonly SuperFactDbContext _context;
        public MonedaRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<MonedaModel> Delete(int id)
        {
            var entity = await _context.Set<MonedaModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<MonedaModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<MonedaModel> Get(int id)
        {
            return await _context.Set<MonedaModel>().FindAsync(id);
        }

        public async Task<IEnumerable<MonedaModel>> GetAll()
        {
            return await _context.Set<MonedaModel>().AsNoTracking().ToListAsync();
        }

        public async Task<MonedaModel> Post(MonedaModel entity)
        {
            _context.Set<MonedaModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<MonedaModel> Put(MonedaModel entity)
        {
            _context.Set<MonedaModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
