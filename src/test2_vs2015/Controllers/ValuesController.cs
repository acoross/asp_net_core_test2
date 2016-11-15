using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace test2_vs2015.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]string value)
        {
            return NotFound();
        }
    }
}
