using SuperFact.Business.IService;
using SuperFact.Data.IRepository;
using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Business.Service
{
    public class DireccionSunatProvider : IDireccionSunatProvider
    {
        private readonly IDireccionSunatRepository _repository;
        public DireccionSunatProvider(IDireccionSunatRepository _repository)
        {
            this._repository = _repository;
        }

        public async Task<DireccionSunatModel> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<DireccionSunatModel> Get(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<IEnumerable<DireccionSunatModel>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<DireccionSunatModel> Post(DireccionSunatModel entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<DireccionSunatModel> Put(DireccionSunatModel entity)
        {
            return await _repository.Put(entity);
        }
    }
}
