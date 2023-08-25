using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Record_App.Models
{
    // Entity Class
    public class Student
    {
        // class Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string? _Class { get; set; }
        public string Address { get; set; }
        public int OriginalIndex { get; set; }

        // Error message properties
        public string FirstNameError { get; set; }
        public string LastNameError { get; set; }
        public string AgeError { get; set; }
        public string GenderError { get; set; }
        public string DOBError { get; set; }

        // Parameretized constructor
        public Student(string firstName, string lastName, string gender, string age, string Class, string address, int originalIndex)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            _Class = Class;
            Address = address;
            OriginalIndex = originalIndex;
        }

        public Student()
        {
            // Initialize error message properties
            FirstNameError = string.Empty;
            LastNameError = string.Empty;
            AgeError = string.Empty;
            GenderError = string.Empty;
            DOBError = string.Empty;
        }
    }
}