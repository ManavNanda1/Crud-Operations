using PracProject.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PracProject.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SubjectController : ApiController
    {
        MN_ProjectEntities Context = new MN_ProjectEntities();

        [HttpGet]

        public IHttpActionResult GetSubjectList()
        {
            try
            {
                List<Subjects> SubjectList = Context.Subjects.ToList();
                return Ok(SubjectList);
            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}
