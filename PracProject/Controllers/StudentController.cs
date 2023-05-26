using PracProject.Model.Model;
using PracProject.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
using PracProject.Model.Context;
using PracProject.Filter;

namespace PracProject.Controllers
{
    [CustomFilter]
    public class StudentController : Controller
    {
        IStudent StudentObj;

        public StudentController (IStudent Obj)
        {
            StudentObj = Obj;
        }

        public ActionResult AddStudent()
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

        public ActionResult AddStudent(StudentModel StuData , FormCollection FormData)
        {
            try
            {
                string data = FormData["Department"];
                StuData.Department = data;
                StudentObj.AddStudent(StuData);
                return RedirectToAction("Index", "Home");
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public ActionResult GetStudentTable()
        {
            try
            {
                
                return View (GetStudentByIndex(1));
            }
            catch(Exception E)
            {
                throw E;
            }
        }
      
        public ActionResult After(int id)
        {
            try
            {
                return View(GetStudentByIndex(id));
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public ActionResult Delete(int Id)
        {
            try
            {
                StudentObj.DeleteStudent(Id);
                return RedirectToAction("GetStudentTable");
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
                return View(StudentObj.GetDataInEdit(Id));
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult Edit(StudentModel Data)
        {
            try
            {
                StudentObj.EditStudent(Data);
                return RedirectToAction("GetStudentTable");
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public List<Sp_GetStudents_Result> GetStudentByIndex(int id)
        {
            int maxRacord = 5;
            TempData["Record"] = Math.Ceiling((decimal)StudentObj.Studenttable().Count() / maxRacord);
            return StudentObj.Studenttable().OrderBy(x => x.Id).Skip((id - 1) * maxRacord).Take(maxRacord).ToList();
        }
    }
}