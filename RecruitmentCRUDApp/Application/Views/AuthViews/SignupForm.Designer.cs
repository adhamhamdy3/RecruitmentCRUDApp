namespace RecruitmentApplication.Views.Auth
{
    partial class SignupForm
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
            this.labelCreateAccMsg = new Label();
            this.txtFullName = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.txtConfirmPassword = new TextBox();
            this.txtPhoneNumber = new TextBox();
            this.labelFullName = new Label();
            this.labelPassword = new Label();
            this.labelEmail = new Label();
            this.labelPhoneNumber = new Label();
            this.labelBirthDate = new Label();
            this.labelConfPassword = new Label();
            this.birthDate = new DateTimePicker();
            this.btnSignup = new Button();
            this.radioBtnJobseeker = new RadioButton();
            this.radioBtnEmployer = new RadioButton();
            this.labelLoginMsg = new Label();
            this.linkLogin = new LinkLabel();
            this.gboxUserType = new GroupBox();
            this.gboxUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCreateAccMsg
            // 
            this.labelCreateAccMsg.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.labelCreateAccMsg.AutoSize = true;
            this.labelCreateAccMsg.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point,  0);
            this.labelCreateAccMsg.Location = new Point(74, 9);
            this.labelCreateAccMsg.Name = "labelCreateAccMsg";
            this.labelCreateAccMsg.Size = new Size(210, 32);
            this.labelCreateAccMsg.TabIndex = 0;
            this.labelCreateAccMsg.Text = "Create an Account";
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = AnchorStyles.None;
            this.txtFullName.Location = new Point(45, 66);
            this.txtFullName.Margin = new Padding(3, 2, 3, 2);
            this.txtFullName.MaxLength = 100;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderText = "Enter your full name";
            this.txtFullName.Size = new Size(261, 23);
            this.txtFullName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = AnchorStyles.None;
            this.txtEmail.Location = new Point(45, 125);
            this.txtEmail.Margin = new Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Enter your email address";
            this.txtEmail.Size = new Size(261, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = AnchorStyles.None;
            this.txtPassword.Location = new Point(45, 184);
            this.txtPassword.Margin = new Padding(3, 2, 3, 2);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Enter your password";
            this.txtPassword.Size = new Size(261, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = AnchorStyles.None;
            this.txtConfirmPassword.Location = new Point(45, 244);
            this.txtConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            this.txtConfirmPassword.MaxLength = 255;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.PlaceholderText = "Write your password again";
            this.txtConfirmPassword.Size = new Size(261, 23);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = AnchorStyles.None;
            this.txtPhoneNumber.Location = new Point(45, 303);
            this.txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            this.txtPhoneNumber.MaxLength = 20;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceholderText = "Enter your phone number";
            this.txtPhoneNumber.Size = new Size(261, 23);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new Point(45, 49);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new Size(61, 15);
            this.labelFullName.TabIndex = 7;
            this.labelFullName.Text = "Full Name";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new Point(42, 167);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new Size(57, 15);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new Point(45, 108);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new Size(36, 15);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new Point(42, 286);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new Size(88, 15);
            this.labelPhoneNumber.TabIndex = 10;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new Point(42, 345);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new Size(59, 15);
            this.labelBirthDate.TabIndex = 11;
            this.labelBirthDate.Text = "Birth Date";
            // 
            // labelConfPassword
            // 
            this.labelConfPassword.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.labelConfPassword.AutoSize = true;
            this.labelConfPassword.Location = new Point(42, 226);
            this.labelConfPassword.Name = "labelConfPassword";
            this.labelConfPassword.Size = new Size(131, 15);
            this.labelConfPassword.TabIndex = 12;
            this.labelConfPassword.Text = "Confirm your password";
            // 
            // birthDate
            // 
            this.birthDate.Anchor = AnchorStyles.None;
            this.birthDate.Location = new Point(45, 362);
            this.birthDate.Margin = new Padding(3, 2, 3, 2);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new Size(261, 23);
            this.birthDate.TabIndex = 6;
            // 
            // btnSignup
            // 
            this.btnSignup.Anchor = AnchorStyles.None;
            this.btnSignup.Location = new Point(134, 451);
            this.btnSignup.Margin = new Padding(3, 2, 3, 2);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new Size(82, 31);
            this.btnSignup.TabIndex = 9;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += this.btnSignup_Click;
            // 
            // radioBtnJobseeker
            // 
            this.radioBtnJobseeker.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.radioBtnJobseeker.AutoSize = true;
            this.radioBtnJobseeker.Checked = true;
            this.radioBtnJobseeker.Location = new Point(12, 16);
            this.radioBtnJobseeker.Margin = new Padding(3, 2, 3, 2);
            this.radioBtnJobseeker.Name = "radioBtnJobseeker";
            this.radioBtnJobseeker.Size = new Size(80, 19);
            this.radioBtnJobseeker.TabIndex = 7;
            this.radioBtnJobseeker.TabStop = true;
            this.radioBtnJobseeker.Text = "Job Seeker";
            this.radioBtnJobseeker.UseVisualStyleBackColor = true;
            // 
            // radioBtnEmployer
            // 
            this.radioBtnEmployer.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.radioBtnEmployer.AutoSize = true;
            this.radioBtnEmployer.Location = new Point(174, 15);
            this.radioBtnEmployer.Margin = new Padding(3, 2, 3, 2);
            this.radioBtnEmployer.Name = "radioBtnEmployer";
            this.radioBtnEmployer.Size = new Size(75, 19);
            this.radioBtnEmployer.TabIndex = 8;
            this.radioBtnEmployer.Text = "Employer";
            this.radioBtnEmployer.UseVisualStyleBackColor = true;
            // 
            // labelLoginMsg
            // 
            this.labelLoginMsg.Anchor = AnchorStyles.Bottom;
            this.labelLoginMsg.AutoSize = true;
            this.labelLoginMsg.Location = new Point(80, 494);
            this.labelLoginMsg.Name = "labelLoginMsg";
            this.labelLoginMsg.Size = new Size(142, 15);
            this.labelLoginMsg.TabIndex = 17;
            this.labelLoginMsg.Text = "Already have an account?";
            // 
            // linkLogin
            // 
            this.linkLogin.Anchor = AnchorStyles.Bottom;
            this.linkLogin.AutoSize = true;
            this.linkLogin.Location = new Point(228, 494);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new Size(40, 15);
            this.linkLogin.TabIndex = 10;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Log in";
            this.linkLogin.LinkClicked += this.linkLogin_LinkClicked;
            // 
            // gboxUserType
            // 
            this.gboxUserType.Controls.Add(this.radioBtnEmployer);
            this.gboxUserType.Controls.Add(this.radioBtnJobseeker);
            this.gboxUserType.Location = new Point(45, 404);
            this.gboxUserType.Name = "gboxUserType";
            this.gboxUserType.Size = new Size(264, 41);
            this.gboxUserType.TabIndex = 18;
            this.gboxUserType.TabStop = false;
            this.gboxUserType.Text = "User Type";
            // 
            // frmSignup
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(355, 530);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.labelLoginMsg);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.labelConfPassword);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelCreateAccMsg);
            this.Controls.Add(this.gboxUserType);
            this.Margin = new Padding(3, 2, 3, 2);
            this.Name = "frmSignup";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sign up";
            this.FormClosing += this.frmSignup_FormClosing;
            this.gboxUserType.ResumeLayout(false);
            this.gboxUserType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelCreateAccMsg;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtPhoneNumber;
        private Label labelFullName;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelPhoneNumber;
        private Label labelBirthDate;
        private Label labelConfPassword;
        private DateTimePicker birthDate;
        private Button btnSignup;
        private RadioButton radioBtnJobseeker;
        private RadioButton radioBtnEmployer;
        private Label labelLoginMsg;
        private LinkLabel linkLogin;
        private GroupBox gboxUserType;
    }
}