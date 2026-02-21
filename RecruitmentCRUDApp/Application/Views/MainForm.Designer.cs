namespace RecruitmentApplication.Views
{
    partial class MainForm
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
            this.navPanel = new Panel();
            this.toolStrip1 = new ToolStrip();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.centralPanel = new Panel();
            this.navPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.navPanel.BackgroundImageLayout = ImageLayout.Center;
            this.navPanel.Controls.Add(this.toolStrip1);
            this.navPanel.Location = new Point(3, 3);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new Size(176, 539);
            this.navPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = DockStyle.Fill;
            this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new Size(176, 539);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.navPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.centralPanel, 1, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new Size(800, 545);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // centralPanel
            // 
            this.centralPanel.Dock = DockStyle.Fill;
            this.centralPanel.Location = new Point(185, 3);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new Size(612, 539);
            this.centralPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private ToolStrip toolStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel centralPanel;
    }
}