using Microsoft.EntityFrameworkCore;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SuperFact.Data.Repository
{
    public class UbigeoRepository : IUbigeoRepository
    {
        private readonly SuperFactDbContext _context;
        public UbigeoRepository(SuperFactDbContext context)
        {
            _context = context;
        }

        public async Task<UbigeoModel> Delete(int id)
        {
            var entity = await _context.Set<UbigeoModel>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<UbigeoModel>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<UbigeoModel> Get(int id)
        {
            return await _context.Set<UbigeoModel>().FindAsync(id);
        }

        public async Task<IEnumerable<UbigeoModel>> GetAll()
        {
            return await _context.Set<UbigeoModel>().AsNoTracking().ToListAsync();
        }

        public async Task<UbigeoModel> Post(UbigeoModel entity)
        {
            _context.Set<UbigeoModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<UbigeoModel> Put(UbigeoModel entity)
        {
            _context.Set<UbigeoModel>().Attach(entity);
            _context.SetEntityState(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
