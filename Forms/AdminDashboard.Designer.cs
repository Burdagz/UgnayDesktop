namespace UgnayDesktop.Forms
{
    partial class AdminDashboard
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

        private void InitializeComponent()
        {
            labelTeachers = new Label();
            dgvTeachers = new DataGridView();
            labelStudents = new Label();
            dgvStudents = new DataGridView();
            label1 = new Label();
            txtFullName = new TextBox();
            txtNewUsername = new TextBox();
            label2 = new Label();
            txtNewPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbRole = new ComboBox();
            lblTeacherPhone = new Label();
            txtTeacherPhone = new TextBox();
            lblStudentAge = new Label();
            txtStudentAge = new TextBox();
            lblStudentSex = new Label();
            cmbStudentSex = new ComboBox();
            lblStudentDeviceId = new Label();
            txtStudentDeviceId = new TextBox();
            btnAddUser = new Button();
            btnUpdateUser = new Button();
            btnDeleteUser = new Button();
            lblSelectedUser = new Label();
            btnLogout = new Button();
            btnMqttTest = new Button();
            dgvSensorReadings = new DataGridView();
            lblDecisionStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSensorReadings).BeginInit();
            SuspendLayout();
            // 
            // labelTeachers
            // 
            labelTeachers.AutoSize = true;
            labelTeachers.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTeachers.Location = new Point(7, 31);
            labelTeachers.Margin = new Padding(2, 0, 2, 0);
            labelTeachers.Name = "labelTeachers";
            labelTeachers.Size = new Size(68, 15);
            labelTeachers.TabIndex = 0;
            labelTeachers.Text = "Teachers";
            // 
            // dgvTeachers
            // 
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Location = new Point(7, 48);
            dgvTeachers.Margin = new Padding(2);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.RowHeadersWidth = 72;
            dgvTeachers.Size = new Size(303, 110);
            dgvTeachers.TabIndex = 1;
            dgvTeachers.SelectionChanged += dgvTeachers_SelectionChanged;
            // 
            // labelStudents
            // 
            labelStudents.AutoSize = true;
            labelStudents.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStudents.Location = new Point(324, 31);
            labelStudents.Margin = new Padding(2, 0, 2, 0);
            labelStudents.Name = "labelStudents";
            labelStudents.Size = new Size(65, 15);
            labelStudents.TabIndex = 2;
            labelStudents.Text = "Students";
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(324, 48);
            dgvStudents.Margin = new Padding(2);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 72;
            dgvStudents.Size = new Size(303, 110);
            dgvStudents.TabIndex = 3;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 170);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(7, 186);
            txtFullName.Margin = new Padding(2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(158, 23);
            txtFullName.TabIndex = 5;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewUsername.Location = new Point(7, 224);
            txtNewUsername.Margin = new Padding(2);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(158, 23);
            txtNewUsername.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 209);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(7, 264);
            txtNewPassword.Margin = new Padding(2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(158, 23);
            txtNewPassword.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 249);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 8;
            label3.Text = "Password (optional)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 289);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Role";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            cmbRole.Location = new Point(7, 304);
            cmbRole.Margin = new Padding(2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(158, 23);
            cmbRole.TabIndex = 11;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // lblTeacherPhone
            // 
            lblTeacherPhone.AutoSize = true;
            lblTeacherPhone.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeacherPhone.Location = new Point(4, 326);
            lblTeacherPhone.Margin = new Padding(2, 0, 2, 0);
            lblTeacherPhone.Name = "lblTeacherPhone";
            lblTeacherPhone.Size = new Size(105, 15);
            lblTeacherPhone.TabIndex = 12;
            lblTeacherPhone.Text = "Teacher Phone";
            // 
            // txtTeacherPhone
            // 
            txtTeacherPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTeacherPhone.Location = new Point(7, 342);
            txtTeacherPhone.Margin = new Padding(2);
            txtTeacherPhone.Name = "txtTeacherPhone";
            txtTeacherPhone.Size = new Size(158, 23);
            txtTeacherPhone.TabIndex = 13;
            // 
            // lblStudentAge
            // 
            lblStudentAge.AutoSize = true;
            lblStudentAge.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentAge.Location = new Point(4, 361);
            lblStudentAge.Margin = new Padding(2, 0, 2, 0);
            lblStudentAge.Name = "lblStudentAge";
            lblStudentAge.Size = new Size(79, 14);
            lblStudentAge.TabIndex = 14;
            lblStudentAge.Text = "Student Age";
            // 
            // txtStudentAge
            // 
            txtStudentAge.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentAge.Location = new Point(7, 377);
            txtStudentAge.Margin = new Padding(2);
            txtStudentAge.Name = "txtStudentAge";
            txtStudentAge.Size = new Size(75, 23);
            txtStudentAge.TabIndex = 15;
            // 
            // lblStudentSex
            // 
            lblStudentSex.AutoSize = true;
            lblStudentSex.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentSex.Location = new Point(84, 361);
            lblStudentSex.Margin = new Padding(2, 0, 2, 0);
            lblStudentSex.Name = "lblStudentSex";
            lblStudentSex.Size = new Size(76, 14);
            lblStudentSex.TabIndex = 16;
            lblStudentSex.Text = "Student Sex";
            // 
            // cmbStudentSex
            // 
            cmbStudentSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentSex.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStudentSex.FormattingEnabled = true;
            cmbStudentSex.Items.AddRange(new object[] { "Male", "Female" });
            cmbStudentSex.Location = new Point(87, 377);
            cmbStudentSex.Margin = new Padding(2);
            cmbStudentSex.Name = "cmbStudentSex";
            cmbStudentSex.Size = new Size(78, 23);
            cmbStudentSex.TabIndex = 17;
            // 
            // lblStudentDeviceId
            // 
            lblStudentDeviceId.AutoSize = true;
            lblStudentDeviceId.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentDeviceId.Location = new Point(5, 399);
            lblStudentDeviceId.Margin = new Padding(2, 0, 2, 0);
            lblStudentDeviceId.Name = "lblStudentDeviceId";
            lblStudentDeviceId.Size = new Size(111, 14);
            lblStudentDeviceId.TabIndex = 18;
            lblStudentDeviceId.Text = "Student Device ID";
            // 
            // txtStudentDeviceId
            // 
            txtStudentDeviceId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentDeviceId.Location = new Point(7, 414);
            txtStudentDeviceId.Margin = new Padding(2);
            txtStudentDeviceId.Name = "txtStudentDeviceId";
            txtStudentDeviceId.Size = new Size(158, 23);
            txtStudentDeviceId.TabIndex = 19;
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.Location = new Point(7, 434);
            btnAddUser.Margin = new Padding(2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(76, 20);
            btnAddUser.TabIndex = 20;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateUser.Location = new Point(87, 434);
            btnUpdateUser.Margin = new Padding(2);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(76, 20);
            btnUpdateUser.TabIndex = 21;
            btnUpdateUser.Text = "Update";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.Location = new Point(87, 457);
            btnDeleteUser.Margin = new Padding(2);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(76, 20);
            btnDeleteUser.TabIndex = 22;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // lblSelectedUser
            // 
            lblSelectedUser.AutoSize = true;
            lblSelectedUser.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedUser.Location = new Point(2, 460);
            lblSelectedUser.Margin = new Padding(2, 0, 2, 0);
            lblSelectedUser.Name = "lblSelectedUser";
            lblSelectedUser.Size = new Size(87, 14);
            lblSelectedUser.TabIndex = 23;
            lblSelectedUser.Text = "Selected user";
            lblSelectedUser.Click += lblSelectedUser_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(551, 6);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(76, 20);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMqttTest
            // 
            btnMqttTest.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMqttTest.Location = new Point(198, 484);
            btnMqttTest.Margin = new Padding(2);
            btnMqttTest.Name = "btnMqttTest";
            btnMqttTest.Size = new Size(76, 20);
            btnMqttTest.TabIndex = 25;
            btnMqttTest.Text = "MQTT Test";
            btnMqttTest.UseVisualStyleBackColor = true;
            btnMqttTest.Click += btnMqttTest_Click;
            // 
            // dgvSensorReadings
            // 
            dgvSensorReadings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSensorReadings.Location = new Point(198, 169);
            dgvSensorReadings.Margin = new Padding(2);
            dgvSensorReadings.Name = "dgvSensorReadings";
            dgvSensorReadings.RowHeadersWidth = 72;
            dgvSensorReadings.Size = new Size(430, 298);
            dgvSensorReadings.TabIndex = 26;
            // 
            // lblDecisionStatus
            // 
            lblDecisionStatus.AutoSize = true;
            lblDecisionStatus.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecisionStatus.Location = new Point(198, 468);
            lblDecisionStatus.Margin = new Padding(2, 0, 2, 0);
            lblDecisionStatus.Name = "lblDecisionStatus";
            lblDecisionStatus.Size = new Size(64, 15);
            lblDecisionStatus.TabIndex = 27;
            lblDecisionStatus.Text = "Decision";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 551);
            Controls.Add(lblDecisionStatus);
            Controls.Add(dgvSensorReadings);
            Controls.Add(btnMqttTest);
            Controls.Add(btnLogout);
            Controls.Add(lblSelectedUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnAddUser);
            Controls.Add(txtStudentDeviceId);
            Controls.Add(lblStudentDeviceId);
            Controls.Add(cmbStudentSex);
            Controls.Add(lblStudentSex);
            Controls.Add(txtStudentAge);
            Controls.Add(lblStudentAge);
            Controls.Add(txtTeacherPhone);
            Controls.Add(lblTeacherPhone);
            Controls.Add(cmbRole);
            Controls.Add(label4);
            Controls.Add(txtNewPassword);
            Controls.Add(label3);
            Controls.Add(txtNewUsername);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Controls.Add(dgvStudents);
            Controls.Add(labelStudents);
            Controls.Add(dgvTeachers);
            Controls.Add(labelTeachers);
            Margin = new Padding(2);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSensorReadings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTeachers;
        private DataGridView dgvTeachers;
        private Label labelStudents;
        private DataGridView dgvStudents;
        private Label label1;
        private TextBox txtFullName;
        private TextBox txtNewUsername;
        private Label label2;
        private TextBox txtNewPassword;
        private Label label3;
        private Label label4;
        private ComboBox cmbRole;
        private Label lblTeacherPhone;
        private TextBox txtTeacherPhone;
        private Label lblStudentAge;
        private TextBox txtStudentAge;
        private Label lblStudentSex;
        private ComboBox cmbStudentSex;
        private Label lblStudentDeviceId;
        private TextBox txtStudentDeviceId;
        private Button btnAddUser;
        private Button btnUpdateUser;
        private Button btnDeleteUser;
        private Label lblSelectedUser;
        private Button btnLogout;
        private Button btnMqttTest;
        private DataGridView dgvSensorReadings;
        private Label lblDecisionStatus;
    }
}
