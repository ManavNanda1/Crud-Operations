using PracProject.Model.Context;
using PracProject.Model.Model;
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
    public class CountryController : ApiController
    {
        MN_ProjectEntities Context = new MN_ProjectEntities();

        [HttpGet]
        public IHttpActionResult GetCountryList()
        {
            try
            {
                Context.Configuration.ProxyCreationEnabled = false;
                List<Country> CountryList = Context.Country.ToList();
                return Ok(CountryList);
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        [HttpPost]

        public IHttpActionResult AddCountry(CountryModel Data)
        {
            try
            {
                Country MainModel = new Country();
                MainModel.id = Data.Id;
                MainModel.Name = Data.name;
                Context.Country.Add(MainModel);
                Context.SaveChanges();
                return Ok();
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteCountry(int Id)
        {
            try
            {
                var isPresent = Context.Country.Any(x => x.id == Id);
                if (isPresent)
                {
                    var Country = Context.Country.Where(x => x.id == Id).FirstOrDefault();
                    Context.Country.Remove(Country);
                    Context.SaveChanges();
                    return Ok();
                }
                return Ok();
            }
            catch (Exception E)
            {
                throw E;
            }
        }
    }
}
