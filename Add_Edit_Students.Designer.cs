namespace Students_Record_App
{
    partial class Add_Edit_Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlAddEditStudent = new Panel();
            lblAgeError = new Label();
            lblDOBError = new Label();
            lblLastNameError = new Label();
            lblGenderError = new Label();
            lblFirstNameError = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            Req1 = new Label();
            dtPicker = new DateTimePicker();
            btnCancel = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            lblYear = new Label();
            lblDOB = new Label();
            lblGender = new Label();
            cmbGender = new ComboBox();
            txtBoxLastName = new TextBox();
            lblLastName = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtClass = new TextBox();
            lblClass = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            txtBoxFirstName = new TextBox();
            lblFirstName = new Label();
            lblHeader = new Label();
            errorProvider = new ErrorProvider(components);
            pnlAddEditStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlAddEditStudent
            // 
            pnlAddEditStudent.BackColor = Color.White;
            pnlAddEditStudent.BorderStyle = BorderStyle.FixedSingle;
            pnlAddEditStudent.Controls.Add(lblAgeError);
            pnlAddEditStudent.Controls.Add(lblDOBError);
            pnlAddEditStudent.Controls.Add(lblLastNameError);
            pnlAddEditStudent.Controls.Add(lblGenderError);
            pnlAddEditStudent.Controls.Add(lblFirstNameError);
            pnlAddEditStudent.Controls.Add(label6);
            pnlAddEditStudent.Controls.Add(label5);
            pnlAddEditStudent.Controls.Add(label4);
            pnlAddEditStudent.Controls.Add(label2);
            pnlAddEditStudent.Controls.Add(Req1);
            pnlAddEditStudent.Controls.Add(dtPicker);
            pnlAddEditStudent.Controls.Add(btnCancel);
            pnlAddEditStudent.Controls.Add(btnSave);
            pnlAddEditStudent.Controls.Add(btnDelete);
            pnlAddEditStudent.Controls.Add(lblYear);
            pnlAddEditStudent.Controls.Add(lblDOB);
            pnlAddEditStudent.Controls.Add(lblGender);
            pnlAddEditStudent.Controls.Add(cmbGender);
            pnlAddEditStudent.Controls.Add(txtBoxLastName);
            pnlAddEditStudent.Controls.Add(lblLastName);
            pnlAddEditStudent.Controls.Add(txtAddress);
            pnlAddEditStudent.Controls.Add(lblAddress);
            pnlAddEditStudent.Controls.Add(txtClass);
            pnlAddEditStudent.Controls.Add(lblClass);
            pnlAddEditStudent.Controls.Add(txtAge);
            pnlAddEditStudent.Controls.Add(lblAge);
            pnlAddEditStudent.Controls.Add(txtBoxFirstName);
            pnlAddEditStudent.Controls.Add(lblFirstName);
            pnlAddEditStudent.Controls.Add(lblHeader);
            pnlAddEditStudent.Location = new Point(39, 45);
            pnlAddEditStudent.Margin = new Padding(4, 5, 4, 5);
            pnlAddEditStudent.Name = "pnlAddEditStudent";
            pnlAddEditStudent.Size = new Size(766, 752);
            pnlAddEditStudent.TabIndex = 0;
            // 
            // lblAgeError
            // 
            lblAgeError.AutoSize = true;
            lblAgeError.ForeColor = Color.Red;
            lblAgeError.Location = new Point(585, 391);
            lblAgeError.Margin = new Padding(4, 0, 4, 0);
            lblAgeError.Name = "lblAgeError";
            lblAgeError.Size = new Size(0, 25);
            lblAgeError.TabIndex = 54;
            // 
            // lblDOBError
            // 
            lblDOBError.AutoSize = true;
            lblDOBError.ForeColor = Color.Red;
            lblDOBError.Location = new Point(196, 388);
            lblDOBError.Margin = new Padding(4, 0, 4, 0);
            lblDOBError.Name = "lblDOBError";
            lblDOBError.Size = new Size(0, 25);
            lblDOBError.TabIndex = 53;
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.ForeColor = Color.Red;
            lblLastNameError.Location = new Point(196, 248);
            lblLastNameError.Margin = new Padding(4, 0, 4, 0);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(0, 25);
            lblLastNameError.TabIndex = 52;
            // 
            // lblGenderError
            // 
            lblGenderError.AutoSize = true;
            lblGenderError.ForeColor = Color.Red;
            lblGenderError.Location = new Point(196, 322);
            lblGenderError.Margin = new Padding(4, 0, 4, 0);
            lblGenderError.Name = "lblGenderError";
            lblGenderError.Size = new Size(0, 25);
            lblGenderError.TabIndex = 51;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.ForeColor = Color.Red;
            lblFirstNameError.Location = new Point(196, 169);
            lblFirstNameError.Margin = new Padding(4, 0, 4, 0);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(0, 25);
            lblFirstNameError.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(565, 353);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(25, 32);
            label6.TabIndex = 49;
            label6.Text = "*";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(173, 351);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(25, 32);
            label5.TabIndex = 48;
            label5.Text = "*";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(113, 283);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(25, 32);
            label4.TabIndex = 47;
            label4.Text = "*";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(148, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 31);
            label2.TabIndex = 45;
            label2.Text = "*";
            // 
            // Req1
            // 
            Req1.AutoSize = true;
            Req1.BackColor = Color.Transparent;
            Req1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Req1.ForeColor = Color.Red;
            Req1.Location = new Point(145, 208);
            Req1.Margin = new Padding(4, 0, 4, 0);
            Req1.Name = "Req1";
            Req1.Size = new Size(24, 31);
            Req1.TabIndex = 43;
            Req1.Text = "*";
            // 
            // dtPicker
            // 
            dtPicker.Format = DateTimePickerFormat.Short;
            dtPicker.Location = new Point(202, 353);
            dtPicker.Margin = new Padding(4, 5, 4, 5);
            dtPicker.MaxDate = new DateTime(2023, 8, 23, 0, 0, 0, 0);
            dtPicker.MinDate = new DateTime(1923, 8, 23, 0, 0, 0, 0);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(263, 31);
            dtPicker.TabIndex = 3;
            dtPicker.Value = new DateTime(2023, 8, 23, 0, 0, 0, 0);
            dtPicker.ValueChanged += dtPicker_ValueChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlLight;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(585, 666);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 41);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(401, 666);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 41);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightGray;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(31, 666);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 41);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.BackColor = Color.White;
            lblYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblYear.Location = new Point(683, 361);
            lblYear.Margin = new Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(49, 28);
            lblYear.TabIndex = 38;
            lblYear.Text = "year";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.BackColor = Color.White;
            lblDOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDOB.Location = new Point(28, 356);
            lblDOB.Margin = new Padding(4, 0, 4, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(154, 32);
            lblDOB.TabIndex = 37;
            lblDOB.Text = "Date Of Birth";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.White;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(28, 286);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(92, 32);
            lblGender.TabIndex = 35;
            lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.DropDownWidth = 255;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(202, 283);
            cmbGender.Margin = new Padding(4, 5, 4, 5);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(255, 33);
            cmbGender.TabIndex = 2;
            cmbGender.DropDownClosed += cmbGender_DropDownClosed;
            cmbGender.Enter += cmbGender_Enter_1;
            cmbGender.PreviewKeyDown += cmbGender_PreviewKeyDown;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.Location = new Point(202, 208);
            txtBoxLastName.Margin = new Padding(4, 5, 4, 5);
            txtBoxLastName.MaxLength = 25;
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.PlaceholderText = "Please Enter Last Name";
            txtBoxLastName.Size = new Size(523, 37);
            txtBoxLastName.TabIndex = 1;
            txtBoxLastName.KeyPress += txtBoxLastName_KeyPress;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.White;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(28, 211);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(126, 32);
            lblLastName.TabIndex = 32;
            lblLastName.Text = "Last Name";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(202, 499);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.MaxLength = 150;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(523, 117);
            txtAddress.TabIndex = 6;
            txtAddress.Enter += txtAddress_Enter;
            txtAddress.Leave += txtAddress_Leave;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.White;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(28, 503);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(98, 32);
            lblAddress.TabIndex = 30;
            lblAddress.Text = "Address";
            // 
            // txtClass
            // 
            txtClass.BorderStyle = BorderStyle.FixedSingle;
            txtClass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtClass.Location = new Point(202, 423);
            txtClass.Margin = new Padding(4, 5, 4, 5);
            txtClass.MaxLength = 30;
            txtClass.Name = "txtClass";
            txtClass.PlaceholderText = "Please Enter Class Name";
            txtClass.Size = new Size(523, 37);
            txtClass.TabIndex = 5;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.BackColor = Color.White;
            lblClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClass.Location = new Point(28, 426);
            lblClass.Margin = new Padding(4, 0, 4, 0);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(67, 32);
            lblClass.TabIndex = 28;
            lblClass.Text = "Class";
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(590, 351);
            txtAge.Margin = new Padding(4, 5, 4, 5);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(92, 37);
            txtAge.TabIndex = 4;
            txtAge.TextChanged += txtAge_TextChanged;
            txtAge.KeyPress += txtAge_KeyPress;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.White;
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAge.Location = new Point(519, 356);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(56, 32);
            lblAge.TabIndex = 26;
            lblAge.Text = "Age";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.Location = new Point(202, 131);
            txtBoxFirstName.Margin = new Padding(4, 5, 4, 5);
            txtBoxFirstName.MaxLength = 25;
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.PlaceholderText = "Please Enter First Name";
            txtBoxFirstName.Size = new Size(523, 37);
            txtBoxFirstName.TabIndex = 0;
            txtBoxFirstName.KeyPress += txtBoxFirstName_KeyPress;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.White;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(25, 129);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(129, 32);
            lblFirstName.TabIndex = 24;
            lblFirstName.Text = "First Name";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.White;
            lblHeader.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(202, 19);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(351, 74);
            lblHeader.TabIndex = 23;
            lblHeader.Text = "Add Student";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Add_Edit_Students
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(846, 847);
            Controls.Add(pnlAddEditStudent);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Add_Edit_Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Edit_Students";
            pnlAddEditStudent.ResumeLayout(false);
            pnlAddEditStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAddEditStudent;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDelete;
        private Label lblYear;
        private Label lblDOB;
        private Label lblGender;
        private ComboBox cmbGender;
        private TextBox txtBoxLastName;
        private Label lblLastName;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtClass;
        private Label lblClass;
        private TextBox txtAge;
        private Label lblAge;
        private TextBox txtBoxFirstName;
        private Label lblFirstName;
        private Label lblHeader;
        private DateTimePicker dtPicker;
        private ErrorProvider errorProvider;
        private Label Req1;
        private Label label4;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label lblFirstNameError;
        private Label lblAgeError;
        private Label lblDOBError;
        private Label lblLastNameError;
        private Label lblGenderError;
    }
}