namespace RecruitmentApplication.Views.Profiles
{
    partial class CompanyProfileControl
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
            tabControlProfileInfo = new TabControl();
            tabPersonalInfo = new TabPage();
            textBoxDescription = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtName = new TextBox();
            labelPhone = new Label();
            labelEmail = new Label();
            labelFullName = new Label();
            labelPersonalInfo = new Label();
            panelHeader = new Panel();
            labelUserName = new Label();
            btnSaveChanges = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControlProfileInfo.SuspendLayout();
            tabPersonalInfo.SuspendLayout();
            panelHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlProfileInfo
            // 
            tabControlProfileInfo.Controls.Add(tabPersonalInfo);
            tabControlProfileInfo.Dock = DockStyle.Fill;
            tabControlProfileInfo.Location = new Point(3, 86);
            tabControlProfileInfo.Name = "tabControlProfileInfo";
            tabControlProfileInfo.SelectedIndex = 0;
            tabControlProfileInfo.Size = new Size(602, 479);
            tabControlProfileInfo.TabIndex = 28;
            tabControlProfileInfo.Tag = "";
            // 
            // tabPersonalInfo
            // 
            tabPersonalInfo.AutoScroll = true;
            tabPersonalInfo.Controls.Add(textBoxDescription);
            tabPersonalInfo.Controls.Add(label1);
            tabPersonalInfo.Controls.Add(txtEmail);
            tabPersonalInfo.Controls.Add(txtPhoneNumber);
            tabPersonalInfo.Controls.Add(txtName);
            tabPersonalInfo.Controls.Add(labelPhone);
            tabPersonalInfo.Controls.Add(labelEmail);
            tabPersonalInfo.Controls.Add(labelFullName);
            tabPersonalInfo.Controls.Add(labelPersonalInfo);
            tabPersonalInfo.Location = new Point(4, 24);
            tabPersonalInfo.Name = "tabPersonalInfo";
            tabPersonalInfo.Padding = new Padding(3);
            tabPersonalInfo.Size = new Size(594, 451);
            tabPersonalInfo.TabIndex = 0;
            tabPersonalInfo.Text = "Company Information";
            tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(145, 217);
            textBoxDescription.MaxLength = 20;
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(248, 127);
            textBoxDescription.TabIndex = 13;
            textBoxDescription.Text = "Best juice company in 2021,2022";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 220);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 12;
            label1.Text = "Description";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 124);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 11;
            txtEmail.Text = "ez_peacy@hotdog.com";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(145, 171);
            txtPhoneNumber.MaxLength = 20;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(248, 23);
            txtPhoneNumber.TabIndex = 9;
            txtPhoneNumber.Text = "01100123456";
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 75);
            txtName.MaxLength = 100;
            txtName.Name = "txtName";
            txtName.Size = new Size(248, 23);
            txtName.TabIndex = 7;
            txtName.Text = "Adham Hamdy Hamed Abdulhameid";
            txtName.TextChanged += txtFullName_TextChanged;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(48, 174);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(91, 15);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone Number:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(94, 127);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(42, 78);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(97, 15);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Company Name:";
            // 
            // labelPersonalInfo
            // 
            labelPersonalInfo.AutoSize = true;
            labelPersonalInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPersonalInfo.Location = new Point(33, 33);
            labelPersonalInfo.Name = "labelPersonalInfo";
            labelPersonalInfo.Size = new Size(257, 32);
            labelPersonalInfo.TabIndex = 0;
            labelPersonalInfo.Text = "Personal Information";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.GhostWhite;
            panelHeader.BorderStyle = BorderStyle.Fixed3D;
            panelHeader.Controls.Add(labelUserName);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(602, 77);
            panelHeader.TabIndex = 27;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(210, 15);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(137, 45);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "Bekhiro";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.DialogResult = DialogResult.Abort;
            btnSaveChanges.Dock = DockStyle.Right;
            btnSaveChanges.Location = new Point(493, 571);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(112, 43);
            btnSaveChanges.TabIndex = 29;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnSaveChanges, 0, 2);
            tableLayoutPanel1.Controls.Add(tabControlProfileInfo, 0, 1);
            tableLayoutPanel1.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.6126757F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.38732F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(608, 617);
            tableLayoutPanel1.TabIndex = 30;
            // 
            // CompanyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CompanyControl";
            Size = new Size(608, 617);
            Load += CompanyControl_Load;
            tabControlProfileInfo.ResumeLayout(false);
            tabPersonalInfo.ResumeLayout(false);
            tabPersonalInfo.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlProfileInfo;
        private TabPage tabPersonalInfo;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelFullName;
        private Label labelPersonalInfo;
        private Panel panelHeader;
        private Label labelUserName;
        private Button btnSaveChanges;
        private TextBox textBoxDescription;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
