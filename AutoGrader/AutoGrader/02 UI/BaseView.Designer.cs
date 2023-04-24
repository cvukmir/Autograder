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
            _baseViewMenuStrip = new MenuStrip();
            _baseViewFileOption = new ToolStripMenuItem();
            _baseViewOpenOption = new ToolStripMenuItem();
            _baseViewOpenInstructorFileButton = new ToolStripMenuItem();
            _baseViewOpenStudentFileButton = new ToolStripMenuItem();
            _baseViewSaveButton = new ToolStripMenuItem();
            _baseViewSaveAsOption = new ToolStripMenuItem();
            _baseViewSaveAsXmlButton = new ToolStripMenuItem();
            _baseViewSaveAsTxtButton = new ToolStripMenuItem();
            _baseViewCloseButton = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            _baseViewEditOption = new ToolStripMenuItem();
            _baseViewFindOption = new ToolStripMenuItem();
            _baseViewFindInInstructorFileButton = new ToolStripMenuItem();
            _baseViewFindInStudentButton = new ToolStripMenuItem();
            _baseViewFindInAllButton = new ToolStripMenuItem();
            _baseViewViewOption = new ToolStripMenuItem();
            _baseViewGradeReportButton = new ToolStripMenuItem();
            _baseViewDiffButton = new ToolStripMenuItem();
            _baseViewRunOption = new ToolStripMenuItem();
            _baseViewRunAllToolStripMenuItem = new ToolStripMenuItem();
            _baseViewRunInstructorToolStripMenuItem = new ToolStripMenuItem();
            _baseViewStudentToolStripMenuItem = new ToolStripMenuItem();
            _baseViewHelpOption = new ToolStripMenuItem();
            _baseViewAboutButton = new ToolStripMenuItem();
            _baseViewBottomPanel = new Panel();
            _baseViewConsoleTextBox = new TextBox();
            _baseViewSplitter = new SplitContainer();
            _baseViewInstructorPanel = new Panel();
            _baseViewStudentPanel = new Panel();
            _baseViewMenuStrip.SuspendLayout();
            _baseViewBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_baseViewSplitter).BeginInit();
            _baseViewSplitter.Panel1.SuspendLayout();
            _baseViewSplitter.Panel2.SuspendLayout();
            _baseViewSplitter.SuspendLayout();
            SuspendLayout();
            // 
            // _baseViewMenuStrip
            // 
            _baseViewMenuStrip.GripMargin = new Padding(3, 0, 0, 0);
            _baseViewMenuStrip.ImageScalingSize = new Size(24, 24);
            _baseViewMenuStrip.Items.AddRange(new ToolStripItem[] { _baseViewFileOption, _baseViewEditOption, _baseViewViewOption, _baseViewRunOption, _baseViewHelpOption });
            _baseViewMenuStrip.Location = new Point(0, 0);
            _baseViewMenuStrip.Name = "_baseViewMenuStrip";
            _baseViewMenuStrip.Size = new Size(1630, 50);
            _baseViewMenuStrip.TabIndex = 0;
            // 
            // _baseViewFileOption
            // 
            _baseViewFileOption.DropDownItems.AddRange(new ToolStripItem[] { _baseViewOpenOption, _baseViewSaveButton, _baseViewSaveAsOption, _baseViewCloseButton, openToolStripMenuItem });
            _baseViewFileOption.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _baseViewFileOption.Margin = new Padding(10, 10, 0, 0);
            _baseViewFileOption.Name = "_baseViewFileOption";
            _baseViewFileOption.Size = new Size(67, 36);
            _baseViewFileOption.Text = "File";
            // 
            // _baseViewOpenOption
            // 
            _baseViewOpenOption.DropDownItems.AddRange(new ToolStripItem[] { _baseViewOpenInstructorFileButton, _baseViewOpenStudentFileButton });
            _baseViewOpenOption.Name = "_baseViewOpenOption";
            _baseViewOpenOption.Size = new Size(200, 40);
            _baseViewOpenOption.Text = "Open";
            // 
            // _baseViewOpenInstructorFileButton
            // 
            _baseViewOpenInstructorFileButton.Name = "_baseViewOpenInstructorFileButton";
            _baseViewOpenInstructorFileButton.Size = new Size(263, 40);
            _baseViewOpenInstructorFileButton.Text = "Instructor File";
            _baseViewOpenInstructorFileButton.Click += _baseViewOpenInstructorFileButton_Click;
            // 
            // _baseViewOpenStudentFileButton
            // 
            _baseViewOpenStudentFileButton.Name = "_baseViewOpenStudentFileButton";
            _baseViewOpenStudentFileButton.Size = new Size(263, 40);
            _baseViewOpenStudentFileButton.Text = "Student File";
            _baseViewOpenStudentFileButton.Click += _baseViewOpenStudentFileButton_Click;
            // 
            // _baseViewSaveButton
            // 
            _baseViewSaveButton.Name = "_baseViewSaveButton";
            _baseViewSaveButton.Size = new Size(200, 40);
            _baseViewSaveButton.Text = "Save";
            // 
            // _baseViewSaveAsOption
            // 
            _baseViewSaveAsOption.DropDownItems.AddRange(new ToolStripItem[] { _baseViewSaveAsXmlButton, _baseViewSaveAsTxtButton });
            _baseViewSaveAsOption.Name = "_baseViewSaveAsOption";
            _baseViewSaveAsOption.Size = new Size(200, 40);
            _baseViewSaveAsOption.Text = "Save As";
            // 
            // _baseViewSaveAsXmlButton
            // 
            _baseViewSaveAsXmlButton.Name = "_baseViewSaveAsXmlButton";
            _baseViewSaveAsXmlButton.Size = new Size(161, 40);
            _baseViewSaveAsXmlButton.Text = ".xml";
            // 
            // _baseViewSaveAsTxtButton
            // 
            _baseViewSaveAsTxtButton.Name = "_baseViewSaveAsTxtButton";
            _baseViewSaveAsTxtButton.Size = new Size(161, 40);
            _baseViewSaveAsTxtButton.Text = ".txt";
            // 
            // _baseViewCloseButton
            // 
            _baseViewCloseButton.Name = "_baseViewCloseButton";
            _baseViewCloseButton.Size = new Size(200, 40);
            _baseViewCloseButton.Text = "Close";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(200, 40);
            openToolStripMenuItem.Text = "Open";
            // 
            // _baseViewEditOption
            // 
            _baseViewEditOption.DropDownItems.AddRange(new ToolStripItem[] { _baseViewFindOption });
            _baseViewEditOption.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _baseViewEditOption.Margin = new Padding(10, 10, 0, 0);
            _baseViewEditOption.Name = "_baseViewEditOption";
            _baseViewEditOption.Size = new Size(70, 36);
            _baseViewEditOption.Text = "Edit";
            // 
            // _baseViewFindOption
            // 
            _baseViewFindOption.DropDownItems.AddRange(new ToolStripItem[] { _baseViewFindInInstructorFileButton, _baseViewFindInStudentButton, _baseViewFindInAllButton });
            _baseViewFindOption.Name = "_baseViewFindOption";
            _baseViewFindOption.Size = new Size(270, 40);
            _baseViewFindOption.Text = "Find in...";
            // 
            // _baseViewFindInInstructorFileButton
            // 
            _baseViewFindInInstructorFileButton.Name = "_baseViewFindInInstructorFileButton";
            _baseViewFindInInstructorFileButton.Size = new Size(263, 40);
            _baseViewFindInInstructorFileButton.Text = "Instructor FIle";
            // 
            // _baseViewFindInStudentButton
            // 
            _baseViewFindInStudentButton.Name = "_baseViewFindInStudentButton";
            _baseViewFindInStudentButton.Size = new Size(263, 40);
            _baseViewFindInStudentButton.Text = "Student File";
            // 
            // _baseViewFindInAllButton
            // 
            _baseViewFindInAllButton.Name = "_baseViewFindInAllButton";
            _baseViewFindInAllButton.Size = new Size(263, 40);
            _baseViewFindInAllButton.Text = "All FIles";
            // 
            // _baseViewViewOption
            // 
            _baseViewViewOption.DropDownItems.AddRange(new ToolStripItem[] { _baseViewGradeReportButton, _baseViewDiffButton });
            _baseViewViewOption.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _baseViewViewOption.Margin = new Padding(10, 10, 0, 0);
            _baseViewViewOption.Name = "_baseViewViewOption";
            _baseViewViewOption.Size = new Size(81, 36);
            _baseViewViewOption.Text = "View";
            // 
            // _baseViewGradeReportButton
            // 
            _baseViewGradeReportButton.Name = "_baseViewGradeReportButton";
            _baseViewGradeReportButton.Size = new Size(258, 40);
            _baseViewGradeReportButton.Text = "Grade Report";
            // 
            // _baseViewDiffButton
            // 
            _baseViewDiffButton.Name = "_baseViewDiffButton";
            _baseViewDiffButton.Size = new Size(258, 40);
            _baseViewDiffButton.Text = "Diff Files";
            // 
            // _baseViewRunOption
            // 
            _baseViewRunOption.DropDownItems.AddRange(new ToolStripItem[] { _baseViewRunAllToolStripMenuItem, _baseViewRunInstructorToolStripMenuItem, _baseViewStudentToolStripMenuItem });
            _baseViewRunOption.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _baseViewRunOption.Margin = new Padding(10, 10, 0, 0);
            _baseViewRunOption.Name = "_baseViewRunOption";
            _baseViewRunOption.Size = new Size(72, 36);
            _baseViewRunOption.Text = "Run";
            // 
            // _baseViewRunAllToolStripMenuItem
            // 
            _baseViewRunAllToolStripMenuItem.Name = "_baseViewRunAllToolStripMenuItem";
            _baseViewRunAllToolStripMenuItem.Size = new Size(270, 40);
            _baseViewRunAllToolStripMenuItem.Text = "Run All";
            _baseViewRunAllToolStripMenuItem.Click += _baseViewRunAllToolStripMenuItem_Click;
            // 
            // _baseViewRunInstructorToolStripMenuItem
            // 
            _baseViewRunInstructorToolStripMenuItem.Name = "_baseViewRunInstructorToolStripMenuItem";
            _baseViewRunInstructorToolStripMenuItem.Size = new Size(270, 40);
            _baseViewRunInstructorToolStripMenuItem.Text = "Run Instructor";
            _baseViewRunInstructorToolStripMenuItem.Click += _baseViewRunInstructorToolStripMenuItem_Click;
            // 
            // _baseViewStudentToolStripMenuItem
            // 
            _baseViewStudentToolStripMenuItem.Name = "_baseViewStudentToolStripMenuItem";
            _baseViewStudentToolStripMenuItem.Size = new Size(270, 40);
            _baseViewStudentToolStripMenuItem.Text = "Run Student";
            _baseViewStudentToolStripMenuItem.Click += _baseViewRsunStudentToolStripMenuItem_Click;
            // 
            // _baseViewHelpOption
            // 
            _baseViewHelpOption.DropDownItems.AddRange(new ToolStripItem[] { _baseViewAboutButton });
            _baseViewHelpOption.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _baseViewHelpOption.Margin = new Padding(10, 10, 0, 0);
            _baseViewHelpOption.Name = "_baseViewHelpOption";
            _baseViewHelpOption.Size = new Size(80, 36);
            _baseViewHelpOption.Text = "Help";
            // 
            // _baseViewAboutButton
            // 
            _baseViewAboutButton.Name = "_baseViewAboutButton";
            _baseViewAboutButton.Size = new Size(183, 40);
            _baseViewAboutButton.Text = "About";
            // 
            // _baseViewBottomPanel
            // 
            _baseViewBottomPanel.Controls.Add(_baseViewConsoleTextBox);
            _baseViewBottomPanel.Dock = DockStyle.Bottom;
            _baseViewBottomPanel.Location = new Point(0, 786);
            _baseViewBottomPanel.Name = "_baseViewBottomPanel";
            _baseViewBottomPanel.Size = new Size(1630, 150);
            _baseViewBottomPanel.TabIndex = 1;
            // 
            // _baseViewConsoleTextBox
            // 
            _baseViewConsoleTextBox.Dock = DockStyle.Fill;
            _baseViewConsoleTextBox.Location = new Point(0, 0);
            _baseViewConsoleTextBox.Multiline = true;
            _baseViewConsoleTextBox.Name = "_baseViewConsoleTextBox";
            _baseViewConsoleTextBox.ReadOnly = true;
            _baseViewConsoleTextBox.ScrollBars = ScrollBars.Vertical;
            _baseViewConsoleTextBox.Size = new Size(1630, 150);
            _baseViewConsoleTextBox.TabIndex = 0;
            _baseViewConsoleTextBox.Text = "Console>";
            // 
            // _baseViewSplitter
            // 
            _baseViewSplitter.Dock = DockStyle.Fill;
            _baseViewSplitter.Location = new Point(0, 50);
            _baseViewSplitter.Name = "_baseViewSplitter";
            // 
            // _baseViewSplitter.Panel1
            // 
            _baseViewSplitter.Panel1.Controls.Add(_baseViewInstructorPanel);
            _baseViewSplitter.Panel1.Padding = new Padding(10);
            // 
            // _baseViewSplitter.Panel2
            // 
            _baseViewSplitter.Panel2.Controls.Add(_baseViewStudentPanel);
            _baseViewSplitter.Panel2.Padding = new Padding(10);
            _baseViewSplitter.Size = new Size(1630, 736);
            _baseViewSplitter.SplitterDistance = 784;
            _baseViewSplitter.SplitterWidth = 10;
            _baseViewSplitter.TabIndex = 2;
            // 
            // _baseViewInstructorPanel
            // 
            _baseViewInstructorPanel.AllowDrop = true;
            _baseViewInstructorPanel.BackColor = Color.White;
            _baseViewInstructorPanel.BackgroundImageLayout = ImageLayout.Center;
            _baseViewInstructorPanel.Dock = DockStyle.Fill;
            _baseViewInstructorPanel.Location = new Point(10, 10);
            _baseViewInstructorPanel.Name = "_baseViewInstructorPanel";
            _baseViewInstructorPanel.Size = new Size(764, 716);
            _baseViewInstructorPanel.TabIndex = 0;
            // 
            // _baseViewStudentPanel
            // 
            _baseViewStudentPanel.AllowDrop = true;
            _baseViewStudentPanel.BackColor = Color.White;
            _baseViewStudentPanel.BackgroundImageLayout = ImageLayout.Center;
            _baseViewStudentPanel.Dock = DockStyle.Fill;
            _baseViewStudentPanel.Location = new Point(10, 10);
            _baseViewStudentPanel.Name = "_baseViewStudentPanel";
            _baseViewStudentPanel.Size = new Size(816, 716);
            _baseViewStudentPanel.TabIndex = 1;
            // 
            // BaseView
            // 
            ClientSize = new Size(1630, 936);
            Controls.Add(_baseViewSplitter);
            Controls.Add(_baseViewBottomPanel);
            Controls.Add(_baseViewMenuStrip);
            MainMenuStrip = _baseViewMenuStrip;
            Name = "BaseView";
            _baseViewMenuStrip.ResumeLayout(false);
            _baseViewMenuStrip.PerformLayout();
            _baseViewBottomPanel.ResumeLayout(false);
            _baseViewBottomPanel.PerformLayout();
            _baseViewSplitter.Panel1.ResumeLayout(false);
            _baseViewSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_baseViewSplitter).EndInit();
            _baseViewSplitter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripMenuItem _baseViewRunAllToolStripMenuItem;
        private ToolStripMenuItem _baseViewRunInstructorToolStripMenuItem;
        private ToolStripMenuItem _baseViewStudentToolStripMenuItem;
    }
}