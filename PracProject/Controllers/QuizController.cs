using PracProject.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracProject.Controllers
{
    public class QuizController : Controller
    {
       MN_ProjectEntities Context = new MN_ProjectEntities();
        // GET: Quiz
        public ActionResult Quiz()
        {
            try
            {
                
            return View(Context.Quizes.ToList());

            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}