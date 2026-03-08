namespace UgnayDesktop.Forms;

partial class LoginForm
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
        label1 = new Label();
        txtUsername = new TextBox();
        label2 = new Label();
        txtPassword = new TextBox();
        btnLogin = new UgnayDesktop.Controls.RoundedButton();
        label3 = new Label();
        pictureBoxLogo = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(551, 120);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(74, 15);
        label1.TabIndex = 0;
        label1.Text = "Username";
        label1.Click += label1_Click;
        // 
        // txtUsername
        // 
        txtUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        txtUsername.Location = new Point(512, 136);
        txtUsername.Margin = new Padding(2);
        txtUsername.Multiline = true;
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(153, 24);
        txtUsername.TabIndex = 1;
        txtUsername.Tag = "";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(553, 180);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(71, 15);
        label2.TabIndex = 2;
        label2.Text = "Password";
        label2.Click += label2_Click;
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        txtPassword.Location = new Point(512, 196);
        txtPassword.Margin = new Padding(2);
        txtPassword.Multiline = true;
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(153, 24);
        txtPassword.TabIndex = 3;
        txtPassword.UseSystemPasswordChar = true;
        txtPassword.TextChanged += txtPassword_TextChanged;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(217, 217, 217);
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogin.ForeColor = Color.Black;
        btnLogin.Location = new Point(548, 232);
        btnLogin.Margin = new Padding(2);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(76, 20);
        btnLogin.TabIndex = 4;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // label3
        // 
        label3.Font = new Font("Arial Rounded MT Bold", 35F, FontStyle.Bold);
        label3.Location = new Point(489, 46);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(204, 60);
        label3.TabIndex = 5;
        label3.Text = "UGNAY";
        label3.Click += label3_Click;
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.BackColor = Color.Transparent;
        pictureBoxLogo.Location = new Point(50, 46);
        pictureBoxLogo.Margin = new Padding(2);
        pictureBoxLogo.Name = "pictureBoxLogo";
        pictureBoxLogo.Size = new Size(397, 270);
        pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxLogo.TabIndex = 6;
        pictureBoxLogo.TabStop = false;
        // 
        // LoginForm
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(725, 350);
        Controls.Add(pictureBoxLogo);
        Controls.Add(label3);
        Controls.Add(btnLogin);
        Controls.Add(txtPassword);
        Controls.Add(label2);
        Controls.Add(txtUsername);
        Controls.Add(label1);
        Margin = new Padding(2);
        Name = "LoginForm";
        Text = "UGNAY Login";
        Load += LoginForm_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtUsername;
    private Label label2;
    private TextBox txtPassword;
    private UgnayDesktop.Controls.RoundedButton btnLogin;
    private Label label3;
    private PictureBox pictureBoxLogo;
}

