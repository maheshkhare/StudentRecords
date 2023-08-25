using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students_Record_App.Models;

//Centrialized Data Management
namespace Students_Record_App.Controller
{
    public class StudentDataHandler:IStudentDataHandler
    {
        // Singleton instance
        private static StudentDataHandler instance;
        public static StudentDataHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentDataHandler();
                }
                return instance;
            }
        }

        // List to store student data like act as Database
        private static List<Student> studentList = new List<Student>
        {
            new Student("Elon", "Musk", "Male", "34", "5th Grade", "ABC",0),
            new Student("Sundar", "Pichai", "Male", "44", "8th Grade", "XYZ", 1)
        };

        public void AddOrUpdateStudent(Student student, int index,bool editingMode)
        {
            if (index >= 0 && index < studentList.Count && editingMode)
            {
                // Update an existing student's data
                studentList.RemoveAt(index);
                studentList.Insert(index, student);
            }
            else
            {
                // Add a new student
                studentList.Add(student);
            }
        }

        // Remove a student from the list
        public void RemoveStudent(int index)
        {
            if (index >= 0 && index < studentList.Count)
            {
                studentList.RemoveAt(index);
            }
        }

        // Get a list of all studentList
        public List<Student> GetAllStudents()
        {
            return studentList;
        }
    }
}
