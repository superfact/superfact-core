using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class TipoDatoAdicionalRepository : ITipoDatoAdicionalRepository
    {
        private readonly SuperFactDbContext _context;
        public TipoDatoAdicionalRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<TipoDatoAdicionalModel> Delete(int id)
        {
            var entity = await _context.Set<TipoDatoAdicionalModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TipoDatoAdicionalModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<TipoDatoAdicionalModel> Get(int id)
        {
            return await _context.Set<TipoDatoAdicionalModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TipoDatoAdicionalModel>> GetAll()
        {
            return await _context.Set<TipoDatoAdicionalModel>().AsNoTracking().ToListAsync();
        }

        public async Task<TipoDatoAdicionalModel> Post(TipoDatoAdicionalModel entity)
        {
            _context.Set<TipoDatoAdicionalModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TipoDatoAdicionalModel> Put(TipoDatoAdicionalModel entity)
        {
            _context.Set<TipoDatoAdicionalModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
