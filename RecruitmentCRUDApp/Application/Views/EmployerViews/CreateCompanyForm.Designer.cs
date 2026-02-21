namespace RecruitmentApplication.Views
{
    partial class CreateCompanyForm
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
            this.labelHeader = new Label();
            this.labelCompanyName = new Label();
            this.labelEmail = new Label();
            this.labelDescription = new Label();
            this.labelPhone = new Label();
            this.btnCancel = new Button();
            this.brnCreate = new Button();
            this.txtCompanyName = new TextBox();
            this.textPhone = new TextBox();
            this.textEmail = new TextBox();
            this.textDescription = new TextBox();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelHeader.Location = new Point(110, 29);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new Size(202, 32);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Create Company";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new Point(62, 93);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new Size(42, 15);
            this.labelCompanyName.TabIndex = 1;
            this.labelCompanyName.Text = "Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new Point(65, 147);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new Size(39, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new Point(34, 255);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new Size(70, 15);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new Point(60, 201);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(44, 15);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new Point(163, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(75, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += this.btnCancel_Click;
            // 
            // brnCreate
            // 
            this.brnCreate.Location = new Point(244, 399);
            this.brnCreate.Name = "brnCreate";
            this.brnCreate.Size = new Size(75, 39);
            this.brnCreate.TabIndex = 6;
            this.brnCreate.Text = "Create";
            this.brnCreate.UseVisualStyleBackColor = true;
            this.brnCreate.Click += this.brnCreate_Click;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new Point(110, 90);
            this.txtCompanyName.MaxLength = 100;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PlaceholderText = "Company or organization name\n\n";
            this.txtCompanyName.Size = new Size(209, 23);
            this.txtCompanyName.TabIndex = 1;
            // 
            // textPhone
            // 
            this.textPhone.Location = new Point(110, 198);
            this.textPhone.MaxLength = 20;
            this.textPhone.Name = "textPhone";
            this.textPhone.PlaceholderText = "e.g., +1 123 456 7890\n\n";
            this.textPhone.Size = new Size(209, 23);
            this.textPhone.TabIndex = 9;
            // 
            // textEmail
            // 
            this.textEmail.Location = new Point(110, 144);
            this.textEmail.MaxLength = 100;
            this.textEmail.Name = "textEmail";
            this.textEmail.PlaceholderText = "e.g., company@example.com\n\n";
            this.textEmail.Size = new Size(209, 23);
            this.textEmail.TabIndex = 2;
            // 
            // textDescription
            // 
            this.textDescription.Location = new Point(110, 252);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.PlaceholderText = "Briefly describe the company\n\n";
            this.textDescription.Size = new Size(209, 139);
            this.textDescription.TabIndex = 10;
            // 
            // CreateCompanyForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new Size(386, 488);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.brnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelHeader);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(360, 490);
            this.Name = "CreateCompanyForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Create Company Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private Label labelCompanyName;
        private Label labelEmail;
        private Label labelDescription;
        private Label labelPhone;
        private Button btnCancel;
        private Button brnCreate;
        private TextBox txtCompanyName;
        private TextBox textPhone;
        private TextBox textEmail;
        private TextBox textDescription;
    }
}