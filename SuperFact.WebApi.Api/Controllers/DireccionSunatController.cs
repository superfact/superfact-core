using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperFact.Business.IService;
using SuperFact.Entity.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace SuperFact.WebApi.Api.Controllers
{
    [Produces("application/json")]
    [EnableCors("AllowCors"), Route("api/sunat")]
    public class DireccionSunatController : Controller
    {
        private readonly IDireccionSunatProvider _service;
        public DireccionSunatController(IDireccionSunatProvider _service)
        {
            this._service = _service;
        }       

        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<DireccionSunatModel>> Get()
        {
            return await _service.GetAll();
        }

        // GET api/sunat/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<DireccionSunatModel> Get(int id)
        {
            return await _service.Get(id);
        }

        // POST api/sunat
        // [HttpPost, Route("save-dir")]  
        [HttpPost]
        [AllowAnonymous]
        public async Task<DireccionSunatModel> Post([FromBody]DireccionSunatModel model)
        {
            return await _service.Post(model);
        }

        // PUT api/sunat/5
        // [DisableCors, HttpPut, Route("update-dir/{id}")]  
        [HttpPut("{id}")]
        [AllowAnonymous]
        public async Task<DireccionSunatModel> Put(int id, [FromBody]DireccionSunatModel model)
        {
            return await _service.Put(model);
        }

        // DELETE api/sunat/5
        //  [HttpDelete, Route("delete-dir/{id}")]  
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<DireccionSunatModel> Delete(int id)
        {
            return await _service.Delete(id);
        }
    }
}