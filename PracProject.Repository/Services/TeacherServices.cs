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
    public class TeacherServices : ITeacher
    {
        MN_ProjectEntities Context = new MN_ProjectEntities();
                TeacherHelper TeachHelper = new TeacherHelper();
        public void AddTeaccher(TeacherModel TeacherData)
        {
            try
            {
                var Data = TeachHelper.AddTeacher(TeacherData);
                Context.Teachers.Add(Data);
                Context.SaveChanges();

                
            }
            catch(Exception E)
            {
                throw E;
            }
        }

       

        public List<Teachers> TeacherTable()
        {
            try
            {
                List<Teachers> TeachersList = Context.Teachers.ToList();
                return TeachersList;
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public TeacherModel GetData(int Id)
        {
            try
            {
                var Student = Context.Teachers.Where(x => x.Id == Id).FirstOrDefault();
                return (TeachHelper.GetData(Student));

            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public void EditStudent(TeacherModel TeacherData)
        {
            try
            {
                var Data = TeachHelper.AddTeacher(TeacherData);
                Context.Sp_EditTeacher(Data.Id, Data.Name, Data.Email, Data.Subject, Data.Gender, Data.Country, Data.State);
            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}
