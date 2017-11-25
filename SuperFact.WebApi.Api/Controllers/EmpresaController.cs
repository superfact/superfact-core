using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperFact.Model.Contract.Modelos;
using SuperFact.Entity.Model;
using SuperFact.Business.IService;
using SuperFact.Model.Contract.Intercambio;

namespace SuperFact.WebApi.Api.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class EmpresaController : Controller
    {
        private readonly IEmpresaProvider _service;
        public EmpresaController(IEmpresaProvider _service)
        {
            this._service = _service;
        }

        [HttpGet("organization")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (Exception ex)
            {
                throw new SuperFactException(ex.Message, ex.InnerException);
            }
        }

        [HttpGet("organization/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (Exception ex)
            {
                throw new SuperFactException(ex.Message, ex.InnerException);
            }
        }        

        [HttpPost("organization")]
        public async Task<IActionResult> Post([FromBody]EmpresaModel model)
        {
            try
            {
                if (model == null) return BadRequest();
                EmpresaModel result= await _service.Post(model);
                return Created(nameof(Get), new { id = result.Id });
            }
            catch (Exception ex)
            {
                throw new SuperFactException(ex.Message, ex.InnerException);
            }
        }

        [HttpPut("organization/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]EmpresaModel model)
        {
            try
            {
                // if (!ModelState.IsValid) return BadRequest(ModelState);
                if (model == null || model.Id != id) return BadRequest();
                return Ok(await _service.Put(model));
            }
            catch (Exception ex)
            {
                throw new SuperFactException(ex.Message, ex.InnerException);
            }
        }

        [HttpDelete("organization/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new SuperFactException(ex.Message, ex.InnerException);
            }
        }
    }
}