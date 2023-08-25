using Students_Record_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Record_App.Utilities
{
    // Validation utility class
    public class Validations
    {
        // Validate student input data
        public static bool ValidateInput(Student student)
        { 
            bool isValid = true;

            // Validate First Name
            if (string.IsNullOrWhiteSpace(student.FirstName))
            {
                student.FirstNameError = "First Name is required";
                isValid = false;
            }
            else if (student.FirstName.Length < 3 || student.FirstName.Length > 15)
            {
                student.FirstNameError = "First Name must be between 3 and 15 characters";
                isValid = false;
            }
            else
            {
                student.FirstNameError = ""; // Clear error message
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(student.LastName))
            {
                student.LastNameError = "Last Name is required";
                isValid = false;
            }
            else if (student.LastName.Length < 2 || student.LastName.Length > 18)
            {
                student.LastNameError = "Last Name must be between 2 and 18 characters";
                isValid = false;
            }
            else
            {
                student.LastNameError = ""; // Clear error message
            }

            // Validate Gender
            if (string.IsNullOrWhiteSpace(student.Gender))
            {
                student.GenderError = "Gender is required";
                isValid = false;
            }
            else
            {
                student.GenderError = ""; // Clear error message
            }

            // Validate Age
            if (string.IsNullOrWhiteSpace(student.Age))
            {
                student.AgeError = "Age is required";
                isValid = false;
            }
            else if (!int.TryParse(student.Age, out int age) || age < 5 || age > 99)
            {
                student.AgeError = "Age must be 5-99";
                isValid = false;
            }
            else
            {
                student.AgeError = ""; // Clear error message
            }

            return isValid;
        }

        // Calculate age based on birth date
        public static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Date.Year - birthDate.Date.Year;
           
            // Adjust age if birthdate has not occurred yet this year
            return birthDate > today.Date.AddYears(-age) ? --age : age;
        }
    }
}
