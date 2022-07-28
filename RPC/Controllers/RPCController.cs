using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RPC.Models;
namespace RPC.Controllers
{
    public class RPCController : ApiController
    {
        [Route("{from}/{amount}/{to}")]
        [HttpGet]
        public IHttpActionResult GetCurrency(string from, string amount, string to )
        {
           var result = Fixer.GetConvertedCurrency(from, amount, to);
            if(result == null)
            {
                return NotFound();
            }
            var response = string.Format("{0}{1} in {2} is {3}", result.query.amount, result.query.from, result.query.to, result.result);
            return Ok(response);
        }
    }
}
