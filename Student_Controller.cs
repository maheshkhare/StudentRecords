using Students_Record_App.Controller;
using Students_Record_App.Models;
using Students_Record_App.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Record_App
{
    public class Student_Controller
    {
        // Dependency for handling student data
        private readonly StudentDataHandler studentDataHandler;

        public Student_Controller()
        {
            studentDataHandler = StudentDataHandler.Instance;
        }

        public void AddOrUpdateStudent(Student student, int index, bool editingMode)
        {
            studentDataHandler.AddOrUpdateStudent(student, index,editingMode);
        }

        public void RemoveStudent(int index)
        {
            studentDataHandler.RemoveStudent(index);
        }

        public List<Student> GetAllStudents()
        {
            return studentDataHandler.GetAllStudents();
        }

        // Validate student input data
        public bool ValidateStudent(Student updatedStudent)
        {
            return Validations.ValidateInput(updatedStudent);
        }

        // Calculate age based on birth date
        public int CalculateAge(DateTime birthDate)
        {
            return Validations.CalculateAge(birthDate);
        }
    }
}
