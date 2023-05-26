using PracProject.Model.Context;
using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProject.Helper.Helper
{
    public class TeacherHelper
    {
        public Teachers AddTeacher (TeacherModel TeachData)
        {
            try
            {
                Teachers Data = new Teachers();
                Data.Id = TeachData.Id;
                Data.Name = TeachData.Name;
                Data.Email = TeachData.Email;
                Data.Gender = TeachData.Gender;
                Data.Subject = TeachData.Subject;
                Data.Country = TeachData.Country;
                Data.State = TeachData.State;

                return Data;
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public TeacherModel GetData( Teachers TeachData)
        {
            try
            {
                TeacherModel Data = new TeacherModel();
                Data.Id = TeachData.Id;
                Data.Name = TeachData.Name;
                Data.Email = TeachData.Email;
                Data.Gender = TeachData.Gender;
                Data.Subject = TeachData.Subject;
                Data.Country = (int)TeachData.Country;
                Data.State = (int)TeachData.State;

                return Data;
            }
            catch (Exception E)
            {
                throw E;
            }
        }

    }
}
