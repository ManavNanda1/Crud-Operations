using PracProject.Helper.Helper;
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
    public class SignUpApiController : ApiController
    {
         MN_ProjectEntities Context = new MN_ProjectEntities();

        [HttpPost]
        public IHttpActionResult PostUser(SignUpModel SignUpData)
        {
            try
            {
                SignUpHelper AddHelper = new SignUpHelper();
                var MainData = AddHelper.AddUser(SignUpData);
                Context.Users.Add(MainData);
                Context.SaveChanges();
                return Ok();

            }
            catch(Exception E)
            {
                throw E;
            }
        }

    }
}
