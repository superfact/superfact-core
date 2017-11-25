using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class ProvinciaRepository : IProvinciaRepository
    {
        private readonly SuperFactDbContext _context;
        public ProvinciaRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<ProvinciaModel> Delete(int id)
        {
            var entity = await _context.Set<ProvinciaModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<ProvinciaModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<ProvinciaModel> Get(int id)
        {
            return await _context.Set<ProvinciaModel>().FindAsync(id);
        }

        public async Task<IEnumerable<ProvinciaModel>> GetAll()
        {
            return await _context.Set<ProvinciaModel>().AsNoTracking().ToListAsync();
        }

        public async Task<ProvinciaModel> Post(ProvinciaModel entity)
        {
            _context.Set<ProvinciaModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<ProvinciaModel> Put(ProvinciaModel entity)
        {
            _context.Set<ProvinciaModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
