namespace RecruitmentApplication.Views.Profiles
{
    partial class EmployerProfileControl
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
            this.panelHeader = new Panel();
            this.labelUserName = new Label();
            this.btnSaveChanges = new Button();
            this.tabCompany = new TabPage();
            this.labelSelectCompany = new Label();
            this.buttonCreateCompany = new Button();
            this.comboBoxCompany = new ComboBox();
            this.labelCompany = new Label();
            this.tabPersonalInfo = new TabPage();
            this.birthDatePicker = new DateTimePicker();
            this.txtEmail = new TextBox();
            this.textBox4 = new TextBox();
            this.txtPhoneNumber = new TextBox();
            this.txtPassword = new TextBox();
            this.txtFullName = new TextBox();
            this.labelSignupDate = new Label();
            this.labelBirthDate = new Label();
            this.labelPhone = new Label();
            this.labelPassword = new Label();
            this.labelEmail = new Label();
            this.labelFullName = new Label();
            this.labelPersonalInfo = new Label();
            this.tabControlProfileInfo = new TabControl();
            this.layout = new TableLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.tabCompany.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tabControlProfileInfo.SuspendLayout();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.GhostWhite;
            this.panelHeader.BorderStyle = BorderStyle.Fixed3D;
            this.panelHeader.Controls.Add(this.labelUserName);
            this.panelHeader.Dock = DockStyle.Fill;
            this.panelHeader.Location = new Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(611, 88);
            this.panelHeader.TabIndex = 24;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelUserName.Location = new Point(18, 16);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new Size(222, 40);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Adham Hamdy";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.DialogResult = DialogResult.Abort;
            this.btnSaveChanges.Dock = DockStyle.Right;
            this.btnSaveChanges.Location = new Point(502, 577);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new Size(112, 38);
            this.btnSaveChanges.TabIndex = 9;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += this.btnSaveChanges_Click;
            // 
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.labelSelectCompany);
            this.tabCompany.Controls.Add(this.buttonCreateCompany);
            this.tabCompany.Controls.Add(this.comboBoxCompany);
            this.tabCompany.Controls.Add(this.labelCompany);
            this.tabCompany.Location = new Point(4, 24);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.Padding = new Padding(3);
            this.tabCompany.Size = new Size(603, 446);
            this.tabCompany.TabIndex = 1;
            this.tabCompany.Text = "Company";
            this.tabCompany.UseVisualStyleBackColor = true;
            // 
            // labelSelectCompany
            // 
            this.labelSelectCompany.AutoSize = true;
            this.labelSelectCompany.Location = new Point(28, 95);
            this.labelSelectCompany.Name = "labelSelectCompany";
            this.labelSelectCompany.Size = new Size(165, 15);
            this.labelSelectCompany.TabIndex = 4;
            this.labelSelectCompany.Text = "Select Company You Work At:";
            // 
            // buttonCreateCompany
            // 
            this.buttonCreateCompany.Location = new Point(30, 129);
            this.buttonCreateCompany.Name = "buttonCreateCompany";
            this.buttonCreateCompany.Size = new Size(106, 32);
            this.buttonCreateCompany.TabIndex = 3;
            this.buttonCreateCompany.Text = "Create Company";
            this.buttonCreateCompany.UseVisualStyleBackColor = true;
            this.buttonCreateCompany.Click += this.buttonCreateCompany_Click;
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new Point(200, 92);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new Size(179, 23);
            this.comboBoxCompany.TabIndex = 4;
            this.comboBoxCompany.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelCompany.Location = new Point(30, 30);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new Size(122, 32);
            this.labelCompany.TabIndex = 1;
            this.labelCompany.Text = "Company";
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
            this.tabPersonalInfo.Size = new Size(603, 446);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "Personal Information";
            this.tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new Point(127, 281);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new Size(248, 23);
            this.birthDatePicker.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(127, 133);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(248, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "ez_peasy@hotdog.com";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Point(127, 331);
            this.textBox4.MaxLength = 15;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(248, 23);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "16/05/2025";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new Point(127, 232);
            this.txtPhoneNumber.MaxLength = 20;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new Size(248, 23);
            this.txtPhoneNumber.TabIndex = 6;
            this.txtPhoneNumber.Text = "01100123456";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new Point(127, 184);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(248, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "12345678910";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new Point(127, 86);
            this.txtFullName.MaxLength = 100;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(248, 23);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.Text = "Adham Hamdy Hamed Abdulhameid";
            // 
            // labelSignupDate
            // 
            this.labelSignupDate.AutoSize = true;
            this.labelSignupDate.Location = new Point(36, 334);
            this.labelSignupDate.Name = "labelSignupDate";
            this.labelSignupDate.Size = new Size(74, 15);
            this.labelSignupDate.TabIndex = 6;
            this.labelSignupDate.Text = "Signup Date:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new Point(48, 287);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new Size(62, 15);
            this.labelBirthDate.TabIndex = 5;
            this.labelBirthDate.Text = "Birth Date:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new Point(19, 235);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(91, 15);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new Point(50, 187);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new Size(60, 15);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new Point(71, 136);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new Size(39, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new Point(46, 89);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new Size(64, 15);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Full Name:";
            // 
            // labelPersonalInfo
            // 
            this.labelPersonalInfo.AutoSize = true;
            this.labelPersonalInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelPersonalInfo.Location = new Point(30, 30);
            this.labelPersonalInfo.Name = "labelPersonalInfo";
            this.labelPersonalInfo.Size = new Size(257, 32);
            this.labelPersonalInfo.TabIndex = 0;
            this.labelPersonalInfo.Text = "Personal Information";
            // 
            // tabControlProfileInfo
            // 
            this.tabControlProfileInfo.Controls.Add(this.tabPersonalInfo);
            this.tabControlProfileInfo.Controls.Add(this.tabCompany);
            this.tabControlProfileInfo.Dock = DockStyle.Fill;
            this.tabControlProfileInfo.Location = new Point(3, 97);
            this.tabControlProfileInfo.Name = "tabControlProfileInfo";
            this.tabControlProfileInfo.SelectedIndex = 0;
            this.tabControlProfileInfo.Size = new Size(611, 474);
            this.tabControlProfileInfo.TabIndex = 1;
            this.tabControlProfileInfo.Tag = "";
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.layout.Controls.Add(this.tabControlProfileInfo, 0, 1);
            this.layout.Controls.Add(this.panelHeader, 0, 0);
            this.layout.Controls.Add(this.btnSaveChanges, 0, 2);
            this.layout.Dock = DockStyle.Fill;
            this.layout.Location = new Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            this.layout.RowStyles.Add(new RowStyle(SizeType.Percent, 91.60305F));
            this.layout.RowStyles.Add(new RowStyle(SizeType.Percent, 8.396947F));
            this.layout.Size = new Size(617, 618);
            this.layout.TabIndex = 27;
            // 
            // EmployerControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.layout);
            this.Name = "EmployerControl";
            this.Size = new Size(617, 618);
            this.Load += this.EmployerControl_Load;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabCompany.ResumeLayout(false);
            this.tabCompany.PerformLayout();
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabPersonalInfo.PerformLayout();
            this.tabControlProfileInfo.ResumeLayout(false);
            this.layout.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label labelUserName;
        private Button btnSaveChanges;
        private TabPage tabCompany;
        private Label labelCompany;
        private TabPage tabPersonalInfo;
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
        private TabControl tabControlProfileInfo;
        private ComboBox comboBoxCompany;
        private Button buttonCreateCompany;
        private TableLayoutPanel layout;
        private Label labelSelectCompany;
        private DateTimePicker birthDatePicker;
    }
}
