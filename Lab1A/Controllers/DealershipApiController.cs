// I, Michael Bartninkas, student number 000370838, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1A.Data;
using Lab1A.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Lab1A.Controllers
{
    [Produces("application/json")]
    [Route("api/DealershipApi")]
    public class DealershipApiController : Controller
    {
        // GET: api/DealershipApi
        [HttpGet]
        public List<Dealership> Get()
        {
            return  DealershipMgr.Get();
        }

        // GET: api/DealershipApi/5
        [HttpGet("{id}", Name = "Get")]
        public Dealership Get(int id)
        {
            return DealershipMgr.Get(id);
        }
        
        // POST: api/DealershipApi
        [HttpPost]
        public void Post([FromBody]JObject value)
        {
            Dealership dealership = value.ToObject<Dealership>();
            DealershipMgr.Post(dealership);
        }
        
        // PUT: api/DealershipApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]JObject value)
        {
            Dealership dealership = value.ToObject<Dealership>();
            dealership.ID = id;
            DealershipMgr.Put(dealership);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
            DealershipMgr.Delete(id);
        }
    }
}
