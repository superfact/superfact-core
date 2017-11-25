using SuperFact.Data.IRepository;
using System;
using System.Collections.Generic;
using SuperFact.Entity.Model;
using System.Threading.Tasks;
using SuperFact.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SuperFact.Data.Repository
{
    public class CertificadoDigitalRepository : ICertificadoDigitalRepository
    {
        private readonly SuperFactDbContext _context;
        public CertificadoDigitalRepository(SuperFactDbContext context)
        {
            _context = context;
        }
        public async Task<CertificadoDigitalModel> Delete(string organization, int id)
        {
            EmpresaModel empresa = await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == organization);
            if (empresa == null)
                throw new InvalidOperationException($"Empresa con el RUC {organization} no existe");
            var entity = await _context.Set<CertificadoDigitalModel>().SingleOrDefaultAsync(e => e.Empresa.Id == empresa.Id && e.Id == id);
            _context.Set<CertificadoDigitalModel>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<CertificadoDigitalModel> Get(string organization, int id)
        {
            EmpresaModel empresa = await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == organization);
            if (empresa == null)
                throw new InvalidOperationException($"Empresa con el RUC {organization} no existe");
            return await _context.Set<CertificadoDigitalModel>().SingleOrDefaultAsync(e => e.Empresa.Id == empresa.Id && e.Id == id);
        }

        public async Task<IEnumerable<CertificadoDigitalModel>> GetAll(string organization)
        {
            EmpresaModel empresa = await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == organization);
            if (empresa == null)
                throw new InvalidOperationException($"Empresa con el RUC {organization} no existe");
            return await _context.CertificadoDigitales.Where(t => t.Empresa.Id == empresa.Id).ToListAsync();
        }

        public async Task<CertificadoDigitalModel> GetCertificate(string organization)
        {
            EmpresaModel empresa = await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == organization);
            if (empresa == null)
                throw new InvalidOperationException($"Empresa con el RUC {organization} no existe");
            return await _context.Set<CertificadoDigitalModel>().Include(m => m.Empresa).SingleOrDefaultAsync(e => e.Empresa.NroDocumento == organization && e.IsUsado == true);
        }

        public async Task<CertificadoDigitalModel> Post(string organization, CertificadoDigitalModel model)
        {
            EmpresaModel empresa = await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == organization);
            if (empresa == null)
                throw new InvalidOperationException($"Empresa con el RUC {organization} no existe");
            model.Empresa = empresa;
            // model.IdEmpresa = empresa.Id;
            _context.Set<CertificadoDigitalModel>().Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<CertificadoDigitalModel> Put(string organization, CertificadoDigitalModel model)
        {
            var empresa = await _context.Set<EmpresaModel>().SingleOrDefaultAsync(e => e.NroDocumento == organization);
            if (empresa == null)
                throw new InvalidOperationException($"Empresa con el RUC {organization} no existe");
            model.Empresa = empresa;
            _context.Set<CertificadoDigitalModel>().Attach(model);
            _context.SetEntityState(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
