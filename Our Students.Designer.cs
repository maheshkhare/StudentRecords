namespace Students_Record_App
{
    partial class frmOurStd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pctrbox = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pctrbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pctrbox
            // 
            pctrbox.BackColor = Color.White;
            pctrbox.BorderStyle = BorderStyle.FixedSingle;
            pctrbox.Location = new Point(12, 25);
            pctrbox.Name = "pctrbox";
            pctrbox.Size = new Size(950, 449);
            pctrbox.TabIndex = 0;
            pctrbox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(364, 39);
            label1.Name = "label1";
            label1.Size = new Size(236, 42);
            label1.TabIndex = 1;
            label1.Text = "Our Students";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, Gender, Age, Class });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(57, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(869, 270);
            dataGridView1.TabIndex = 2;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            FirstName.Width = 178;
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            LastName.Width = 175;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.Width = 170;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.Width = 170;
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.Name = "Class";
            Class.Width = 170;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.White;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(805, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 42);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(658, 107);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(131, 42);
            txtSearch.TabIndex = 4;
            txtSearch.Text = "Search...";
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // frmOurStd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 486);
            Controls.Add(txtSearch);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pctrbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmOurStd";
            Text = "OurStudent";
            ((System.ComponentModel.ISupportInitialize)pctrbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHeader;
        private DataGridView dataGridView1;
        private PictureBox pctrbox;
        private Label label1;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Class;
        private Button btnAdd;
        private TextBox txtSearch;
    }
}