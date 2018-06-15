using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWapper;

namespace CoreService.Controllers
{
    [Produces("application/json")]
    [Route("api/Core")]
    public class CoreController : Controller
    {
        // GET: api/Core
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Core/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return CWap.Add(id, 10).ToString();
        }
        
        // POST: api/Core
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Core/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
