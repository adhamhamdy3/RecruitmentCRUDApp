namespace RecruitmentApplication.Views
{
    partial class SavedJobsControl
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
            this.lblHeader = new Label();
            this.dataGridSavedJobs = new DataGridView();
            this.btnRefresh = new Button();
            this.layout = new TableLayoutPanel();
            this.controlsPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize) this.dataGridSavedJobs).BeginInit();
            this.layout.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.lblHeader.Location = new Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new Size(568, 32);
            this.lblHeader.TabIndex = 24;
            this.lblHeader.Text = "SavedJobs";
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridSavedJobs
            // 
            this.dataGridSavedJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSavedJobs.Dock = DockStyle.Fill;
            this.dataGridSavedJobs.Location = new Point(3, 42);
            this.dataGridSavedJobs.Name = "dataGridSavedJobs";
            this.dataGridSavedJobs.Size = new Size(568, 362);
            this.dataGridSavedJobs.TabIndex = 25;
            this.dataGridSavedJobs.CellContentClick += this.dataGridSavedJobs_CellContentClick;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnRefresh.Location = new Point(490, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(75, 33);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += this.btnRefresh_Click;
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.layout.Controls.Add(this.controlsPanel, 0, 2);
            this.layout.Controls.Add(this.lblHeader, 0, 0);
            this.layout.Controls.Add(this.dataGridSavedJobs, 0, 1);
            this.layout.Dock = DockStyle.Fill;
            this.layout.Location = new Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            this.layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            this.layout.Size = new Size(574, 451);
            this.layout.TabIndex = 27;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.btnRefresh);
            this.controlsPanel.Dock = DockStyle.Fill;
            this.controlsPanel.Location = new Point(3, 410);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new Size(568, 38);
            this.controlsPanel.TabIndex = 26;
            // 
            // SavedJobsControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.layout);
            this.Name = "SavedJobsControl";
            this.Size = new Size(574, 451);
            ((System.ComponentModel.ISupportInitialize) this.dataGridSavedJobs).EndInit();
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.controlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        private Label lblHeader;
        private DataGridView dataGridSavedJobs;
        private Button btnRefresh;
        private TableLayoutPanel layout;
        private Panel controlsPanel;
    }
}
