using SuperFact.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperFact.Data.IRepository
{
    public interface ICertificadoDigitalRepository
    {
        Task<CertificadoDigitalModel> Get(string organization, int id);
        Task<CertificadoDigitalModel> GetCertificate(string organization);
        Task<IEnumerable<CertificadoDigitalModel>> GetAll(string organization);
        Task<CertificadoDigitalModel> Post(string organization, CertificadoDigitalModel model);
        Task<CertificadoDigitalModel> Delete(string organization, int id);
        Task<CertificadoDigitalModel> Put(string organization, CertificadoDigitalModel model);
    }
}
