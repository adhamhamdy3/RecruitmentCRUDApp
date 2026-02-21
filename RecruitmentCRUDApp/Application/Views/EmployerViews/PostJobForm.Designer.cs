namespace RecruitmentApplication.Views
{
    partial class PostJobForm
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
            this.btnPost = new Button();
            this.lblHeader = new Label();
            this.tboxSkills = new TextBox();
            this.tboxDescription = new TextBox();
            this.dateDeadline = new DateTimePicker();
            this.cmboxJobType = new ComboBox();
            this.cmboxWorkMode = new ComboBox();
            this.cmboxExpLevel = new ComboBox();
            this.lblJobType = new Label();
            this.cmboxStatus = new ComboBox();
            this.lblSkills = new Label();
            this.lblWorkMode = new Label();
            this.lblDescription = new Label();
            this.lblExpLevel = new Label();
            this.lblDeadline = new Label();
            this.lblStatus = new Label();
            this.tboxTitle = new TextBox();
            this.lblTitle = new Label();
            this.btnCancel = new Button();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Location = new Point(268, 454);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new Size(75, 29);
            this.btnPost.TabIndex = 24;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += this.btnPost_Click;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.lblHeader.Location = new Point(75, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new Size(228, 32);
            this.lblHeader.TabIndex = 23;
            this.lblHeader.Text = "Create Job Posting";
            // 
            // tboxSkills
            // 
            this.tboxSkills.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
            this.tboxSkills.Location = new Point(134, 256);
            this.tboxSkills.Multiline = true;
            this.tboxSkills.Name = "tboxSkills";
            this.tboxSkills.Size = new Size(209, 58);
            this.tboxSkills.TabIndex = 22;
            // 
            // tboxDescription
            // 
            this.tboxDescription.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
            this.tboxDescription.Location = new Point(134, 320);
            this.tboxDescription.Multiline = true;
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Size = new Size(209, 126);
            this.tboxDescription.TabIndex = 21;
            // 
            // dateDeadline
            // 
            this.dateDeadline.Anchor = AnchorStyles.Right;
            this.dateDeadline.Location = new Point(134, 222);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new Size(209, 23);
            this.dateDeadline.TabIndex = 20;
            // 
            // cmboxJobType
            // 
            this.cmboxJobType.Anchor = AnchorStyles.Right;
            this.cmboxJobType.FormattingEnabled = true;
            this.cmboxJobType.Location = new Point(134, 188);
            this.cmboxJobType.Name = "cmboxJobType";
            this.cmboxJobType.Size = new Size(209, 23);
            this.cmboxJobType.TabIndex = 18;
            // 
            // cmboxWorkMode
            // 
            this.cmboxWorkMode.Anchor = AnchorStyles.Right;
            this.cmboxWorkMode.FormattingEnabled = true;
            this.cmboxWorkMode.Location = new Point(134, 159);
            this.cmboxWorkMode.Name = "cmboxWorkMode";
            this.cmboxWorkMode.Size = new Size(209, 23);
            this.cmboxWorkMode.TabIndex = 17;
            // 
            // cmboxExpLevel
            // 
            this.cmboxExpLevel.Anchor = AnchorStyles.Right;
            this.cmboxExpLevel.FormattingEnabled = true;
            this.cmboxExpLevel.Location = new Point(134, 130);
            this.cmboxExpLevel.Name = "cmboxExpLevel";
            this.cmboxExpLevel.Size = new Size(209, 23);
            this.cmboxExpLevel.TabIndex = 19;
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.Location = new Point(62, 188);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new Size(52, 15);
            this.lblJobType.TabIndex = 7;
            this.lblJobType.Text = "Job Type";
            // 
            // cmboxStatus
            // 
            this.cmboxStatus.Anchor = AnchorStyles.Right;
            this.cmboxStatus.FormattingEnabled = true;
            this.cmboxStatus.Location = new Point(134, 101);
            this.cmboxStatus.Name = "cmboxStatus";
            this.cmboxStatus.Size = new Size(209, 23);
            this.cmboxStatus.TabIndex = 16;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new Point(81, 256);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new Size(33, 15);
            this.lblSkills.TabIndex = 13;
            this.lblSkills.Text = "Skills";
            // 
            // lblWorkMode
            // 
            this.lblWorkMode.AutoSize = true;
            this.lblWorkMode.Location = new Point(45, 159);
            this.lblWorkMode.Name = "lblWorkMode";
            this.lblWorkMode.Size = new Size(69, 15);
            this.lblWorkMode.TabIndex = 12;
            this.lblWorkMode.Text = "Work Mode";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new Point(47, 320);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(67, 15);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // lblExpLevel
            // 
            this.lblExpLevel.AutoSize = true;
            this.lblExpLevel.Location = new Point(20, 130);
            this.lblExpLevel.Name = "lblExpLevel";
            this.lblExpLevel.Size = new Size(94, 15);
            this.lblExpLevel.TabIndex = 10;
            this.lblExpLevel.Text = "Experience Level";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new Point(61, 228);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new Size(53, 15);
            this.lblDeadline.TabIndex = 9;
            this.lblDeadline.Text = "Deadline";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new Point(75, 101);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(39, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // tboxTitle
            // 
            this.tboxTitle.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
            this.tboxTitle.Location = new Point(134, 69);
            this.tboxTitle.Name = "tboxTitle";
            this.tboxTitle.Size = new Size(209, 23);
            this.tboxTitle.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(85, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(29, 15);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Title";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new Point(187, 454);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(75, 29);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += this.btnCancel_Click;
            // 
            // PostJobForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new Size(372, 506);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tboxSkills);
            this.Controls.Add(this.tboxDescription);
            this.Controls.Add(this.dateDeadline);
            this.Controls.Add(this.cmboxJobType);
            this.Controls.Add(this.cmboxWorkMode);
            this.Controls.Add(this.cmboxExpLevel);
            this.Controls.Add(this.lblJobType);
            this.Controls.Add(this.cmboxStatus);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lblWorkMode);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblExpLevel);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tboxTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostJobForm";
            this.Text = "PostJobForm";
            this.Load += this.PostJobForm_Load;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button btnPost;
        private Label lblHeader;
        private TextBox tboxSkills;
        private TextBox tboxDescription;
        private DateTimePicker dateDeadline;
        private ComboBox cmboxJobType;
        private ComboBox cmboxWorkMode;
        private ComboBox cmboxExpLevel;
        private Label lblJobType;
        private ComboBox cmboxStatus;
        private Label lblSkills;
        private Label lblWorkMode;
        private Label lblDescription;
        private Label lblExpLevel;
        private Label lblDeadline;
        private Label lblStatus;
        private TextBox tboxTitle;
        private Label lblTitle;
        private Button btnCancel;
    }
}