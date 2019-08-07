using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get([FromQuery] string text)
        {
            if (text.Equals(string.Empty))
                text = "<Put Your Message>";
            return $"Hello {text}!";
        }
    }
}
