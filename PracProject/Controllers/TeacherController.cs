using PracProject.Filter;
using PracProject.Model.Model;
using PracProject.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracProject.Controllers
{
    [CustomFilter]
    public class TeacherController : Controller
    {
        ITeacher TeacherObj;

        public TeacherController(ITeacher Obj)
        {
            TeacherObj = Obj;
        }
        
        public ActionResult AddTeacher()
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
        public ActionResult Postteacher(TeacherModel Data , FormCollection FormData)
        {
            try
            {
                string Datas = FormData["Subject"];
                Data.Subject = Datas;
                TeacherObj.AddTeaccher(Data);
                return RedirectToAction("AddTeacher");
            }
            catch (Exception E)
            {

                throw E;
            }
        }

        public ActionResult GetTeacher()
        {
            try
            {
                return View(TeacherObj.TeacherTable());
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public ActionResult Edit(int Id)
        {
            try
            {
                return View(TeacherObj.GetData(Id));
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult EditData(TeacherModel TeachData)
        {
            try
            {
                TeacherObj.EditStudent(TeachData);
                return RedirectToAction("GetTeacher");
            }
            catch (Exception E)
            {

                throw E;
            }
        }
    }
}