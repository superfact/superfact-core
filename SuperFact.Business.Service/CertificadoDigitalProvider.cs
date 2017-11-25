using SuperFact.Business.IService;
using System;
using System.Collections.Generic;
using System.Text;
using SuperFact.Entity.Model;
using System.Threading.Tasks;
using SuperFact.Data.IRepository;

namespace SuperFact.Business.Service
{
    public class CertificadoDigitalProvider : ICertificadoDigitalProvider
    {
        private readonly ICertificadoDigitalRepository _repository;
        public CertificadoDigitalProvider(ICertificadoDigitalRepository _repository)
        {
            this._repository = _repository;
        }
        public async Task<CertificadoDigitalModel> Delete(string organization, int id)
        {
            return await _repository.Delete(organization, id);
        }

        public async Task<CertificadoDigitalModel> Get(string organization, int id)
        {
            return await _repository.Get(organization, id);
        }

        public async Task<IEnumerable<CertificadoDigitalModel>> GetAll(string organization)
        {
            return await _repository.GetAll(organization);
        }

        public async Task<CertificadoDigitalModel> Post(string organization, CertificadoDigitalModel model)
        {
            return await _repository.Post(organization, model);
        }

        public async Task<CertificadoDigitalModel> Put(string organization, CertificadoDigitalModel model)
        {
            return await _repository.Put(organization, model);
        }
    }
}
