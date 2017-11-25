using SuperFact.Business.IService;
using System;
using System.Collections.Generic;
using System.Text;
using SuperFact.Model.Contract.Response;
using System.Threading.Tasks;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Linq;

namespace SuperFact.Business.Service
{
    public class EmpresaProvider : IEmpresaProvider
    {
        private readonly IEmpresaRepository _repository;
        public EmpresaProvider(IEmpresaRepository _repository)
        {
            this._repository = _repository;
        }
        public async Task<EmpresaModel> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<EmpresaModel> Get(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<IEnumerable<EmpresaModel>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<EmpresaModel> Post(EmpresaModel model)
        {
            return await _repository.Post(model);
        }

        public async Task<EmpresaModel> Put(EmpresaModel model)
        {
            return await _repository.Put(model);
        }
    }
}
