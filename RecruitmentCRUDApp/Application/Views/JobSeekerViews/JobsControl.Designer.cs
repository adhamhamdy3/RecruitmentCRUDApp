namespace RecruitmentApplication.Views
{
    partial class JobsControl
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
            refreshBtn = new Button();
            groupJobType = new GroupBox();
            cbxJobTypeContract = new CheckBox();
            cbxJobTypePartTime = new CheckBox();
            cbxJobTypeFullTime = new CheckBox();
            gboxWorkMode = new GroupBox();
            cboxWorkModeHybrid = new CheckBox();
            cboxWorkModeRemote = new CheckBox();
            cboxWorkModeOnSite = new CheckBox();
            gboxExperienceLevel = new GroupBox();
            cboxExperienceLevelStudent = new CheckBox();
            cboxExperienceLevelFreshGrad = new CheckBox();
            cboxExperienceLevelJunior = new CheckBox();
            cboxExperienceLevelMidLevel = new CheckBox();
            cboxExperienceLevelSenior = new CheckBox();
            btnApplyFilters = new Button();
            tboxSearchInput = new TextBox();
            btnSearch = new Button();
            dataGridPostings = new DataGridView();
            layout = new TableLayoutPanel();
            searchPanel = new Panel();
            filtersPanel = new Panel();
            btnClearFilters = new Button();
            groupJobType.SuspendLayout();
            gboxWorkMode.SuspendLayout();
            gboxExperienceLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPostings).BeginInit();
            layout.SuspendLayout();
            searchPanel.SuspendLayout();
            filtersPanel.SuspendLayout();
            SuspendLayout();
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Left;
            refreshBtn.Location = new Point(6, 15);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(98, 38);
            refreshBtn.TabIndex = 4;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // groupJobType
            // 
            groupJobType.Controls.Add(cbxJobTypeContract);
            groupJobType.Controls.Add(cbxJobTypePartTime);
            groupJobType.Controls.Add(cbxJobTypeFullTime);
            groupJobType.Location = new Point(122, 15);
            groupJobType.Name = "groupJobType";
            groupJobType.Size = new Size(103, 152);
            groupJobType.TabIndex = 2;
            groupJobType.TabStop = false;
            groupJobType.Text = "Job Type";
            // 
            // cbxJobTypeContract
            // 
            cbxJobTypeContract.AutoSize = true;
            cbxJobTypeContract.Location = new Point(12, 69);
            cbxJobTypeContract.Name = "cbxJobTypeContract";
            cbxJobTypeContract.Size = new Size(72, 19);
            cbxJobTypeContract.TabIndex = 9;
            cbxJobTypeContract.Text = "Contract";
            cbxJobTypeContract.UseVisualStyleBackColor = true;
            // 
            // cbxJobTypePartTime
            // 
            cbxJobTypePartTime.AutoSize = true;
            cbxJobTypePartTime.Location = new Point(12, 44);
            cbxJobTypePartTime.Name = "cbxJobTypePartTime";
            cbxJobTypePartTime.Size = new Size(79, 19);
            cbxJobTypePartTime.TabIndex = 8;
            cbxJobTypePartTime.Text = "Part-Time";
            cbxJobTypePartTime.UseVisualStyleBackColor = true;
            // 
            // cbxJobTypeFullTime
            // 
            cbxJobTypeFullTime.AutoSize = true;
            cbxJobTypeFullTime.Location = new Point(12, 19);
            cbxJobTypeFullTime.Name = "cbxJobTypeFullTime";
            cbxJobTypeFullTime.Size = new Size(77, 19);
            cbxJobTypeFullTime.TabIndex = 7;
            cbxJobTypeFullTime.Text = "Full-Time";
            cbxJobTypeFullTime.UseVisualStyleBackColor = true;
            // 
            // gboxWorkMode
            // 
            gboxWorkMode.Controls.Add(cboxWorkModeHybrid);
            gboxWorkMode.Controls.Add(cboxWorkModeRemote);
            gboxWorkMode.Controls.Add(cboxWorkModeOnSite);
            gboxWorkMode.Location = new Point(231, 15);
            gboxWorkMode.Name = "gboxWorkMode";
            gboxWorkMode.Size = new Size(94, 152);
            gboxWorkMode.TabIndex = 2;
            gboxWorkMode.TabStop = false;
            gboxWorkMode.Text = "Work Mode";
            // 
            // cboxWorkModeHybrid
            // 
            cboxWorkModeHybrid.AutoSize = true;
            cboxWorkModeHybrid.Location = new Point(12, 69);
            cboxWorkModeHybrid.Name = "cboxWorkModeHybrid";
            cboxWorkModeHybrid.Size = new Size(62, 19);
            cboxWorkModeHybrid.TabIndex = 12;
            cboxWorkModeHybrid.Text = "Hybrid";
            cboxWorkModeHybrid.UseVisualStyleBackColor = true;
            // 
            // cboxWorkModeRemote
            // 
            cboxWorkModeRemote.AutoSize = true;
            cboxWorkModeRemote.Location = new Point(12, 44);
            cboxWorkModeRemote.Name = "cboxWorkModeRemote";
            cboxWorkModeRemote.Size = new Size(67, 19);
            cboxWorkModeRemote.TabIndex = 11;
            cboxWorkModeRemote.Text = "Remote";
            cboxWorkModeRemote.UseVisualStyleBackColor = true;
            // 
            // cboxWorkModeOnSite
            // 
            cboxWorkModeOnSite.AutoSize = true;
            cboxWorkModeOnSite.Location = new Point(12, 19);
            cboxWorkModeOnSite.Name = "cboxWorkModeOnSite";
            cboxWorkModeOnSite.Size = new Size(66, 19);
            cboxWorkModeOnSite.TabIndex = 10;
            cboxWorkModeOnSite.Text = "On-Site";
            cboxWorkModeOnSite.UseVisualStyleBackColor = true;
            // 
            // gboxExperienceLevel
            // 
            gboxExperienceLevel.Controls.Add(cboxExperienceLevelStudent);
            gboxExperienceLevel.Controls.Add(cboxExperienceLevelFreshGrad);
            gboxExperienceLevel.Controls.Add(cboxExperienceLevelJunior);
            gboxExperienceLevel.Controls.Add(cboxExperienceLevelMidLevel);
            gboxExperienceLevel.Controls.Add(cboxExperienceLevelSenior);
            gboxExperienceLevel.Location = new Point(331, 15);
            gboxExperienceLevel.Name = "gboxExperienceLevel";
            gboxExperienceLevel.Size = new Size(124, 152);
            gboxExperienceLevel.TabIndex = 2;
            gboxExperienceLevel.TabStop = false;
            gboxExperienceLevel.Text = "Experience Level";
            // 
            // cboxExperienceLevelStudent
            // 
            cboxExperienceLevelStudent.AutoSize = true;
            cboxExperienceLevelStudent.Location = new Point(12, 119);
            cboxExperienceLevelStudent.Name = "cboxExperienceLevelStudent";
            cboxExperienceLevelStudent.Size = new Size(67, 19);
            cboxExperienceLevelStudent.TabIndex = 17;
            cboxExperienceLevelStudent.Text = "Student";
            cboxExperienceLevelStudent.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelFreshGrad
            // 
            cboxExperienceLevelFreshGrad.AutoSize = true;
            cboxExperienceLevelFreshGrad.Location = new Point(12, 94);
            cboxExperienceLevelFreshGrad.Name = "cboxExperienceLevelFreshGrad";
            cboxExperienceLevelFreshGrad.Size = new Size(105, 19);
            cboxExperienceLevelFreshGrad.TabIndex = 16;
            cboxExperienceLevelFreshGrad.Text = "Fresh Graduate";
            cboxExperienceLevelFreshGrad.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelJunior
            // 
            cboxExperienceLevelJunior.AutoSize = true;
            cboxExperienceLevelJunior.Location = new Point(12, 69);
            cboxExperienceLevelJunior.Name = "cboxExperienceLevelJunior";
            cboxExperienceLevelJunior.Size = new Size(58, 19);
            cboxExperienceLevelJunior.TabIndex = 15;
            cboxExperienceLevelJunior.Text = "Junior";
            cboxExperienceLevelJunior.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelMidLevel
            // 
            cboxExperienceLevelMidLevel.AutoSize = true;
            cboxExperienceLevelMidLevel.Location = new Point(12, 44);
            cboxExperienceLevelMidLevel.Name = "cboxExperienceLevelMidLevel";
            cboxExperienceLevelMidLevel.Size = new Size(79, 19);
            cboxExperienceLevelMidLevel.TabIndex = 14;
            cboxExperienceLevelMidLevel.Text = "Mid-Level";
            cboxExperienceLevelMidLevel.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelSenior
            // 
            cboxExperienceLevelSenior.AutoSize = true;
            cboxExperienceLevelSenior.Location = new Point(12, 19);
            cboxExperienceLevelSenior.Name = "cboxExperienceLevelSenior";
            cboxExperienceLevelSenior.Size = new Size(59, 19);
            cboxExperienceLevelSenior.TabIndex = 13;
            cboxExperienceLevelSenior.Text = "Senior";
            cboxExperienceLevelSenior.TextAlign = ContentAlignment.MiddleCenter;
            cboxExperienceLevelSenior.UseVisualStyleBackColor = true;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Anchor = AnchorStyles.Left;
            btnApplyFilters.Location = new Point(6, 59);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(98, 38);
            btnApplyFilters.TabIndex = 5;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = true;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // tboxSearchInput
            // 
            tboxSearchInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tboxSearchInput.Location = new Point(6, 9);
            tboxSearchInput.MinimumSize = new Size(0, 27);
            tboxSearchInput.Name = "tboxSearchInput";
            tboxSearchInput.PlaceholderText = "Search for available vacancies";
            tboxSearchInput.Size = new Size(532, 27);
            tboxSearchInput.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Right;
            btnSearch.Location = new Point(541, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridPostings
            // 
            dataGridPostings.AllowUserToAddRows = false;
            dataGridPostings.AllowUserToDeleteRows = false;
            dataGridPostings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPostings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPostings.Location = new Point(3, 53);
            dataGridPostings.Name = "dataGridPostings";
            dataGridPostings.Size = new Size(643, 245);
            dataGridPostings.TabIndex = 3;
            dataGridPostings.CellContentClick += dataGridPostings_CellContentClick;
            // 
            // layout
            // 
            layout.ColumnCount = 1;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.Controls.Add(dataGridPostings, 0, 1);
            layout.Controls.Add(searchPanel, 0, 0);
            layout.Controls.Add(filtersPanel, 0, 2);
            layout.Dock = DockStyle.Fill;
            layout.Location = new Point(0, 0);
            layout.Name = "layout";
            layout.RowCount = 3;
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            layout.Size = new Size(649, 501);
            layout.TabIndex = 8;
            // 
            // searchPanel
            // 
            searchPanel.Controls.Add(btnSearch);
            searchPanel.Controls.Add(tboxSearchInput);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(3, 3);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(643, 44);
            searchPanel.TabIndex = 8;
            // 
            // filtersPanel
            // 
            filtersPanel.Controls.Add(gboxExperienceLevel);
            filtersPanel.Controls.Add(refreshBtn);
            filtersPanel.Controls.Add(gboxWorkMode);
            filtersPanel.Controls.Add(btnClearFilters);
            filtersPanel.Controls.Add(btnApplyFilters);
            filtersPanel.Controls.Add(groupJobType);
            filtersPanel.Dock = DockStyle.Fill;
            filtersPanel.Location = new Point(3, 304);
            filtersPanel.Name = "filtersPanel";
            filtersPanel.Size = new Size(643, 194);
            filtersPanel.TabIndex = 9;
            // 
            // btnClearFilters
            // 
            btnClearFilters.Anchor = AnchorStyles.Left;
            btnClearFilters.Location = new Point(6, 103);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(98, 38);
            btnClearFilters.TabIndex = 6;
            btnClearFilters.Text = "Clear Filters";
            btnClearFilters.UseVisualStyleBackColor = true;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // JobsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(layout);
            Name = "JobsControl";
            Size = new Size(649, 501);
            Load += JobsControl_Load;
            groupJobType.ResumeLayout(false);
            groupJobType.PerformLayout();
            gboxWorkMode.ResumeLayout(false);
            gboxWorkMode.PerformLayout();
            gboxExperienceLevel.ResumeLayout(false);
            gboxExperienceLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPostings).EndInit();
            layout.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            filtersPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button refreshBtn;
        private GroupBox groupJobType;
        private CheckBox cbxJobTypePartTime;
        private CheckBox cbxJobTypeFullTime;
        private CheckBox cbxJobTypeContract;
        private GroupBox gboxWorkMode;
        private CheckBox cboxWorkModeHybrid;
        private CheckBox cboxWorkModeRemote;
        private CheckBox cboxWorkModeOnSite;
        private GroupBox gboxExperienceLevel;
        private CheckBox cboxExperienceLevelJunior;
        private CheckBox cboxExperienceLevelMidLevel;
        private CheckBox cboxExperienceLevelSenior;
        private Button btnApplyFilters;
        private CheckBox cboxExperienceLevelFreshGrad;
        private CheckBox cboxExperienceLevelStudent;
        private TextBox tboxSearchInput;
        private Button btnSearch;
        private DataGridView dataGridPostings;
        private TableLayoutPanel layout;
        private Panel searchPanel;
        private Panel filtersPanel;
        private Button btnClearFilters;
    }
}
