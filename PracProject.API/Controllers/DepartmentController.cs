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
    public class DepartmentController : ApiController
    {
        MN_ProjectEntities Context = new MN_ProjectEntities();

        [HttpGet]
        public IHttpActionResult GetDeptDpd()
        {
            try
            {
                List<department> DeptList = Context.department.ToList();
                return Ok(DeptList);
            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}
