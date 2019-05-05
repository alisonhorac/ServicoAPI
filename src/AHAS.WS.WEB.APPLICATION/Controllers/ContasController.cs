using System;
using System.Data.SqlClient;
using System.Net.Http;
using AHAS.WS.LOGIC.DOMAIN.Entities;
using AHAS.WS.LOGIC.DOMAIN.Interfaces.Service;
using AHAS.WS.LOGIC.SERVICE.Validators;
using Microsoft.AspNetCore.Mvc;

namespace AHAS.WS.WEB.APPLICATION.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly IContaContabilService _service;
        private readonly IBaseService<ContaContabil> _baseService;

        public ContasController(IContaContabilService contaContabilService, IBaseService<ContaContabil> baseService)
        {
            _service = contaContabilService;
            _baseService = baseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ContaContabil item)
        {
            try
            {
                _baseService.Post<ContaContabilValidator>(item);

                return Ok(item.Id);
            }
            catch (HttpRequestException ex)
            {
                return NotFound(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (SqlException ex)
            {
                return StatusCode(503, string.Format("{0}-{1}",ex.Number, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] ContaContabil item)
        {
            try
            {
                _baseService.Put<ContaContabilValidator>(item);

                return Ok(item);
            }
            catch (HttpRequestException ex)
            {
                return NotFound(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (SqlException ex)
            {
                return StatusCode(503, string.Format("{0}-{1}",ex.Number, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _baseService.Delete(id);

                return NoContent();
            }
            catch (HttpRequestException ex)
            {
                return NotFound(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (SqlException ex)
            {
                return StatusCode(503, string.Format("{0}-{1}",ex.Number, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_baseService.Get());
            }
            catch (HttpRequestException ex)
            {
                return NotFound(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (SqlException ex)
            {
                return StatusCode(503, string.Format("{0}-{1}",ex.Number, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_baseService.Get(id));
            }
            catch (HttpRequestException ex)
            {
                return NotFound(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (SqlException ex)
            {
                return StatusCode(503, string.Format("{0}-{1}",ex.Number, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}