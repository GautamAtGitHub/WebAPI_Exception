using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Exception.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new Exception("Something Went wrong"); // Bad Practice, it produces 500 internal server error
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                if (id == 101)
                {
                    throw new Exception("Incorrect ID");
                }

                return new ObjectResult("value " + id);
            }
            catch (Exception ex)
            {
                // Good practice, this gives user more useful information
                return new BadRequestObjectResult(ExceptionHelper.ProcessError(ex)); 
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
