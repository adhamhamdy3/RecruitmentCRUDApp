namespace RecruitmentApplication.Views.Profiles
{
    partial class JobSeekerProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserName = new Label();
            this.btnSaveChangesSkills = new Button();
            this.panelHeader = new Panel();
            this.layout = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.tabSkillsAndInterests = new TabPage();
            this.labelSkillAndInterests = new Label();
            this.labelSkills = new Label();
            this.labelInterests = new Label();
            this.textBoxSkills = new TextBox();
            this.textBoxInterests = new TextBox();
            this.tabPersonalInfo = new TabPage();
            this.labelPersonalInfo = new Label();
            this.labelFullName = new Label();
            this.labelEmail = new Label();
            this.labelPassword = new Label();
            this.labelPhone = new Label();
            this.labelBirthDate = new Label();
            this.labelSignupDate = new Label();
            this.txtFullName = new TextBox();
            this.txtPassword = new TextBox();
            this.txtPhoneNumber = new TextBox();
            this.textBox4 = new TextBox();
            this.txtEmail = new TextBox();
            this.birthDatePicker = new DateTimePicker();
            this.tabControlProfileInfo = new TabControl();
            this.panelHeader.SuspendLayout();
            this.layout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSkillsAndInterests.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tabControlProfileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelUserName.Location = new Point(119, 22);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new Size(322, 37);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Adham Hamdy's Profile";
            // 
            // btnSaveChangesSkills
            // 
            this.btnSaveChangesSkills.DialogResult = DialogResult.Abort;
            this.btnSaveChangesSkills.Location = new Point(481, 3);
            this.btnSaveChangesSkills.Name = "btnSaveChangesSkills";
            this.btnSaveChangesSkills.Size = new Size(112, 34);
            this.btnSaveChangesSkills.TabIndex = 23;
            this.btnSaveChangesSkills.Text = "Save Changes";
            this.btnSaveChangesSkills.UseVisualStyleBackColor = true;
            this.btnSaveChangesSkills.Click += this.btnSaveChanges_Click;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.GhostWhite;
            this.panelHeader.BorderStyle = BorderStyle.Fixed3D;
            this.panelHeader.Controls.Add(this.labelUserName);
            this.panelHeader.Dock = DockStyle.Fill;
            this.panelHeader.Location = new Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(596, 84);
            this.panelHeader.TabIndex = 20;
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.layout.Controls.Add(this.tabControlProfileInfo, 0, 1);
            this.layout.Controls.Add(this.panelHeader, 0, 0);
            this.layout.Controls.Add(this.panel1, 0, 2);
            this.layout.Dock = DockStyle.Fill;
            this.layout.Location = new Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            this.layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            this.layout.Size = new Size(602, 610);
            this.layout.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveChangesSkills);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 568);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(596, 39);
            this.panel1.TabIndex = 22;
            // 
            // tabSkillsAndInterests
            // 
            this.tabSkillsAndInterests.AutoScroll = true;
            this.tabSkillsAndInterests.Controls.Add(this.textBoxInterests);
            this.tabSkillsAndInterests.Controls.Add(this.textBoxSkills);
            this.tabSkillsAndInterests.Controls.Add(this.labelInterests);
            this.tabSkillsAndInterests.Controls.Add(this.labelSkills);
            this.tabSkillsAndInterests.Controls.Add(this.labelSkillAndInterests);
            this.tabSkillsAndInterests.Location = new Point(4, 24);
            this.tabSkillsAndInterests.Name = "tabSkillsAndInterests";
            this.tabSkillsAndInterests.Padding = new Padding(3);
            this.tabSkillsAndInterests.Size = new Size(588, 441);
            this.tabSkillsAndInterests.TabIndex = 1;
            this.tabSkillsAndInterests.Text = "Skills and Interests";
            this.tabSkillsAndInterests.UseVisualStyleBackColor = true;
            // 
            // labelSkillAndInterests
            // 
            this.labelSkillAndInterests.AutoSize = true;
            this.labelSkillAndInterests.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelSkillAndInterests.Location = new Point(27, 27);
            this.labelSkillAndInterests.Name = "labelSkillAndInterests";
            this.labelSkillAndInterests.Size = new Size(228, 32);
            this.labelSkillAndInterests.TabIndex = 1;
            this.labelSkillAndInterests.Text = "Skills and Interests";
            // 
            // labelSkills
            // 
            this.labelSkills.AutoSize = true;
            this.labelSkills.Location = new Point(40, 65);
            this.labelSkills.Name = "labelSkills";
            this.labelSkills.Size = new Size(33, 15);
            this.labelSkills.TabIndex = 4;
            this.labelSkills.Text = "Skills";
            // 
            // labelInterests
            // 
            this.labelInterests.AutoSize = true;
            this.labelInterests.Location = new Point(40, 210);
            this.labelInterests.Name = "labelInterests";
            this.labelInterests.Size = new Size(51, 15);
            this.labelInterests.TabIndex = 5;
            this.labelInterests.Text = "Interests";
            // 
            // textBoxSkills
            // 
            this.textBoxSkills.Location = new Point(102, 65);
            this.textBoxSkills.Multiline = true;
            this.textBoxSkills.Name = "textBoxSkills";
            this.textBoxSkills.Size = new Size(454, 122);
            this.textBoxSkills.TabIndex = 6;
            this.textBoxSkills.TextChanged += this.textBox1_TextChanged;
            // 
            // textBoxInterests
            // 
            this.textBoxInterests.Location = new Point(102, 207);
            this.textBoxInterests.Multiline = true;
            this.textBoxInterests.Name = "textBoxInterests";
            this.textBoxInterests.Size = new Size(444, 124);
            this.textBoxInterests.TabIndex = 7;
            this.textBoxInterests.TextChanged += this.textBox2_TextChanged;
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.AutoScroll = true;
            this.tabPersonalInfo.Controls.Add(this.birthDatePicker);
            this.tabPersonalInfo.Controls.Add(this.txtEmail);
            this.tabPersonalInfo.Controls.Add(this.textBox4);
            this.tabPersonalInfo.Controls.Add(this.txtPhoneNumber);
            this.tabPersonalInfo.Controls.Add(this.txtPassword);
            this.tabPersonalInfo.Controls.Add(this.txtFullName);
            this.tabPersonalInfo.Controls.Add(this.labelSignupDate);
            this.tabPersonalInfo.Controls.Add(this.labelBirthDate);
            this.tabPersonalInfo.Controls.Add(this.labelPhone);
            this.tabPersonalInfo.Controls.Add(this.labelPassword);
            this.tabPersonalInfo.Controls.Add(this.labelEmail);
            this.tabPersonalInfo.Controls.Add(this.labelFullName);
            this.tabPersonalInfo.Controls.Add(this.labelPersonalInfo);
            this.tabPersonalInfo.Location = new Point(4, 24);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new Padding(3);
            this.tabPersonalInfo.Size = new Size(588, 441);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "Personal Information";
            this.tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // labelPersonalInfo
            // 
            this.labelPersonalInfo.AutoSize = true;
            this.labelPersonalInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelPersonalInfo.Location = new Point(27, 27);
            this.labelPersonalInfo.Name = "labelPersonalInfo";
            this.labelPersonalInfo.Size = new Size(257, 32);
            this.labelPersonalInfo.TabIndex = 0;
            this.labelPersonalInfo.Text = "Personal Information";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new Point(33, 77);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new Size(64, 15);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Full Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new Point(34, 128);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new Size(39, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new Point(33, 177);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new Size(60, 15);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new Point(33, 224);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(91, 15);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new Point(33, 274);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new Size(62, 15);
            this.labelBirthDate.TabIndex = 5;
            this.labelBirthDate.Text = "Birth Date:";
            // 
            // labelSignupDate
            // 
            this.labelSignupDate.AutoSize = true;
            this.labelSignupDate.Location = new Point(34, 325);
            this.labelSignupDate.Name = "labelSignupDate";
            this.labelSignupDate.Size = new Size(74, 15);
            this.labelSignupDate.TabIndex = 6;
            this.labelSignupDate.Text = "Signup Date:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new Point(127, 75);
            this.txtFullName.MaxLength = 100;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(248, 23);
            this.txtFullName.TabIndex = 7;
            this.txtFullName.Text = "Adham Hamdy Hamed Abdulhameid";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new Point(127, 173);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(248, 23);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "12345678910";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new Point(127, 222);
            this.txtPhoneNumber.MaxLength = 20;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new Size(248, 23);
            this.txtPhoneNumber.TabIndex = 9;
            this.txtPhoneNumber.Text = "01100123456";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Point(127, 320);
            this.textBox4.MaxLength = 15;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(248, 23);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "16/05/2025";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(127, 124);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(248, 23);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Text = "ez_peacy@hotdog.com";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new Point(127, 271);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new Size(248, 23);
            this.birthDatePicker.TabIndex = 12;
            // 
            // tabControlProfileInfo
            // 
            this.tabControlProfileInfo.Controls.Add(this.tabPersonalInfo);
            this.tabControlProfileInfo.Controls.Add(this.tabSkillsAndInterests);
            this.tabControlProfileInfo.Dock = DockStyle.Fill;
            this.tabControlProfileInfo.Location = new Point(3, 93);
            this.tabControlProfileInfo.Name = "tabControlProfileInfo";
            this.tabControlProfileInfo.SelectedIndex = 0;
            this.tabControlProfileInfo.Size = new Size(596, 469);
            this.tabControlProfileInfo.TabIndex = 21;
            this.tabControlProfileInfo.Tag = "";
            // 
            // JobSeekerProfileControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.layout);
            this.Name = "JobSeekerProfileControl";
            this.Size = new Size(602, 610);
            this.Load += this.JobSeekerProfileControl_Load;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.layout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabSkillsAndInterests.ResumeLayout(false);
            this.tabSkillsAndInterests.PerformLayout();
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabPersonalInfo.PerformLayout();
            this.tabControlProfileInfo.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Label labelUserName;
        private Panel panelHeader;
        private Button btnSaveChangesSkills;
        private TableLayoutPanel layout;
        private Panel panel1;
        private TabControl tabControlProfileInfo;
        private TabPage tabPersonalInfo;
        private DateTimePicker birthDatePicker;
        private TextBox txtEmail;
        private TextBox textBox4;
        private TextBox txtPhoneNumber;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private Label labelSignupDate;
        private Label labelBirthDate;
        private Label labelPhone;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelFullName;
        private Label labelPersonalInfo;
        private TabPage tabSkillsAndInterests;
        private TextBox textBoxInterests;
        private TextBox textBoxSkills;
        private Label labelInterests;
        private Label labelSkills;
        private Label labelSkillAndInterests;
    }
}
