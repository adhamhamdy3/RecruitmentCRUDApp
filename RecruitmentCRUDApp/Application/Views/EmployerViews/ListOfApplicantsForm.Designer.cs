namespace RecruitmentApplication.Views
{
    partial class ListOfApplicantsForm
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
            this.dataGridJobApplicants = new DataGridView();
            this.colPostDate = new DataGridViewTextBoxColumn();
            this.colStatus = new DataGridViewComboBoxColumn();
            this.colAppDate = new DataGridViewTextBoxColumn();
            this.colApplicantName = new DataGridViewTextBoxColumn();
            this.panelHeader = new Panel();
            this.btnRefresh = new Button();
            this.btnCancel = new Button();
            this.btnSaveChanges = new Button();
            this.labelLOA = new Label();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize) this.dataGridJobApplicants).BeginInit();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridJobApplicants
            // 
            this.dataGridJobApplicants.AllowUserToAddRows = false;
            this.dataGridJobApplicants.AllowUserToDeleteRows = false;
            this.dataGridJobApplicants.AllowUserToResizeRows = false;
            this.dataGridJobApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJobApplicants.Columns.AddRange(new DataGridViewColumn[] { this.colApplicantName, this.colAppDate, this.colStatus, this.colPostDate });
            this.dataGridJobApplicants.Dock = DockStyle.Fill;
            this.dataGridJobApplicants.Location = new Point(3, 83);
            this.dataGridJobApplicants.Name = "dataGridJobApplicants";
            this.dataGridJobApplicants.Size = new Size(661, 438);
            this.dataGridJobApplicants.TabIndex = 2;
            // 
            // colPostDate
            // 
            this.colPostDate.HeaderText = "Post Date";
            this.colPostDate.Name = "colPostDate";
            this.colPostDate.ReadOnly = true;
            this.colPostDate.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Items.AddRange(new object[] { "Pending", "Under Review", "Interviewed", "Accepted", "Rejected" });
            this.colStatus.Name = "colStatus";
            // 
            // colAppDate
            // 
            this.colAppDate.HeaderText = "Application Date";
            this.colAppDate.Name = "colAppDate";
            this.colAppDate.ReadOnly = true;
            this.colAppDate.Width = 150;
            // 
            // colApplicantName
            // 
            this.colApplicantName.HeaderText = "Applicant Name";
            this.colApplicantName.MaxInputLength = 100;
            this.colApplicantName.Name = "colApplicantName";
            this.colApplicantName.ReadOnly = true;
            this.colApplicantName.Width = 200;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.WhiteSmoke;
            this.panelHeader.BorderStyle = BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.labelLOA);
            this.panelHeader.Controls.Add(this.btnSaveChanges);
            this.panelHeader.Controls.Add(this.btnCancel);
            this.panelHeader.Controls.Add(this.btnRefresh);
            this.panelHeader.Dock = DockStyle.Fill;
            this.panelHeader.Location = new Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(661, 74);
            this.panelHeader.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = AnchorStyles.Right;
            this.btnRefresh.Location = new Point(395, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(75, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += this.btnRefresh_Click;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = AnchorStyles.Right;
            this.btnCancel.Location = new Point(573, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(75, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += this.btnCancel_Click;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = AnchorStyles.Right;
            this.btnSaveChanges.Location = new Point(474, 20);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new Size(94, 32);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += this.btnSaveChanges_Click;
            // 
            // labelLOA
            // 
            this.labelLOA.Anchor = AnchorStyles.Left;
            this.labelLOA.AutoSize = true;
            this.labelLOA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelLOA.Location = new Point(20, 18);
            this.labelLOA.Name = "labelLOA";
            this.labelLOA.Size = new Size(212, 32);
            this.labelLOA.TabIndex = 9;
            this.labelLOA.Text = "List of Applicants";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridJobApplicants, 0, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new Size(667, 524);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ListOfApplicantsForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(667, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListOfApplicantsForm";
            this.Text = "List of Applicants";
            ((System.ComponentModel.ISupportInitialize) this.dataGridJobApplicants).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridJobApplicants;
        private DataGridViewTextBoxColumn colApplicantName;
        private DataGridViewTextBoxColumn colAppDate;
        private DataGridViewComboBoxColumn colStatus;
        private DataGridViewTextBoxColumn colPostDate;
        private Panel panelHeader;
        private Label labelLOA;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Button btnRefresh;
        private TableLayoutPanel tableLayoutPanel1;
    }
}