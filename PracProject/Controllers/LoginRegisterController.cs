using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PracProject.Controllers
{
    public class LoginRegisterController : Controller
    {
        HttpClient ApiCon = new HttpClient();

        public ActionResult SignUp()
        {
            try
            {
                return View();

            }catch(Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult SignUp(SignUpModel SignUpData)
        {
            try
            {
                ApiCon.BaseAddress = new Uri("http://localhost:53084/api/SignUpApi");
                var Response = ApiCon.PostAsJsonAsync("SignUpApi", SignUpData);
                Response.Wait();
                var Test = Response.Result;
                if (Test.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "Sorry We Cant Add Data";
                    return View("SignUp");
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }



        public ActionResult Login()
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

        public ActionResult LoginCheck(LoginModel Logdata)
        {
            try
            {
                ApiCon.BaseAddress = new Uri("http://localhost:53084/api/LoginApi");
                var Response = ApiCon.PostAsJsonAsync("LoginApi" , Logdata);
                Response.Wait();
                var Test = Response.Result;
                if (Test.IsSuccessStatusCode)
                {
                    Session["user"] = Logdata.Email;
                    return RedirectToAction("AddStudent", "Student");
                }
                else
                {
                    ViewBag.ErrorMsg = "Invalid Credentials";
                    return View("Login");
                }
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public ActionResult logout() {

            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}