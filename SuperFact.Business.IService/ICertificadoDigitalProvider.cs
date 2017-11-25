using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperFact.Business.IService
{
    public interface ICertificadoDigitalProvider
    {
        Task<CertificadoDigitalModel> Get(string organization, int id);
        Task<IEnumerable<CertificadoDigitalModel>> GetAll(string organization);
        Task<CertificadoDigitalModel> Post(string organization, CertificadoDigitalModel model);
        Task<CertificadoDigitalModel> Delete(string organization, int id);
        Task<CertificadoDigitalModel> Put(string organization, CertificadoDigitalModel model);
    }
}
