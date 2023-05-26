using PracProject.Model.Context;
using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracProject.API.Controllers
{
    public class LoginApiController : ApiController
    {
        MN_ProjectEntities Context = new MN_ProjectEntities();

        [HttpPost]
        public IHttpActionResult LoginCheck(LoginModel LogData)
        {
            try
            {
                var User = Context.Users.Any(x => x.Email == LogData.Email && x.Password == LogData.Password);
                if (User)
                {
                    return Ok();
                }
                else
                {
                    return Unauthorized();
                }
            }
            catch(Exception E)
            {
                throw E;
            }
        }

    }
}
