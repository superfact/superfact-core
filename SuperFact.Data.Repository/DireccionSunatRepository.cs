using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Data.Repository
{
    public class DireccionSunatRepository : IDireccionSunatRepository
    {
        private readonly SuperFactDbContext _context;
        public DireccionSunatRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<DireccionSunatModel> Delete(int id)
        {
            var entity = await _context.Set<DireccionSunatModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<DireccionSunatModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<DireccionSunatModel> Get(int id)
        {
            return await _context.Set<DireccionSunatModel>().FindAsync(id);
        }

        public async Task<IEnumerable<DireccionSunatModel>> GetAll()
        {
            return await _context.Set<DireccionSunatModel>().AsNoTracking().ToListAsync();
        }

        public async Task<DireccionSunatModel> Post(DireccionSunatModel entity)
        {
            _context.Set<DireccionSunatModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<DireccionSunatModel> Put(DireccionSunatModel entity)
        {
            _context.Set<DireccionSunatModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
