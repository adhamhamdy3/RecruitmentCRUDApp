using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using RecruitmentApplication.Views;

namespace RecruitmentApplication.Views
{
    partial class JobDetailsForm
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
            this.lblCompanyName = new Label();
            this.tboxSkills = new TextBox();
            this.tboxDescription = new TextBox();
            this.dateDeadline = new DateTimePicker();
            this.lblJobType = new Label();
            this.lblSkills = new Label();
            this.lblWorkMode = new Label();
            this.lblDescription = new Label();
            this.lblExpLevel = new Label();
            this.lblDeadline = new Label();
            this.lblStatus = new Label();
            this.lblTitle = new Label();
            this.btnOk = new Button();
            this.lblHeader = new Label();
            this.tboxStatus = new TextBox();
            this.tboxExpLevel = new TextBox();
            this.tboxWorkMode = new TextBox();
            this.tboxJobType = new TextBox();
            this.tboxTitle = new TextBox();
            this.tboxCompanyName = new TextBox();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new Point(39, 60);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new Size(59, 15);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company";
            this.lblCompanyName.Click += this.lblCompanyName_Click;
            // 
            // tboxSkills
            // 
            this.tboxSkills.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
            this.tboxSkills.Location = new Point(118, 270);
            this.tboxSkills.Multiline = true;
            this.tboxSkills.Name = "tboxSkills";
            this.tboxSkills.ReadOnly = true;
            this.tboxSkills.Size = new Size(209, 58);
            this.tboxSkills.TabIndex = 19;
            // 
            // tboxDescription
            // 
            this.tboxDescription.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
            this.tboxDescription.Location = new Point(118, 334);
            this.tboxDescription.Multiline = true;
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.ReadOnly = true;
            this.tboxDescription.Size = new Size(209, 126);
            this.tboxDescription.TabIndex = 20;
            // 
            // dateDeadline
            // 
            this.dateDeadline.Anchor = AnchorStyles.Right;
            this.dateDeadline.Enabled = false;
            this.dateDeadline.Location = new Point(118, 236);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new Size(209, 23);
            this.dateDeadline.TabIndex = 18;
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.Location = new Point(46, 202);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new Size(52, 15);
            this.lblJobType.TabIndex = 5;
            this.lblJobType.Text = "Job Type";
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new Point(65, 270);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new Size(33, 15);
            this.lblSkills.TabIndex = 6;
            this.lblSkills.Text = "Skills";
            // 
            // lblWorkMode
            // 
            this.lblWorkMode.AutoSize = true;
            this.lblWorkMode.Location = new Point(29, 173);
            this.lblWorkMode.Name = "lblWorkMode";
            this.lblWorkMode.Size = new Size(69, 15);
            this.lblWorkMode.TabIndex = 7;
            this.lblWorkMode.Text = "Work Mode";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new Point(31, 334);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(67, 15);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // lblExpLevel
            // 
            this.lblExpLevel.AutoSize = true;
            this.lblExpLevel.Location = new Point(4, 144);
            this.lblExpLevel.Name = "lblExpLevel";
            this.lblExpLevel.Size = new Size(94, 15);
            this.lblExpLevel.TabIndex = 9;
            this.lblExpLevel.Text = "Experience Level";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new Point(45, 242);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new Size(53, 15);
            this.lblDeadline.TabIndex = 10;
            this.lblDeadline.Text = "Deadline";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new Point(59, 115);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(39, 15);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(69, 86);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(29, 15);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // btnOk
            // 
            this.btnOk.Location = new Point(252, 466);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new Size(75, 29);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += this.btnCancel_Click;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.lblHeader.Location = new Point(97, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new Size(140, 32);
            this.lblHeader.TabIndex = 22;
            this.lblHeader.Text = "Job Details";
            // 
            // tboxStatus
            // 
            this.tboxStatus.Location = new Point(118, 115);
            this.tboxStatus.Name = "tboxStatus";
            this.tboxStatus.ReadOnly = true;
            this.tboxStatus.Size = new Size(209, 23);
            this.tboxStatus.TabIndex = 23;
            // 
            // tboxExpLevel
            // 
            this.tboxExpLevel.Location = new Point(118, 144);
            this.tboxExpLevel.Name = "tboxExpLevel";
            this.tboxExpLevel.ReadOnly = true;
            this.tboxExpLevel.Size = new Size(209, 23);
            this.tboxExpLevel.TabIndex = 24;
            // 
            // tboxWorkMode
            // 
            this.tboxWorkMode.Location = new Point(118, 173);
            this.tboxWorkMode.Name = "tboxWorkMode";
            this.tboxWorkMode.ReadOnly = true;
            this.tboxWorkMode.Size = new Size(209, 23);
            this.tboxWorkMode.TabIndex = 25;
            // 
            // tboxJobType
            // 
            this.tboxJobType.Location = new Point(118, 202);
            this.tboxJobType.Name = "tboxJobType";
            this.tboxJobType.ReadOnly = true;
            this.tboxJobType.Size = new Size(209, 23);
            this.tboxJobType.TabIndex = 26;
            // 
            // tboxTitle
            // 
            this.tboxTitle.Location = new Point(118, 86);
            this.tboxTitle.Name = "tboxTitle";
            this.tboxTitle.ReadOnly = true;
            this.tboxTitle.Size = new Size(209, 23);
            this.tboxTitle.TabIndex = 27;
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.Location = new Point(118, 58);
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.ReadOnly = true;
            this.tboxCompanyName.Size = new Size(209, 23);
            this.tboxCompanyName.TabIndex = 27;
            // 
            // JobDetailsForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new Size(352, 507);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.tboxTitle);
            this.Controls.Add(this.tboxJobType);
            this.Controls.Add(this.tboxWorkMode);
            this.Controls.Add(this.tboxExpLevel);
            this.Controls.Add(this.tboxStatus);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tboxSkills);
            this.Controls.Add(this.tboxDescription);
            this.Controls.Add(this.dateDeadline);
            this.Controls.Add(this.lblJobType);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lblWorkMode);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblExpLevel);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCompanyName);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JobDetailsForm";
            this.Text = "Job Details";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Label lblCompanyName;
        private TextBox tboxSkills;
        private TextBox tboxDescription;
        private DateTimePicker dateDeadline;
        private Label lblJobType;
        private Label lblSkills;
        private Label lblWorkMode;
        private Label lblDescription;
        private Label lblExpLevel;
        private Label lblDeadline;
        private Label lblStatus;
        private Label lblTitle;
        private Button btnOk;
        private Label lblHeader;
        private TextBox tboxStatus;
        private TextBox tboxExpLevel;
        private TextBox tboxWorkMode;
        private TextBox tboxJobType;
        private TextBox tboxTitle;
        private TextBox tboxCompanyName;
    }
}