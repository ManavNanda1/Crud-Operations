using PracProject.Model.Context;
using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProject.Helper.Helper
{
    public class StudentHelper
    {
        public StudentsTab AddStudent(StudentModel StuData)
        {
            try
            {
                StudentsTab Data = new StudentsTab();
                Data.Id = StuData.Id;
                Data.FName = StuData.FName;
                Data.LName = StuData.LName;
                Data.Email = StuData.Email;
                Data.Department = StuData.Department;
                Data.Country = StuData.Country;
                Data.State = StuData.State;
                return Data;
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public StudentModel GetStudent (StudentsTab StuUpdate)
        {
            try
            {
                StudentModel Data = new StudentModel();
                Data.Id = StuUpdate.Id;
                Data.FName = StuUpdate.FName;
                Data.LName = StuUpdate.LName;
                Data.Email = StuUpdate.Email;
                Data.Department = StuUpdate.Department;
                Data.Country = (int)StuUpdate.Country;
                Data.State = (int)StuUpdate.State;

                return Data;

            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}
