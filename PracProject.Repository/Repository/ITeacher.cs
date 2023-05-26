using PracProject.Model.Context;
using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProject.Repository.Repository
{
    public interface ITeacher
    {
        void AddTeaccher(TeacherModel TeacherData);

        List<Teachers> TeacherTable();

        TeacherModel GetData(int Id);

        void EditStudent(TeacherModel TeacherData);
    }
}