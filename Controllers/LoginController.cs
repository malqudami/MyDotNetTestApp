using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Data.OleDb;

namespace api.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {

        static OleDbConnection con = new OleDbConnection("");
        private static DataTable checkUser(string username, string Passwd)
        {
            DataTable dt = new DataTable();
            return dt;
        }

        
        [Route("api/[controller]/GetAll")]
        [HttpPost]
        public IActionResult GetAll([FromBody]JsonBody data, [FromHeader]string Token)
        {
            var jsonToReturn = JsonConvert.SerializeObject(data);

            if(Token == "testToken2022")            
                return Ok(jsonToReturn);
            else
                return Unauthorized("Unauthorized");
        }
    }
}