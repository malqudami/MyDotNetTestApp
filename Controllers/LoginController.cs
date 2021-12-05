using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;

namespace api.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        
        [Route("api/[controller]/GetAll")]
        [HttpPost("{JsonBody}")]
        public IActionResult GetAll([FromBody]JsonBody data)
        {
            var jsonToReturn = JsonConvert.SerializeObject(data);
            
            return Ok(jsonToReturn);
        }
    }
}