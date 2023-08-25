using Students_Record_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Record_App.Controller
{
    // Interface for the Student Data Handler
    public interface IStudentDataHandler
    {
        void AddOrUpdateStudent(Student student, int index,bool editingMode);
        void RemoveStudent(int index);
        List<Student> GetAllStudents();
    }
}
