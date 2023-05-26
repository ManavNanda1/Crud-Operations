using PracProject.Helper.Helper;
using PracProject.Model.Context;
using PracProject.Model.Model;
using PracProject.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProject.Repository.Services
{
    public class StudentServices : IStudent
    {
        MN_ProjectEntities Context = new MN_ProjectEntities();
        public void AddStudent(StudentModel StuData)
        {
            try
            {
                StudentHelper Stuhelper = new StudentHelper();
                var Data = Stuhelper.AddStudent(StuData);
                Context.StudentsTab.Add(Data);
                Context.SaveChanges();
            }
            catch(Exception E)
            {
                throw E;
            }
        }

       

        public List<Sp_GetStudents_Result> Studenttable()
        {
            try
            {
              var data=  Context.Sp_GetStudents().ToList();
                return data;
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public int DeleteStudent(int Id)
        {
            try
            {
                var IsPresent = Context.StudentsTab.Any(x => x.Id == Id);
                if (IsPresent)
                {
                    var Student = Context.StudentsTab.Where(x => x.Id == Id).FirstOrDefault();
                    Context.StudentsTab.Remove(Student);
                    Context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public StudentModel GetDataInEdit(int Id)
        {
            try
            {
                StudentHelper Stuhelper = new StudentHelper();
                var Student = Context.StudentsTab.Where(x => x.Id == Id).FirstOrDefault();
                return (Stuhelper.GetStudent(Student));
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public void EditStudent(StudentModel EditedData)
        {
            try
            {
                StudentHelper Stuhelper = new StudentHelper();
                var UpdatedData = Stuhelper.AddStudent(EditedData);
                Context.Sp_Edit_Student(UpdatedData.Id, UpdatedData.FName, UpdatedData.LName, UpdatedData.Email, UpdatedData.DOB, UpdatedData.Department, UpdatedData.Country, UpdatedData.State);
            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}
