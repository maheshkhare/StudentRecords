using System.Windows.Forms;

namespace Students_Record_App
{
    public partial class Our_Students : Form
    {
        private List<Student> students = new List<Student>();

        public Our_Students()
        {
            InitializeComponent();
            Add_Edit_Students add_Edit_Students = new Add_Edit_Students(this);
        }

        public Our_Students(Student newStudent)
        {
            InitializeComponent();
            dataGridView1.Rows.Add(newStudent.FirstName, newStudent.LastName, newStudent.Gender, newStudent.Age, newStudent._Class);
        }
        private void Our_Students_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Elon", "Musk", "Male", 34, "5th Grade");
            dataGridView1.Rows.Add("Sunder", "Pichai", "Male", 44, "8th Grade");

            dataGridView1.Rows[0].Selected = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Student studentToEdit = new Student(
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value),
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()
            );


            Add_Edit_Students editform = new Add_Edit_Students(studentToEdit, dataGridView1); // Pass the selected student
            if (editform.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows[e.RowIndex].SetValues(
                    editform.StudentToEdit.FirstName,
                    editform.StudentToEdit.LastName,
                    editform.StudentToEdit.Gender,
                    editform.StudentToEdit.Age,
                    editform.StudentToEdit._Class

                );
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Edit_Students ae = new Add_Edit_Students(this);
            ae.ShowDialog();
        }


    }
}