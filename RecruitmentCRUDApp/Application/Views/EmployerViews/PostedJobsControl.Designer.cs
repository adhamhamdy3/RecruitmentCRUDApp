namespace RecruitmentApplication.Views
{
    partial class PostedJobsControl
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
            this.btnRefresh = new Button();
            this.labelPostedJobs = new Label();
            this.dataGridPostedJobs = new DataGridView();
            this.colCompanyName = new DataGridViewTextBoxColumn();
            this.colJobTitle = new DataGridViewTextBoxColumn();
            this.colStatus = new DataGridViewTextBoxColumn();
            this.colWorkMode = new DataGridViewTextBoxColumn();
            this.colJobType = new DataGridViewTextBoxColumn();
            this.colPostDate = new DataGridViewTextBoxColumn();
            this.colDeadline = new DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) this.dataGridPostedJobs).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.WhiteSmoke;
            this.panelHeader.BorderStyle = BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.btnRefresh);
            this.panelHeader.Controls.Add(this.labelPostedJobs);
            this.panelHeader.Dock = DockStyle.Fill;
            this.panelHeader.Location = new Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(1142, 59);
            this.panelHeader.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = AnchorStyles.Right;
            this.btnRefresh.Location = new Point(1024, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(103, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += this.btnRefresh_Click;
            // 
            // labelPostedJobs
            // 
            this.labelPostedJobs.Anchor = AnchorStyles.Left;
            this.labelPostedJobs.AutoSize = true;
            this.labelPostedJobs.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelPostedJobs.Location = new Point(4, 12);
            this.labelPostedJobs.Name = "labelPostedJobs";
            this.labelPostedJobs.Size = new Size(150, 32);
            this.labelPostedJobs.TabIndex = 3;
            this.labelPostedJobs.Text = "Posted Jobs";
            // 
            // dataGridPostedJobs
            // 
            this.dataGridPostedJobs.AllowUserToAddRows = false;
            this.dataGridPostedJobs.AllowUserToDeleteRows = false;
            this.dataGridPostedJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPostedJobs.Columns.AddRange(new DataGridViewColumn[] { this.colCompanyName, this.colJobTitle, this.colStatus, this.colWorkMode, this.colJobType, this.colPostDate, this.colDeadline });
            this.dataGridPostedJobs.Dock = DockStyle.Fill;
            this.dataGridPostedJobs.Location = new Point(3, 68);
            this.dataGridPostedJobs.Name = "dataGridPostedJobs";
            this.dataGridPostedJobs.Size = new Size(1142, 385);
            this.dataGridPostedJobs.TabIndex = 3;
            // 
            // colCompanyName
            // 
            this.colCompanyName.HeaderText = "Company Name";
            this.colCompanyName.MaxInputLength = 100;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            this.colCompanyName.Width = 150;
            // 
            // colJobTitle
            // 
            this.colJobTitle.HeaderText = "Job Title";
            this.colJobTitle.MaxInputLength = 100;
            this.colJobTitle.Name = "colJobTitle";
            this.colJobTitle.ReadOnly = true;
            this.colJobTitle.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Resizable = DataGridViewTriState.True;
            this.colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWorkMode
            // 
            this.colWorkMode.HeaderText = "Work Mode";
            this.colWorkMode.Name = "colWorkMode";
            this.colWorkMode.Resizable = DataGridViewTriState.True;
            this.colWorkMode.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colJobType
            // 
            this.colJobType.HeaderText = "Job Type";
            this.colJobType.Name = "colJobType";
            this.colJobType.Resizable = DataGridViewTriState.True;
            this.colJobType.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPostDate
            // 
            this.colPostDate.HeaderText = "Post Date";
            this.colPostDate.Name = "colPostDate";
            this.colPostDate.ReadOnly = true;
            // 
            // colDeadline
            // 
            this.colDeadline.HeaderText = "Deadline";
            this.colDeadline.Name = "colDeadline";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridPostedJobs, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2543859F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.74561F));
            this.tableLayoutPanel1.Size = new Size(1148, 456);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // PostedJobsControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PostedJobsControl";
            this.Size = new Size(1148, 456);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) this.dataGridPostedJobs).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button btnRefresh;
        private Label labelPostedJobs;
        private DataGridView dataGridPostedJobs;
        private DataGridViewTextBoxColumn colCompanyName;
        private DataGridViewTextBoxColumn colJobTitle;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colWorkMode;
        private DataGridViewTextBoxColumn colJobType;
        private DataGridViewTextBoxColumn colPostDate;
        private DataGridViewTextBoxColumn colDeadline;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
