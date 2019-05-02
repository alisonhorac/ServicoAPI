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
    public class EstadoSAPController : ControllerBase
    {
        private BaseService<EstadoSAP> service = new BaseService<EstadoSAP>();

        [HttpPost]
        public IActionResult Post([FromBody] EstadoSAP item)
        {
            try
            {
                service.Post<EstadoSAPValidator>(item);

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
        public IActionResult Put([FromBody] EstadoSAP item)
        {
            try
            {
                service.Put<EstadoSAPValidator>(item);

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