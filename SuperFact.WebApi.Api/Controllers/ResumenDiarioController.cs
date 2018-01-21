using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperFact.Business.IService;
using SuperFact.Model.Contract.Intercambio;
using SuperFact.Model.Contract.Modelos;

namespace SuperFact.WebApi.Api.Controllers
{
    [Produces("application/json")]
    [EnableCors("AllowCors"), Route("api")]
    public class ResumenDiarioController : Controller
    {
        private readonly IResumenDiarioProvider _service;
        public ResumenDiarioController(IResumenDiarioProvider _service)
        {
            this._service = _service;
        }

        [HttpGet("organization/{organization}/summary")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll(string organization)
        {
            try
            {
                return Ok(await _service.GetAll(organization));
            }
            catch (Exception ex)
            {
                throw new SuperFactException(ex.Message, ex.InnerException);
            }
        }

        [HttpGet("organization/{organization}/summary/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(string organization, int id)
        {
            try
            {
                return Ok(await _service.Get(organization, id));
            }
            catch (Exception ex)
            {
                throw new SuperFactException(ex.Message, ex.InnerException);
            }
        }

        [HttpPost("organization/{organization}/summary")]
        [AllowAnonymous]
        public async Task<IActionResult> Post(string organization, [FromBody]ResumenDiarioNuevo model)
        {
            EnviarResumenResponse response = new EnviarResumenResponse();
            try
            {
                response = await _service.Generar(organization, model);
                response.Exito = true;
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw new SuperFactException(ex.Message, ex.InnerException);
            }
        }

        [HttpPut("organization/{organization}/summary/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Put(string organization, int id, [FromBody]ResumenDiarioNuevo model)
        {
            try
            {
                return Ok(await _service.Put(organization, model));
            }
            catch (Exception ex)
            {
                throw new SuperFactException(ex.Message, ex.InnerException);
            }
        }

        [HttpDelete("organization/{organization}/summary/{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(string organization, int id)
        {
            try
            {
                await _service.Delete(organization, id);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new SuperFactException(ex.Message, ex.InnerException);
            }
        }
    }
}