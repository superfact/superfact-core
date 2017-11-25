using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class TipoDiscrepanciaRepository : ITipoDiscrepanciaRepository
    {
        private readonly SuperFactDbContext _context;
        public TipoDiscrepanciaRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<TipoDiscrepanciaModel> Delete(int id)
        {
            var entity = await _context.Set<TipoDiscrepanciaModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TipoDiscrepanciaModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<TipoDiscrepanciaModel> Get(int id)
        {
            return await _context.Set<TipoDiscrepanciaModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TipoDiscrepanciaModel>> GetAll()
        {
            return await _context.Set<TipoDiscrepanciaModel>().Include(p => p.TipoDocumento).AsNoTracking().ToListAsync();
        }

        public async Task<TipoDiscrepanciaModel> Post(TipoDiscrepanciaModel entity)
        {
            _context.Set<TipoDiscrepanciaModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TipoDiscrepanciaModel> Put(TipoDiscrepanciaModel entity)
        {
            _context.Set<TipoDiscrepanciaModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
