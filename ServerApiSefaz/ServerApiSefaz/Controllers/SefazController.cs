using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerApiSefaz.Services;

namespace ServerApiSefaz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SefazController : ControllerBase
    {
        private SefazService _service;

        public SefazController(SefazService sefaz)
        {
            _service = sefaz;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var doc = _service.GetDocumento();
                return Ok(doc);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
