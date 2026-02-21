namespace RecruitmentApplication.Views
{
    partial class DashboardControl
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
            this.comboBoxQuestions = new ComboBox();
            this.tboxAnswer = new RichTextBox();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.panel2 = new Panel();
            this.header = new Label();
            this.questionLabel = new Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxQuestions
            // 
            this.comboBoxQuestions.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.comboBoxQuestions.FormattingEnabled = true;
            this.comboBoxQuestions.Location = new Point(15, 82);
            this.comboBoxQuestions.Name = "comboBoxQuestions";
            this.comboBoxQuestions.Size = new Size(661, 23);
            this.comboBoxQuestions.TabIndex = 4;
            this.comboBoxQuestions.SelectedIndexChanged += this.comboBoxQuestions_SelectedIndexChanged;
            // 
            // tboxAnswer
            // 
            this.tboxAnswer.Dock = DockStyle.Fill;
            this.tboxAnswer.Location = new Point(3, 133);
            this.tboxAnswer.Name = "tboxAnswer";
            this.tboxAnswer.ReadOnly = true;
            this.tboxAnswer.Size = new Size(687, 256);
            this.tboxAnswer.TabIndex = 5;
            this.tboxAnswer.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tboxAnswer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new Size(693, 392);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.questionLabel);
            this.panel1.Controls.Add(this.comboBoxQuestions);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(687, 124);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.header);
            this.panel2.Dock = DockStyle.Top;
            this.panel2.Location = new Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(687, 56);
            this.panel2.TabIndex = 7;
            // 
            // header
            // 
            this.header.Anchor = AnchorStyles.None;
            this.header.AutoSize = true;
            this.header.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.header.Location = new Point(236, 6);
            this.header.Name = "header";
            this.header.Size = new Size(184, 45);
            this.header.TabIndex = 5;
            this.header.Text = "Dashboard";
            this.header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new Point(15, 62);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new Size(188, 15);
            this.questionLabel.TabIndex = 6;
            this.questionLabel.Text = "Choose a question to be answered";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DashboardControl";
            this.Size = new Size(693, 392);
            this.Load += this.DashboardControl_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxQuestions;
        private RichTextBox tboxAnswer;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label header;
        private Label questionLabel;
        private Panel panel2;
    }
}
