using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace test2_vs2015.Controllers
{

    public class LoginRequest
    {
        public long id
        {
            set;
            get;
        }

        public string password
        {
            set;
            get;
        }
    }

    public class LoginResponse
    {
        public long id
        {
            set;
            get;
        }

        public string nickname
        {
            set;
            get;
        }
    }

    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        // POST api/values
        [HttpPost]
        public LoginResponse Post([FromBody]LoginRequest login_req)
        {
            return new LoginResponse { id = 1, nickname = "shin" };
        }
    }
}
