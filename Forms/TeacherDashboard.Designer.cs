namespace UgnayDesktop.Forms
{
    partial class TeacherDashboard
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
            dgvSensorReadings = new DataGridView();
            lblDecisionStatus = new Label();
            btnLogout = new Button();
            lblProfileHeader = new Label();
            labelTeacherName = new Label();
            txtTeacherFullName = new TextBox();
            labelTeacherPhoneEdit = new Label();
            lblTeacherPhonePrefix = new Label();
            txtTeacherPhoneSuffix = new TextBox();
            btnSaveProfile = new Button();
            lblTeacherPhone = new Label();
            btnTwilioConfigCheck = new Button();
            btnTwilioLink = new Button();
            btnTwilioTest = new Button();
            lblStudentHeader = new Label();
            labelFullName = new Label();
            txtStudentFullName = new TextBox();
            labelAge = new Label();
            txtStudentAge = new TextBox();
            labelSex = new Label();
            cmbStudentSex = new ComboBox();
            btnAddStudent = new Button();
            dgvStudents = new DataGridView();
            lblConnectionStatus = new Label();
            lblSelectedStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSensorReadings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvSensorReadings
            // 
            dgvSensorReadings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSensorReadings.Location = new Point(12, 561);
            dgvSensorReadings.Name = "dgvSensorReadings";
            dgvSensorReadings.RowHeadersWidth = 72;
            dgvSensorReadings.Size = new Size(1160, 346);
            dgvSensorReadings.TabIndex = 0;
            // 
            // lblDecisionStatus
            // 
            lblDecisionStatus.AutoSize = true;
            lblDecisionStatus.Location = new Point(12, 525);
            lblDecisionStatus.Name = "lblDecisionStatus";
            lblDecisionStatus.Size = new Size(92, 30);
            lblDecisionStatus.TabIndex = 1;
            lblDecisionStatus.Text = "Decision";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1041, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(131, 40);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblProfileHeader
            // 
            lblProfileHeader.AutoSize = true;
            lblProfileHeader.Location = new Point(12, 12);
            lblProfileHeader.Name = "lblProfileHeader";
            lblProfileHeader.Size = new Size(105, 30);
            lblProfileHeader.TabIndex = 3;
            lblProfileHeader.Text = "My Profile";
            // 
            // labelTeacherName
            // 
            labelTeacherName.AutoSize = true;
            labelTeacherName.Location = new Point(12, 49);
            labelTeacherName.Name = "labelTeacherName";
            labelTeacherName.Size = new Size(107, 30);
            labelTeacherName.TabIndex = 4;
            labelTeacherName.Text = "Full Name";
            // 
            // txtTeacherFullName
            // 
            txtTeacherFullName.Location = new Point(12, 82);
            txtTeacherFullName.Name = "txtTeacherFullName";
            txtTeacherFullName.Size = new Size(262, 35);
            txtTeacherFullName.TabIndex = 5;
            // 
            // labelTeacherPhoneEdit
            // 
            labelTeacherPhoneEdit.AutoSize = true;
            labelTeacherPhoneEdit.Location = new Point(280, 49);
            labelTeacherPhoneEdit.Name = "labelTeacherPhoneEdit";
            labelTeacherPhoneEdit.Size = new Size(156, 30);
            labelTeacherPhoneEdit.TabIndex = 6;
            labelTeacherPhoneEdit.Text = "Teacher Phone";
            // 
            // lblTeacherPhonePrefix
            // 
            lblTeacherPhonePrefix.AutoSize = true;
            lblTeacherPhonePrefix.Location = new Point(280, 85);
            lblTeacherPhonePrefix.Name = "lblTeacherPhonePrefix";
            lblTeacherPhonePrefix.Size = new Size(58, 30);
            lblTeacherPhonePrefix.TabIndex = 7;
            lblTeacherPhonePrefix.Text = "+639";
            // 
            // txtTeacherPhoneSuffix
            // 
            txtTeacherPhoneSuffix.Location = new Point(342, 82);
            txtTeacherPhoneSuffix.MaxLength = 9;
            txtTeacherPhoneSuffix.Name = "txtTeacherPhoneSuffix";
            txtTeacherPhoneSuffix.Size = new Size(200, 35);
            txtTeacherPhoneSuffix.TabIndex = 8;
            txtTeacherPhoneSuffix.KeyPress += txtTeacherPhoneSuffix_KeyPress;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.Location = new Point(548, 80);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(156, 40);
            btnSaveProfile.TabIndex = 9;
            btnSaveProfile.Text = "Save Profile";
            btnSaveProfile.UseVisualStyleBackColor = true;
            btnSaveProfile.Click += btnSaveProfile_Click;
            // 
            // lblTeacherPhone
            // 
            lblTeacherPhone.AutoSize = true;
            lblTeacherPhone.Location = new Point(12, 120);
            lblTeacherPhone.Name = "lblTeacherPhone";
            lblTeacherPhone.Size = new Size(156, 30);
            lblTeacherPhone.TabIndex = 10;
            lblTeacherPhone.Text = "Teacher Phone:";
            // 
            // btnTwilioConfigCheck
            // 
            btnTwilioConfigCheck.Location = new Point(630, 12);
            btnTwilioConfigCheck.Name = "btnTwilioConfigCheck";
            btnTwilioConfigCheck.Size = new Size(131, 40);
            btnTwilioConfigCheck.TabIndex = 11;
            btnTwilioConfigCheck.Text = "Config Check";
            btnTwilioConfigCheck.UseVisualStyleBackColor = true;
            btnTwilioConfigCheck.Click += btnTwilioConfigCheck_Click;
            // 
            // btnTwilioLink
            // 
            btnTwilioLink.Location = new Point(767, 12);
            btnTwilioLink.Name = "btnTwilioLink";
            btnTwilioLink.Size = new Size(131, 40);
            btnTwilioLink.TabIndex = 12;
            btnTwilioLink.Text = "Twilio Link";
            btnTwilioLink.UseVisualStyleBackColor = true;
            btnTwilioLink.Click += btnTwilioLink_Click;
            // 
            // btnTwilioTest
            // 
            btnTwilioTest.Location = new Point(904, 12);
            btnTwilioTest.Name = "btnTwilioTest";
            btnTwilioTest.Size = new Size(131, 40);
            btnTwilioTest.TabIndex = 13;
            btnTwilioTest.Text = "Twilio Test";
            btnTwilioTest.UseVisualStyleBackColor = true;
            btnTwilioTest.Click += btnTwilioTest_Click;
            // 
            // lblStudentHeader
            // 
            lblStudentHeader.AutoSize = true;
            lblStudentHeader.Location = new Point(12, 164);
            lblStudentHeader.Name = "lblStudentHeader";
            lblStudentHeader.Size = new Size(243, 30);
            lblStudentHeader.TabIndex = 14;
            lblStudentHeader.Text = "Add Student Information";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(12, 204);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(107, 30);
            labelFullName.TabIndex = 15;
            labelFullName.Text = "Full Name";
            // 
            // txtStudentFullName
            // 
            txtStudentFullName.Location = new Point(12, 237);
            txtStudentFullName.Name = "txtStudentFullName";
            txtStudentFullName.Size = new Size(324, 35);
            txtStudentFullName.TabIndex = 16;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(342, 204);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(50, 30);
            labelAge.TabIndex = 17;
            labelAge.Text = "Age";
            // 
            // txtStudentAge
            // 
            txtStudentAge.Location = new Point(342, 237);
            txtStudentAge.Name = "txtStudentAge";
            txtStudentAge.Size = new Size(110, 35);
            txtStudentAge.TabIndex = 18;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(458, 204);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(45, 30);
            labelSex.TabIndex = 19;
            labelSex.Text = "Sex";
            // 
            // cmbStudentSex
            // 
            cmbStudentSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentSex.FormattingEnabled = true;
            cmbStudentSex.Items.AddRange(new object[] { "Male", "Female" });
            cmbStudentSex.Location = new Point(458, 236);
            cmbStudentSex.Name = "cmbStudentSex";
            cmbStudentSex.Size = new Size(143, 38);
            cmbStudentSex.TabIndex = 20;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(607, 234);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(154, 40);
            btnAddStudent.TabIndex = 21;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 288);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 72;
            dgvStudents.Size = new Size(1160, 189);
            dgvStudents.TabIndex = 22;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
            // 
            // lblConnectionStatus
            // 
            lblConnectionStatus.AutoSize = true;
            lblConnectionStatus.Location = new Point(12, 495);
            lblConnectionStatus.Name = "lblConnectionStatus";
            lblConnectionStatus.Size = new Size(124, 30);
            lblConnectionStatus.TabIndex = 23;
            lblConnectionStatus.Text = "Connection:";
            // 
            // lblSelectedStudent
            // 
            lblSelectedStudent.AutoSize = true;
            lblSelectedStudent.Location = new Point(12, 465);
            lblSelectedStudent.Name = "lblSelectedStudent";
            lblSelectedStudent.Size = new Size(173, 30);
            lblSelectedStudent.TabIndex = 24;
            lblSelectedStudent.Text = "Selected Student:";
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 920);
            Controls.Add(lblSelectedStudent);
            Controls.Add(lblConnectionStatus);
            Controls.Add(dgvStudents);
            Controls.Add(btnAddStudent);
            Controls.Add(cmbStudentSex);
            Controls.Add(labelSex);
            Controls.Add(txtStudentAge);
            Controls.Add(labelAge);
            Controls.Add(txtStudentFullName);
            Controls.Add(labelFullName);
            Controls.Add(lblStudentHeader);
            Controls.Add(btnTwilioTest);
            Controls.Add(btnTwilioLink);
            Controls.Add(btnTwilioConfigCheck);
            Controls.Add(lblTeacherPhone);
            Controls.Add(btnSaveProfile);
            Controls.Add(txtTeacherPhoneSuffix);
            Controls.Add(lblTeacherPhonePrefix);
            Controls.Add(labelTeacherPhoneEdit);
            Controls.Add(txtTeacherFullName);
            Controls.Add(labelTeacherName);
            Controls.Add(lblProfileHeader);
            Controls.Add(btnLogout);
            Controls.Add(lblDecisionStatus);
            Controls.Add(dgvSensorReadings);
            Name = "TeacherDashboard";
            Text = "Teacher Dashboard";
            ((System.ComponentModel.ISupportInitialize)dgvSensorReadings).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSensorReadings;
        private Label lblDecisionStatus;
        private Button btnLogout;
        private Label lblProfileHeader;
        private Label labelTeacherName;
        private TextBox txtTeacherFullName;
        private Label labelTeacherPhoneEdit;
        private Label lblTeacherPhonePrefix;
        private TextBox txtTeacherPhoneSuffix;
        private Button btnSaveProfile;
        private Label lblTeacherPhone;
        private Button btnTwilioConfigCheck;
        private Button btnTwilioLink;
        private Button btnTwilioTest;
        private Label lblStudentHeader;
        private Label labelFullName;
        private TextBox txtStudentFullName;
        private Label labelAge;
        private TextBox txtStudentAge;
        private Label labelSex;
        private ComboBox cmbStudentSex;
        private Button btnAddStudent;
        private DataGridView dgvStudents;
        private Label lblConnectionStatus;
        private Label lblSelectedStudent;
    }
}
