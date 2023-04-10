namespace AutoGrader
{
    partial class BaseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseView));
            this._baseViewMenuStrip = new System.Windows.Forms.MenuStrip();
            this._baseViewFileOption = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewOpenOption = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewOpenInstructorFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewOpenStudentFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewSaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewSaveAsOption = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewSaveAsXmlButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewSaveAsTxtButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewCloseButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewEditOption = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewFindOption = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewFindInInstructorFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewFindInStudentButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewFindInAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewViewOption = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewGradeReportButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewDiffButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewRunOption = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewRunAsOption = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewRunAsCppButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewRunAsJavaButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewRunAsCsButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewRunAsPythonButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewHelpOption = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewAboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewBottomPanel = new System.Windows.Forms.Panel();
            this._baseViewConsoleTextBox = new System.Windows.Forms.TextBox();
            this._baseViewSplitter = new System.Windows.Forms.SplitContainer();
            this._baseViewInstructorPanel = new System.Windows.Forms.Panel();
            this._baseViewStudentPanel = new System.Windows.Forms.Panel();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._baseViewMenuStrip.SuspendLayout();
            this._baseViewBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._baseViewSplitter)).BeginInit();
            this._baseViewSplitter.Panel1.SuspendLayout();
            this._baseViewSplitter.Panel2.SuspendLayout();
            this._baseViewSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // _baseViewMenuStrip
            // 
            this._baseViewMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._baseViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._baseViewFileOption,
            this._baseViewEditOption,
            this._baseViewViewOption,
            this._baseViewRunOption,
            this._baseViewHelpOption});
            this._baseViewMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._baseViewMenuStrip.Name = "_baseViewMenuStrip";
            this._baseViewMenuStrip.Size = new System.Drawing.Size(1358, 33);
            this._baseViewMenuStrip.TabIndex = 0;
            // 
            // _baseViewFileOption
            // 
            this._baseViewFileOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._baseViewOpenOption,
            this._baseViewSaveButton,
            this._baseViewSaveAsOption,
            this._baseViewCloseButton,
            this.openToolStripMenuItem});
            this._baseViewFileOption.Name = "_baseViewFileOption";
            this._baseViewFileOption.Size = new System.Drawing.Size(54, 29);
            this._baseViewFileOption.Text = "File";
            // 
            // _baseViewOpenOption
            // 
            this._baseViewOpenOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._baseViewOpenInstructorFileButton,
            this._baseViewOpenStudentFileButton});
            this._baseViewOpenOption.Name = "_baseViewOpenOption";
            this._baseViewOpenOption.Size = new System.Drawing.Size(270, 34);
            this._baseViewOpenOption.Text = "Open";
            // 
            // _baseViewOpenInstructorFileButton
            // 
            this._baseViewOpenInstructorFileButton.Name = "_baseViewOpenInstructorFileButton";
            this._baseViewOpenInstructorFileButton.Size = new System.Drawing.Size(270, 34);
            this._baseViewOpenInstructorFileButton.Text = "Instructor File";
            this._baseViewOpenInstructorFileButton.Click += new System.EventHandler(this._baseViewOpenInstructorFileButton_Click);
            // 
            // _baseViewOpenStudentFileButton
            // 
            this._baseViewOpenStudentFileButton.Name = "_baseViewOpenStudentFileButton";
            this._baseViewOpenStudentFileButton.Size = new System.Drawing.Size(270, 34);
            this._baseViewOpenStudentFileButton.Text = "Student File";
            this._baseViewOpenStudentFileButton.Click += new System.EventHandler(this._baseViewOpenStudentFileButton_Click);
            // 
            // _baseViewSaveButton
            // 
            this._baseViewSaveButton.Name = "_baseViewSaveButton";
            this._baseViewSaveButton.Size = new System.Drawing.Size(176, 34);
            this._baseViewSaveButton.Text = "Save";
            // 
            // _baseViewSaveAsOption
            // 
            this._baseViewSaveAsOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._baseViewSaveAsXmlButton,
            this._baseViewSaveAsTxtButton});
            this._baseViewSaveAsOption.Name = "_baseViewSaveAsOption";
            this._baseViewSaveAsOption.Size = new System.Drawing.Size(176, 34);
            this._baseViewSaveAsOption.Text = "Save As";
            // 
            // _baseViewSaveAsXmlButton
            // 
            this._baseViewSaveAsXmlButton.Name = "_baseViewSaveAsXmlButton";
            this._baseViewSaveAsXmlButton.Size = new System.Drawing.Size(270, 34);
            this._baseViewSaveAsXmlButton.Text = ".xml";
            // 
            // _baseViewSaveAsTxtButton
            // 
            this._baseViewSaveAsTxtButton.Name = "_baseViewSaveAsTxtButton";
            this._baseViewSaveAsTxtButton.Size = new System.Drawing.Size(270, 34);
            this._baseViewSaveAsTxtButton.Text = ".txt";
            // 
            // _baseViewCloseButton
            // 
            this._baseViewCloseButton.Name = "_baseViewCloseButton";
            this._baseViewCloseButton.Size = new System.Drawing.Size(176, 34);
            this._baseViewCloseButton.Text = "Close";
            // 
            // _baseViewEditOption
            // 
            this._baseViewEditOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._baseViewFindOption});
            this._baseViewEditOption.Name = "_baseViewEditOption";
            this._baseViewEditOption.Size = new System.Drawing.Size(58, 29);
            this._baseViewEditOption.Text = "Edit";
            // 
            // _baseViewFindOption
            // 
            this._baseViewFindOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._baseViewFindInInstructorFileButton,
            this._baseViewFindInStudentButton,
            this._baseViewFindInAllButton});
            this._baseViewFindOption.Name = "_baseViewFindOption";
            this._baseViewFindOption.Size = new System.Drawing.Size(270, 34);
            this._baseViewFindOption.Text = "Find in...";
            // 
            // _baseViewFindInInstructorFileButton
            // 
            this._baseViewFindInInstructorFileButton.Name = "_baseViewFindInInstructorFileButton";
            this._baseViewFindInInstructorFileButton.Size = new System.Drawing.Size(222, 34);
            this._baseViewFindInInstructorFileButton.Text = "Instructor FIle";
            // 
            // _baseViewFindInStudentButton
            // 
            this._baseViewFindInStudentButton.Name = "_baseViewFindInStudentButton";
            this._baseViewFindInStudentButton.Size = new System.Drawing.Size(222, 34);
            this._baseViewFindInStudentButton.Text = "Student File";
            // 
            // _baseViewFindInAllButton
            // 
            this._baseViewFindInAllButton.Name = "_baseViewFindInAllButton";
            this._baseViewFindInAllButton.Size = new System.Drawing.Size(222, 34);
            this._baseViewFindInAllButton.Text = "All FIles";
            // 
            // _baseViewViewOption
            // 
            this._baseViewViewOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._baseViewGradeReportButton,
            this._baseViewDiffButton});
            this._baseViewViewOption.Name = "_baseViewViewOption";
            this._baseViewViewOption.Size = new System.Drawing.Size(65, 29);
            this._baseViewViewOption.Text = "View";
            // 
            // _baseViewGradeReportButton
            // 
            this._baseViewGradeReportButton.Name = "_baseViewGradeReportButton";
            this._baseViewGradeReportButton.Size = new System.Drawing.Size(270, 34);
            this._baseViewGradeReportButton.Text = "Grade Report";
            // 
            // _baseViewDiffButton
            // 
            this._baseViewDiffButton.Name = "_baseViewDiffButton";
            this._baseViewDiffButton.Size = new System.Drawing.Size(270, 34);
            this._baseViewDiffButton.Text = "Diff Files";
            // 
            // _baseViewRunOption
            // 
            this._baseViewRunOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._baseViewRunAsOption});
            this._baseViewRunOption.Name = "_baseViewRunOption";
            this._baseViewRunOption.Size = new System.Drawing.Size(59, 29);
            this._baseViewRunOption.Text = "Run";
            // 
            // _baseViewRunAsOption
            // 
            this._baseViewRunAsOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._baseViewRunAsCppButton,
            this._baseViewRunAsJavaButton,
            this._baseViewRunAsCsButton,
            this._baseViewRunAsPythonButton});
            this._baseViewRunAsOption.Name = "_baseViewRunAsOption";
            this._baseViewRunAsOption.Size = new System.Drawing.Size(270, 34);
            this._baseViewRunAsOption.Text = "Run As";
            // 
            // _baseViewRunAsCppButton
            // 
            this._baseViewRunAsCppButton.Name = "_baseViewRunAsCppButton";
            this._baseViewRunAsCppButton.Size = new System.Drawing.Size(170, 34);
            this._baseViewRunAsCppButton.Text = "C++";
            // 
            // _baseViewRunAsJavaButton
            // 
            this._baseViewRunAsJavaButton.Name = "_baseViewRunAsJavaButton";
            this._baseViewRunAsJavaButton.Size = new System.Drawing.Size(170, 34);
            this._baseViewRunAsJavaButton.Text = "Java";
            // 
            // _baseViewRunAsCsButton
            // 
            this._baseViewRunAsCsButton.Name = "_baseViewRunAsCsButton";
            this._baseViewRunAsCsButton.Size = new System.Drawing.Size(170, 34);
            this._baseViewRunAsCsButton.Text = "C#";
            // 
            // _baseViewRunAsPythonButton
            // 
            this._baseViewRunAsPythonButton.Name = "_baseViewRunAsPythonButton";
            this._baseViewRunAsPythonButton.Size = new System.Drawing.Size(170, 34);
            this._baseViewRunAsPythonButton.Text = "Python";
            // 
            // _baseViewHelpOption
            // 
            this._baseViewHelpOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._baseViewAboutButton});
            this._baseViewHelpOption.Name = "_baseViewHelpOption";
            this._baseViewHelpOption.Size = new System.Drawing.Size(65, 29);
            this._baseViewHelpOption.Text = "Help";
            // 
            // _baseViewAboutButton
            // 
            this._baseViewAboutButton.Name = "_baseViewAboutButton";
            this._baseViewAboutButton.Size = new System.Drawing.Size(164, 34);
            this._baseViewAboutButton.Text = "About";
            // 
            // _baseViewBottomPanel
            // 
            this._baseViewBottomPanel.Controls.Add(this._baseViewConsoleTextBox);
            this._baseViewBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._baseViewBottomPanel.Location = new System.Drawing.Point(0, 576);
            this._baseViewBottomPanel.Name = "_baseViewBottomPanel";
            this._baseViewBottomPanel.Size = new System.Drawing.Size(1358, 150);
            this._baseViewBottomPanel.TabIndex = 1;
            // 
            // _baseViewConsoleTextBox
            // 
            this._baseViewConsoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._baseViewConsoleTextBox.Location = new System.Drawing.Point(0, 0);
            this._baseViewConsoleTextBox.Multiline = true;
            this._baseViewConsoleTextBox.Name = "_baseViewConsoleTextBox";
            this._baseViewConsoleTextBox.ReadOnly = true;
            this._baseViewConsoleTextBox.Size = new System.Drawing.Size(1358, 150);
            this._baseViewConsoleTextBox.TabIndex = 0;
            this._baseViewConsoleTextBox.Text = "Console>";
            // 
            // _baseViewSplitter
            // 
            this._baseViewSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._baseViewSplitter.Location = new System.Drawing.Point(0, 33);
            this._baseViewSplitter.Name = "_baseViewSplitter";
            // 
            // _baseViewSplitter.Panel1
            // 
            this._baseViewSplitter.Panel1.Controls.Add(this._baseViewInstructorPanel);
            this._baseViewSplitter.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // _baseViewSplitter.Panel2
            // 
            this._baseViewSplitter.Panel2.Controls.Add(this._baseViewStudentPanel);
            this._baseViewSplitter.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this._baseViewSplitter.Size = new System.Drawing.Size(1358, 543);
            this._baseViewSplitter.SplitterDistance = 654;
            this._baseViewSplitter.SplitterWidth = 10;
            this._baseViewSplitter.TabIndex = 2;
            // 
            // _baseViewInstructorPanel
            // 
            this._baseViewInstructorPanel.AllowDrop = true;
            this._baseViewInstructorPanel.BackColor = System.Drawing.Color.White;
            this._baseViewInstructorPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_baseViewInstructorPanel.BackgroundImage")));
            this._baseViewInstructorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._baseViewInstructorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._baseViewInstructorPanel.Location = new System.Drawing.Point(10, 10);
            this._baseViewInstructorPanel.Name = "_baseViewInstructorPanel";
            this._baseViewInstructorPanel.Size = new System.Drawing.Size(634, 523);
            this._baseViewInstructorPanel.TabIndex = 0;
            // 
            // _baseViewStudentPanel
            // 
            this._baseViewStudentPanel.AllowDrop = true;
            this._baseViewStudentPanel.BackColor = System.Drawing.Color.White;
            this._baseViewStudentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_baseViewStudentPanel.BackgroundImage")));
            this._baseViewStudentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._baseViewStudentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._baseViewStudentPanel.Location = new System.Drawing.Point(10, 10);
            this._baseViewStudentPanel.Name = "_baseViewStudentPanel";
            this._baseViewStudentPanel.Size = new System.Drawing.Size(674, 523);
            this._baseViewStudentPanel.TabIndex = 1;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // BaseView
            // 
            this.ClientSize = new System.Drawing.Size(1358, 726);
            this.Controls.Add(this._baseViewSplitter);
            this.Controls.Add(this._baseViewBottomPanel);
            this.Controls.Add(this._baseViewMenuStrip);
            this.MainMenuStrip = this._baseViewMenuStrip;
            this.Name = "BaseView";
            this._baseViewMenuStrip.ResumeLayout(false);
            this._baseViewMenuStrip.PerformLayout();
            this._baseViewBottomPanel.ResumeLayout(false);
            this._baseViewBottomPanel.PerformLayout();
            this._baseViewSplitter.Panel1.ResumeLayout(false);
            this._baseViewSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._baseViewSplitter)).EndInit();
            this._baseViewSplitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip _baseViewMenuStrip;
        private ToolStripMenuItem _baseViewFileOption;
        private ToolStripMenuItem _baseViewOpenOption;
        private ToolStripMenuItem _baseViewOpenInstructorFileButton;
        private ToolStripMenuItem _baseViewOpenStudentFileButton;
        private ToolStripMenuItem _baseViewSaveButton;
        private ToolStripMenuItem _baseViewSaveAsOption;
        private ToolStripMenuItem _baseViewSaveAsXmlButton;
        private ToolStripMenuItem _baseViewSaveAsTxtButton;
        private ToolStripMenuItem _baseViewCloseButton;
        private ToolStripMenuItem _baseViewEditOption;
        private ToolStripMenuItem _baseViewViewOption;
        private ToolStripMenuItem _baseViewGradeReportButton;
        private ToolStripMenuItem _baseViewDiffButton;
        private ToolStripMenuItem _baseViewRunOption;
        private ToolStripMenuItem _baseViewRunAsOption;
        private ToolStripMenuItem _baseViewRunAsCppButton;
        private ToolStripMenuItem _baseViewRunAsJavaButton;
        private ToolStripMenuItem _baseViewRunAsCsButton;
        private ToolStripMenuItem _baseViewRunAsPythonButton;
        private ToolStripMenuItem _baseViewFindOption;
        private ToolStripMenuItem _baseViewFindInInstructorFileButton;
        private ToolStripMenuItem _baseViewFindInStudentButton;
        private ToolStripMenuItem _baseViewHelpOption;
        private ToolStripMenuItem _baseViewAboutButton;
        private ToolStripMenuItem _baseViewFindInAllButton;
        private Panel _baseViewBottomPanel;
        private SplitContainer _baseViewSplitter;
        private TextBox _baseViewConsoleTextBox;
        private Panel _baseViewInstructorPanel;
        private Panel _baseViewStudentPanel;
        private ToolStripMenuItem openToolStripMenuItem;
    }
}