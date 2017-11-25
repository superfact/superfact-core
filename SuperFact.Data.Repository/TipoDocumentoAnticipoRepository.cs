using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class TipoDocumentoAnticipoRepository : ITipoDocumentoAnticipoRepository
    {
        private readonly SuperFactDbContext _context;
        public TipoDocumentoAnticipoRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<TipoDocumentoAnticipoModel> Delete(int id)
        {
            var entity = await _context.Set<TipoDocumentoAnticipoModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TipoDocumentoAnticipoModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<TipoDocumentoAnticipoModel> Get(int id)
        {
            return await _context.Set<TipoDocumentoAnticipoModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TipoDocumentoAnticipoModel>> GetAll()
        {
            return await _context.Set<TipoDocumentoAnticipoModel>().AsNoTracking().ToListAsync();
        }

        public async Task<TipoDocumentoAnticipoModel> Post(TipoDocumentoAnticipoModel entity)
        {
            _context.Set<TipoDocumentoAnticipoModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TipoDocumentoAnticipoModel> Put(TipoDocumentoAnticipoModel entity)
        {
            _context.Set<TipoDocumentoAnticipoModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
