﻿using SuperFact.Model.Contract.Intercambio;
using SuperFact.Model.Contract.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperFact.Entity.Model;

namespace SuperFact.Business.IService
{
    public interface IFacturaProvider
    {
        Task<IEnumerable<DocumentoElectronico>> GetAll(string organization);
        Task<DocumentoElectronico> Get(string organization, int id);
        Task<EnviarDocumentoResponse> Generar(string organization, DocumentoElectronico model);
        Task<DocumentoElectronico> Put(string organization, DocumentoElectronico model);
        Task<DocumentoElectronico> Delete(string organization, int id);
    }
}
