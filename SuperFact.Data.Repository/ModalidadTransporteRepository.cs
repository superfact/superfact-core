using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class ModalidadTransporteRepository : IModalidadTransporteRepository
    {
        private readonly SuperFactDbContext _context;
        public ModalidadTransporteRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<ModalidadTransporteModel> Delete(int id)
        {
            var entity = await _context.Set<ModalidadTransporteModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<ModalidadTransporteModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<ModalidadTransporteModel> Get(int id)
        {
            return await _context.Set<ModalidadTransporteModel>().FindAsync(id);
        }

        public async Task<IEnumerable<ModalidadTransporteModel>> GetAll()
        {
            return await _context.Set<ModalidadTransporteModel>().AsNoTracking().ToListAsync();
        }

        public async Task<ModalidadTransporteModel> Post(ModalidadTransporteModel entity)
        {
            _context.Set<ModalidadTransporteModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<ModalidadTransporteModel> Put(ModalidadTransporteModel entity)
        {
            _context.Set<ModalidadTransporteModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
