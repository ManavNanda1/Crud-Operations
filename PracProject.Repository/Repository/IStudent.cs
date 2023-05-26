using PracProject.Model.Context;
using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProject.Repository.Repository
{
    public interface IStudent
    {
          void AddStudent(StudentModel StuData);
          List<Sp_GetStudents_Result> Studenttable();

          int DeleteStudent(int Id);

        StudentModel GetDataInEdit(int Id);

        void EditStudent(StudentModel EditedData);
    }
}
