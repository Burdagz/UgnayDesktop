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
            dgvSensorReadings.Location = new Point(7, 325);
            dgvSensorReadings.Margin = new Padding(2);
            dgvSensorReadings.Name = "dgvSensorReadings";
            dgvSensorReadings.RowHeadersWidth = 72;
            dgvSensorReadings.Size = new Size(677, 173);
            dgvSensorReadings.TabIndex = 0;
            // 
            // lblDecisionStatus
            // 
            lblDecisionStatus.AutoSize = true;
            lblDecisionStatus.Font = new Font("Arial Rounded MT Bold", 9F);
            lblDecisionStatus.Location = new Point(7, 303);
            lblDecisionStatus.Margin = new Padding(2, 0, 2, 0);
            lblDecisionStatus.Name = "lblDecisionStatus";
            lblDecisionStatus.Size = new Size(57, 14);
            lblDecisionStatus.TabIndex = 1;
            lblDecisionStatus.Text = "Decision";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(607, 31);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(76, 20);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblProfileHeader
            // 
            lblProfileHeader.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfileHeader.Location = new Point(7, 7);
            lblProfileHeader.Margin = new Padding(2, 0, 2, 0);
            lblProfileHeader.Name = "lblProfileHeader";
            lblProfileHeader.Size = new Size(191, 40);
            lblProfileHeader.TabIndex = 3;
            lblProfileHeader.Text = "My Profile";
            // 
            // labelTeacherName
            // 
            labelTeacherName.AutoSize = true;
            labelTeacherName.Font = new Font("Arial Rounded MT Bold", 9F);
            labelTeacherName.Location = new Point(7, 49);
            labelTeacherName.Margin = new Padding(2, 0, 2, 0);
            labelTeacherName.Name = "labelTeacherName";
            labelTeacherName.Size = new Size(64, 14);
            labelTeacherName.TabIndex = 4;
            labelTeacherName.Text = "Full Name";
            // 
            // txtTeacherFullName
            // 
            txtTeacherFullName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTeacherFullName.Location = new Point(7, 66);
            txtTeacherFullName.Margin = new Padding(2);
            txtTeacherFullName.Name = "txtTeacherFullName";
            txtTeacherFullName.Size = new Size(154, 23);
            txtTeacherFullName.TabIndex = 5;
            // 
            // labelTeacherPhoneEdit
            // 
            labelTeacherPhoneEdit.AutoSize = true;
            labelTeacherPhoneEdit.Font = new Font("Arial Rounded MT Bold", 9F);
            labelTeacherPhoneEdit.Location = new Point(163, 49);
            labelTeacherPhoneEdit.Margin = new Padding(2, 0, 2, 0);
            labelTeacherPhoneEdit.Name = "labelTeacherPhoneEdit";
            labelTeacherPhoneEdit.Size = new Size(94, 14);
            labelTeacherPhoneEdit.TabIndex = 6;
            labelTeacherPhoneEdit.Text = "Teacher Phone";
            // 
            // lblTeacherPhonePrefix
            // 
            lblTeacherPhonePrefix.AutoSize = true;
            lblTeacherPhonePrefix.Font = new Font("Arial Rounded MT Bold", 9F);
            lblTeacherPhonePrefix.Location = new Point(163, 67);
            lblTeacherPhonePrefix.Margin = new Padding(2, 0, 2, 0);
            lblTeacherPhonePrefix.Name = "lblTeacherPhonePrefix";
            lblTeacherPhonePrefix.Size = new Size(35, 14);
            lblTeacherPhonePrefix.TabIndex = 7;
            lblTeacherPhonePrefix.Text = "+639";
            // 
            // txtTeacherPhoneSuffix
            // 
            txtTeacherPhoneSuffix.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTeacherPhoneSuffix.Location = new Point(195, 66);
            txtTeacherPhoneSuffix.Margin = new Padding(2);
            txtTeacherPhoneSuffix.MaxLength = 9;
            txtTeacherPhoneSuffix.Name = "txtTeacherPhoneSuffix";
            txtTeacherPhoneSuffix.Size = new Size(118, 23);
            txtTeacherPhoneSuffix.TabIndex = 8;
            txtTeacherPhoneSuffix.KeyPress += txtTeacherPhoneSuffix_KeyPress;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveProfile.Location = new Point(320, 65);
            btnSaveProfile.Margin = new Padding(2);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(91, 20);
            btnSaveProfile.TabIndex = 9;
            btnSaveProfile.Text = "Save Profile";
            btnSaveProfile.UseVisualStyleBackColor = true;
            btnSaveProfile.Click += btnSaveProfile_Click;
            // 
            // lblTeacherPhone
            // 
            lblTeacherPhone.AutoSize = true;
            lblTeacherPhone.Font = new Font("Arial Rounded MT Bold", 9F);
            lblTeacherPhone.Location = new Point(7, 90);
            lblTeacherPhone.Margin = new Padding(2, 0, 2, 0);
            lblTeacherPhone.Name = "lblTeacherPhone";
            lblTeacherPhone.Size = new Size(98, 14);
            lblTeacherPhone.TabIndex = 10;
            lblTeacherPhone.Text = "Teacher Phone:";
            // 
            // btnTwilioConfigCheck
            // 
            btnTwilioConfigCheck.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTwilioConfigCheck.Location = new Point(368, 31);
            btnTwilioConfigCheck.Margin = new Padding(2);
            btnTwilioConfigCheck.Name = "btnTwilioConfigCheck";
            btnTwilioConfigCheck.Size = new Size(76, 20);
            btnTwilioConfigCheck.TabIndex = 11;
            btnTwilioConfigCheck.Text = "Config Check";
            btnTwilioConfigCheck.UseVisualStyleBackColor = true;
            btnTwilioConfigCheck.Click += btnTwilioConfigCheck_Click;
            // 
            // btnTwilioLink
            // 
            btnTwilioLink.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTwilioLink.Location = new Point(447, 31);
            btnTwilioLink.Margin = new Padding(2);
            btnTwilioLink.Name = "btnTwilioLink";
            btnTwilioLink.Size = new Size(76, 20);
            btnTwilioLink.TabIndex = 12;
            btnTwilioLink.Text = "Twilio Link";
            btnTwilioLink.UseVisualStyleBackColor = true;
            btnTwilioLink.Click += btnTwilioLink_Click;
            // 
            // btnTwilioTest
            // 
            btnTwilioTest.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTwilioTest.Location = new Point(527, 31);
            btnTwilioTest.Margin = new Padding(2);
            btnTwilioTest.Name = "btnTwilioTest";
            btnTwilioTest.Size = new Size(76, 20);
            btnTwilioTest.TabIndex = 13;
            btnTwilioTest.Text = "Twilio Test";
            btnTwilioTest.UseVisualStyleBackColor = true;
            btnTwilioTest.Click += btnTwilioTest_Click;
            // 
            // lblStudentHeader
            // 
            lblStudentHeader.AutoSize = true;
            lblStudentHeader.Font = new Font("Arial Rounded MT Bold", 9F);
            lblStudentHeader.Location = new Point(7, 112);
            lblStudentHeader.Margin = new Padding(2, 0, 2, 0);
            lblStudentHeader.Name = "lblStudentHeader";
            lblStudentHeader.Size = new Size(149, 14);
            lblStudentHeader.TabIndex = 14;
            lblStudentHeader.Text = "Add Student Information";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Arial Rounded MT Bold", 9F);
            labelFullName.Location = new Point(7, 132);
            labelFullName.Margin = new Padding(2, 0, 2, 0);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(64, 14);
            labelFullName.TabIndex = 15;
            labelFullName.Text = "Full Name";
            // 
            // txtStudentFullName
            // 
            txtStudentFullName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentFullName.Location = new Point(7, 148);
            txtStudentFullName.Margin = new Padding(2);
            txtStudentFullName.Name = "txtStudentFullName";
            txtStudentFullName.Size = new Size(191, 23);
            txtStudentFullName.TabIndex = 16;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Arial Rounded MT Bold", 9F);
            labelAge.Location = new Point(200, 132);
            labelAge.Margin = new Padding(2, 0, 2, 0);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(31, 14);
            labelAge.TabIndex = 17;
            labelAge.Text = "Age";
            labelAge.Click += labelAge_Click;
            // 
            // txtStudentAge
            // 
            txtStudentAge.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentAge.Location = new Point(200, 148);
            txtStudentAge.Margin = new Padding(2);
            txtStudentAge.Name = "txtStudentAge";
            txtStudentAge.Size = new Size(66, 23);
            txtStudentAge.TabIndex = 18;
            txtStudentAge.TextAlign = HorizontalAlignment.Center;
            txtStudentAge.TextChanged += txtStudentAge_TextChanged;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Font = new Font("Arial Rounded MT Bold", 9F);
            labelSex.Location = new Point(267, 132);
            labelSex.Margin = new Padding(2, 0, 2, 0);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(28, 14);
            labelSex.TabIndex = 19;
            labelSex.Text = "Sex";
            // 
            // cmbStudentSex
            // 
            cmbStudentSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentSex.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStudentSex.FormattingEnabled = true;
            cmbStudentSex.Items.AddRange(new object[] { "Male", "Female" });
            cmbStudentSex.Location = new Point(267, 146);
            cmbStudentSex.Margin = new Padding(2);
            cmbStudentSex.Name = "cmbStudentSex";
            cmbStudentSex.Size = new Size(85, 23);
            cmbStudentSex.TabIndex = 20;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(354, 147);
            btnAddStudent.Margin = new Padding(2);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(90, 20);
            btnAddStudent.TabIndex = 21;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(7, 174);
            dgvStudents.Margin = new Padding(2);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 72;
            dgvStudents.Size = new Size(677, 94);
            dgvStudents.TabIndex = 22;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
            // 
            // lblConnectionStatus
            // 
            lblConnectionStatus.AutoSize = true;
            lblConnectionStatus.Font = new Font("Arial Rounded MT Bold", 9F);
            lblConnectionStatus.Location = new Point(7, 289);
            lblConnectionStatus.Margin = new Padding(2, 0, 2, 0);
            lblConnectionStatus.Name = "lblConnectionStatus";
            lblConnectionStatus.Size = new Size(76, 14);
            lblConnectionStatus.TabIndex = 23;
            lblConnectionStatus.Text = "Connection:";
            // 
            // lblSelectedStudent
            // 
            lblSelectedStudent.AutoSize = true;
            lblSelectedStudent.Font = new Font("Arial Rounded MT Bold", 9F);
            lblSelectedStudent.Location = new Point(7, 273);
            lblSelectedStudent.Margin = new Padding(2, 0, 2, 0);
            lblSelectedStudent.Name = "lblSelectedStudent";
            lblSelectedStudent.Size = new Size(110, 14);
            lblSelectedStudent.TabIndex = 24;
            lblSelectedStudent.Text = "Selected Student:";
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 620);
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
            Margin = new Padding(2);
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
