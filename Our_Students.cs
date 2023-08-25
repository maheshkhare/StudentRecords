using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Students_Record_App.Models;
using Students_Record_App.Controller;

namespace Students_Record_App
{
    public partial class Our_Students : Form
    {
        // Data Members
        private List<Student> studentList;
        public Student_Controller student_Controller;
        public const string YearText = " years";

        public Our_Students()
        {
            InitializeComponent();
        }

        // Handle form loading
        private void Our_Students_Load_1(object sender, EventArgs e)
        {
            //Configure dataGridView appearance
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, dataGridView1.Font.Size + 1, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;

            UpdateDataGridView();
            // Select the first row by default
            dataGridView1.Rows[0].Selected = true;
        }

        // Update DataGridView with student data
        public void UpdateDataGridView()
        {
            student_Controller = new Student_Controller();
            studentList = student_Controller.GetAllStudents();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < studentList.Count; i++)
            {
                studentList[i].OriginalIndex = i;

                int rowIndex = dataGridView1.Rows.Add(studentList[i].FirstName, studentList[i].LastName, studentList[i].Gender, studentList[i].Age + YearText, studentList[i]._Class, studentList[i].Address);
                dataGridView1.Rows[rowIndex].Tag = studentList[i].OriginalIndex;
            }
        }

        // Handle add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Edit_Students ae = new Add_Edit_Students();
            ae.Add_Student_Click();
            ae.ShowDialog();
            UpdateDataGridView();
        }

        // Handle double-click on DataGridView cell
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                int originalIndex = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Tag); // Retrieve originalIndex from the Tag property

                Add_Edit_Students editform = new Add_Edit_Students(); // Pass the selected student
                editform.Handle_Cell_Content_DoubleClick(originalIndex);

                if (editform.ShowDialog() == DialogResult.OK)
                {
                    UpdateDataGridView();
                }
            }
        }

        // Filter rows in DataGridView based on search term
        private void Search_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = Search.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool matched = false;

                for (int columnIndex = 0; columnIndex < row.Cells.Count - 2; columnIndex++) // Exclude last two columns (Class and Address)
                {
                    DataGridViewCell cell = row.Cells[columnIndex];

                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {
                        matched = true;
                        break;
                    }
                }
                row.Visible = matched;
            }
        }

        // Other Events
        private void Search_MouseClick(object sender, MouseEventArgs e)
        {
            Search.Text = "";
        }
        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' && (Search.Text.EndsWith(" ")))
            {
                e.Handled = true;
            }
        }
    }
}