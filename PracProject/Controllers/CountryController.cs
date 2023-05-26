using PracProject.Filter;
using PracProject.Model.Context;
using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PracProject.Controllers
{
    [CustomFilter]
    public class CountryController : Controller
    {
        HttpClient ApiCon = new HttpClient();
        public ActionResult AddCountry()
        {
            try
            {
                return View();
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult PostCountry(CountryModel Data)
        {
            try
            {
                ApiCon.BaseAddress = new Uri("http://localhost:53084/api/Country");
                var Response = ApiCon.PostAsJsonAsync("Country", Data);
                Response.Wait();
                var Test = Response.Result;
                if (Test.IsSuccessStatusCode)
                {
                    RedirectToAction("AddStudent", "Student");
                }
                return View("AddCountry");
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public ActionResult Countries()
        {
            try
            {
                List<Country> MainData = new List<Country>();
                ApiCon.BaseAddress = new Uri("http://localhost:53084/api/Country");
                var Response = ApiCon.GetAsync("Country");
                Response.Wait();
                var Test = Response.Result;
                if (Test.IsSuccessStatusCode)
                {
                    var Results = Test.Content.ReadAsAsync<List<Country>>();
                    Results.Wait();
                    MainData = Results.Result;

                }
                return View(MainData);
            }
            catch(Exception E)
            {
                throw E;
            }
        }

   
        public ActionResult DelCountry(int Id)
        {
            try
            {
                ApiCon.BaseAddress = new Uri("http://localhost:53084/api/Country");
                var Response = ApiCon.DeleteAsync("Country/" +  Id.ToString());
                Response.Wait();
                var Test = Response.Result;
                if (Test.IsSuccessStatusCode)
                {
                    return RedirectToAction("Countries");
                }
                return View("Countries");
            }
            catch(Exception E)
            {
                throw E;
            }
        }

       
    }
}