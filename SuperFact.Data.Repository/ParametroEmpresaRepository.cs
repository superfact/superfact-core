using SuperFact.Data.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using SuperFact.Entity.Model;
using System.Threading.Tasks;
using SuperFact.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SuperFact.Data.Repository
{
    public class ParametroEmpresaRepository : IParametroEmpresaRepository
    {
        private readonly SuperFactDbContext _context;
        public ParametroEmpresaRepository(SuperFactDbContext context)
        {
            _context = context;
        }
        public async Task<ParametroEmpresaModel> Delete(string organization, int id)
        {
            EmpresaModel empresa = await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == organization);
            if (empresa == null)
                throw new InvalidOperationException($"Empresa con el RUC {organization} no existe");
            var entity = await _context.Set<ParametroEmpresaModel>().SingleOrDefaultAsync(e => e.Empresa.Id == empresa.Id && e.Id == id);
            _context.Set<ParametroEmpresaModel>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<ParametroEmpresaModel> Get(string organization, int id)
        {
            EmpresaModel empresa = await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == organization);
            if (empresa == null)
                throw new InvalidOperationException($"Empresa con el RUC {organization} no existe");
            return await _context.Set<ParametroEmpresaModel>().SingleOrDefaultAsync(e => e.Empresa.Id == empresa.Id && e.Id == id);
        }

        public async Task<IEnumerable<ParametroEmpresaModel>> GetAll(string organization)
        {
            EmpresaModel empresa = await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == organization);
            if (empresa == null)
                throw new InvalidOperationException($"Empresa con el RUC {organization} no existe");
            return await _context.Set<ParametroEmpresaModel>().Where(t => t.Empresa.Id == empresa.Id).ToListAsync();
        }

        public async Task<ParametroEmpresaModel> GetConfiguration(EmpresaModel pEmpresa)
        {
            if (pEmpresa == null)
                throw new InvalidOperationException($"Empresa no existe");
            return await _context.Set<ParametroEmpresaModel>().SingleOrDefaultAsync(e => e.Empresa.Id == pEmpresa.Id);
        }

        public async Task<ParametroEmpresaModel> Post(string organization, ParametroEmpresaModel model)
        {
            EmpresaModel empresa = await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == organization);
            if (empresa == null)
                throw new InvalidOperationException($"Empresa con el RUC {organization} no existe");
            model.Empresa = empresa;
            // model.IdEmpresa = empresa.Id;
            _context.Set<ParametroEmpresaModel>().Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<ParametroEmpresaModel> Put(string organization, ParametroEmpresaModel model)
        {
            var empresa = await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == organization);
            if (empresa == null)
                throw new InvalidOperationException($"Empresa con el RUC {organization} no existe");
            model.Empresa = empresa;
            _context.Set<ParametroEmpresaModel>().Attach(model);
            _context.SetEntityState(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
