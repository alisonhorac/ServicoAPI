using System;
using AHAS.WS.LOGIC.DOMAIN.Entities;
using AHAS.WS.LOGIC.SERVICE.Services;
using AHAS.WS.LOGIC.SERVICE.Validators;
using Microsoft.AspNetCore.Mvc;

namespace AHAS.WS.WEB.APPLICATION.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ContaContabilController : ControllerBase
    {
        private BaseService<ContaContabil> service = new BaseService<ContaContabil>();

        [HttpPost]
        public IActionResult Post([FromBody] ContaContabil item)
        {
            try
            {
                service.Post<ContaContabilValidator>(item);

                return new ObjectResult(item.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] ContaContabil item)
        {
            try
            {
                service.Put<ContaContabilValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Delete(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}