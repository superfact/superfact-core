﻿using System;
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
    [Route("api")]
    public class NotaDebitoController : Controller
    {
        private readonly INotaDebitoProvider _service;
        public NotaDebitoController(INotaDebitoProvider _service)
        {
            this._service = _service;
        }

        [HttpGet("organization/{organization}/debit-note")]
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

        [HttpGet("organization/{organization}/debit-note/{id}")]
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

        [HttpPost("organization/{organization}/debit-note")]
        [AllowAnonymous]
        public async Task<IActionResult> Post(string organization, [FromBody]DocumentoElectronico model)
        {
            EnviarDocumentoResponse response = new EnviarDocumentoResponse();
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

        [HttpPut("organization/{organization}/debit-note/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Put(string organization, int id, [FromBody]DocumentoElectronico model)
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

        [HttpDelete("organization/{organization}/debit-note/{id}")]
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