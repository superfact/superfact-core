using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly SuperFactDbContext _context;
        public EmpresaRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<EmpresaModel> Delete(int id)
        {
            var entity = await _context.Set<EmpresaModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<EmpresaModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<EmpresaModel> Get(int id)
        {
            return await _context.Set<EmpresaModel>().FindAsync(id);
        }

        public async Task<EmpresaModel> Get(string ruc)
        {
            return await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == ruc);
        }

        public async Task<IEnumerable<EmpresaModel>> GetAll()
        {
            return await _context.Set<EmpresaModel>().Include(p => p.Ubigeo).Include(p => p.TipoDocumento).AsNoTracking().ToListAsync();
        }

        public async Task<EmpresaModel> Post(EmpresaModel entity)
        {
            _context.Set<EmpresaModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<EmpresaModel> Put(EmpresaModel entity)
        {
            _context.Set<EmpresaModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
