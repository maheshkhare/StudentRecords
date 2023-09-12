using Students_Record_App.Controller;
using Students_Record_App.Models;
using Students_Record_App.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Students_Record_App
{
    public partial class Add_Edit_Students : Form
    {
        // Fields for managing student records
        private List<Student>? studentList;
        int index;
        private bool editingMode;
        // Dependencies and constants
        private Student_Controller? student_Controller;
        private const string? AddressPlaceholder = "Please Enter Address";
        private const string? GenderPlaceholder = "Please Select Gender";

        public Add_Edit_Students()
        {
            InitializeComponent();

            cmbGender.Font = new Font(cmbGender.Font.FontFamily, 11, FontStyle.Regular);

            // DateTimePicker control to show only the past 99 years and todays date
            DateTime maxAllowedDate = DateTime.Today;
            dtPicker.MaxDate = maxAllowedDate;

            DateTime minAllowedDate = DateTime.Today.AddYears(-99);
            dtPicker.MinDate = minAllowedDate;
        }

        // Initialize UI for adding a student
        public void Add_Student_Click()
        {
            lblHeader.Text = "Add Student";
            btnDelete.Visible = false;
            editingMode = false;

            txtAddress.Text = AddressPlaceholder;
            txtAddress.ForeColor = Color.Gray;

            cmbGender.Text = GenderPlaceholder;
            cmbGender.ForeColor = Color.Gray;
            txtAge.Clear();
        }

        // Handle double-click on cell content for editing
        public void Handle_Cell_Content_DoubleClick(ref int index)
        {
            this.index = index;

            lblHeader.Text = "Edit Student";
            btnDelete.Visible = true;
            editingMode = true;

            student_Controller = new Student_Controller();
            studentList = student_Controller.GetAllStudents();

            // Populate fields with student data
            txtBoxFirstName.Text = studentList[index].FirstName;
            txtBoxLastName.Text = studentList[index].LastName;
            cmbGender.Text = studentList[index].Gender;
            txtClass.Text = studentList[index].Class ?? string.Empty;
            txtAge.Text = studentList[index].Age.ToString();
            txtAddress.Text = studentList[index].Address.ToString();

            cmbGender.ForeColor = SystemColors.WindowText;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;

            // Ternary Operator for Handling Address text Forecolor
            txtAddress.ForeColor = txtAddress.Text == AddressPlaceholder ? Color.Gray : SystemColors.WindowText;
        }

        // Handle save button click
        private void btnSave_Click(object sender, EventArgs e)
        {
            student_Controller = new Student_Controller();
            studentList = student_Controller.GetAllStudents();

            //if editMode is true then take incoming index otherwise new index
            int studentIndex = editingMode ? index : studentList.Count;

            //take data from control
            Student updatedStudent = new Student(
                txtBoxFirstName.Text.Trim(),
                txtBoxLastName.Text.Trim(),
                cmbGender.SelectedItem?.ToString() ?? "",
                txtAge.Text,
                txtClass.Text.Trim(),
                txtAddress.Text.Trim(),
                studentIndex
            );

            bool isValid = Validations.ValidateInput(updatedStudent);

            // Display validation errors if not valid
            if (!isValid)
            {
                DisplayValidationErrors(updatedStudent);
                return;
            }

            // Add or update student data
            student_Controller.AddOrUpdateStudent(updatedStudent, ref studentIndex, editingMode);
            DialogResult = DialogResult.OK;
            Close();
        }

        // Handle delete button click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student record?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                student_Controller = new Student_Controller();
                student_Controller.RemoveStudent(index);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public void DisplayValidationErrors(Student updatedStudent)
        {
            lblFirstNameError.Text = updatedStudent.FirstNameError;
            lblLastNameError.Text = updatedStudent.LastNameError;
            lblAgeError.Text = updatedStudent.AgeError;
            lblGenderError.Text = updatedStudent.GenderError;
            lblDOBError.Text = updatedStudent.DOBError;
        }
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            //parsing from text to age , and if successfull return by using out keyword 
            if (int.TryParse(string.IsNullOrEmpty(txtAge.Text) ? "0" : txtAge.Text, out int age))
            {
                DateTime currentDate = DateTime.Today;
                DateTime birthDate = currentDate.AddYears(-age);
                dtPicker.Value = birthDate;
            }
        }

        // Update age when birthdate changes
        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            student_Controller = new Student_Controller();

            DateTime birthDate = dtPicker.Value;
            int age = Validations.CalculateAge(birthDate);

            // Update the txtAge TextBox control
            txtAge.Text = age == 0 ? "" : age.ToString();
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validate and control input for age
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007F')
            {
                e.Handled = true; // Suppress the character input
            }

            if (char.IsDigit(e.KeyChar))
            {
                int age = int.Parse(txtAge.Text + e.KeyChar); // Combine existing text and new character
                if (age > 99)
                {
                    e.Handled = true;
                }
            }
        }

        // Handle key press events for name 
        private void txtBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBoxLastName_KeyPress(sender, e);
        }

        private void txtBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Suppress the character input
            }
        }

        // Handle placeholder text for address field
        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == AddressPlaceholder)
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = SystemColors.WindowText;
                txtAddress.ScrollBars = ScrollBars.Vertical;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                txtAddress.Text = AddressPlaceholder;
                txtAddress.ForeColor = Color.Gray;
                txtAddress.ScrollBars = ScrollBars.None;
            }
        }

        // Handle gender field appearance and behavior
        private void cmbGender_Enter_1(object sender, EventArgs e)
        {
            if (cmbGender.SelectedIndex == -1)
            {
                cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;

                cmbGender.ForeColor = SystemColors.WindowText;
                cmbGender.DroppedDown = true;
            }
        }

        private void cmbGender_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
                ForeColor = SystemColors.WindowText;
                cmbGender.SelectedIndex = 0;
            }
        }

        private void cmbGender_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbGender.SelectedIndex == -1)
            {
                this.ActiveControl = lblGender;
                cmbGender.DropDownStyle = ComboBoxStyle.DropDown;
                cmbGender.Text = GenderPlaceholder;
                cmbGender.ForeColor = Color.Gray;
            }
        }
    }
}