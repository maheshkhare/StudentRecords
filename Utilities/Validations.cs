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

            string firstNameError, lastNameError, genderError, ageError;
            //using & oprator simplified the opearation 
            isValid &= ValidateName(student.FirstName, out firstNameError, "First Name", 3, 15);
            isValid &= ValidateName(student.LastName, out lastNameError, "Last Name", 2, 18);
            isValid &= ValidateGender(student.Gender, out genderError);
            isValid &= ValidateAge(student.Age, out ageError);

            student.FirstNameError = firstNameError;
            student.LastNameError = lastNameError;
            student.GenderError = genderError;
            student.AgeError = ageError;

            return isValid;
        }

        private static bool ValidateName(string name, out string error, string fieldName, int minLength, int maxLength) //validate FirstName And LastName
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                error = $"{fieldName} is required";
                return false;
            }
            else if (name.Length < minLength || name.Length > maxLength)
            {
                error = $"{fieldName} must be between {minLength} and {maxLength} characters";
                return false;
            }
            else
            {
                error = ""; // Clear error message
                return true;
            }
        }

        private static bool ValidateGender(string gender, out string error)
        {
            if (string.IsNullOrWhiteSpace(gender))
            {
                error = "Gender is required";
                return false;
            }
            else
            {
                error = ""; // Clear error message
                return true;
            }
        }

        private static bool ValidateAge(string age, out string error)
        {
            if (string.IsNullOrWhiteSpace(age))
            {
                error = "Age is required";
                return false;
            }
            else if (!int.TryParse(age, out int parsedAge) || parsedAge < 5 || parsedAge > 99)
            {
                error = "Age must be 5-99";
                return false;
            }
            else
            {
                error = ""; // Clear error message
                return true;
            }
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
