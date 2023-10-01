namespace ArcticAG_Admin
{
    partial class ArcAdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcAdminView));
            this.ArcLogo = new System.Windows.Forms.PictureBox();
            this.ArcRadioOptionsPanel = new System.Windows.Forms.Panel();
            this.ArcGradeReportRadio = new System.Windows.Forms.RadioButton();
            this.ArcNewAssignmentRadio = new System.Windows.Forms.RadioButton();
            this.ArcMainLabel = new System.Windows.Forms.Label();
            this.ArcMainNextButton = new System.Windows.Forms.Button();
            this.ArcMainPanel = new System.Windows.Forms.Panel();
            this.ArcNewAssignmentPanel = new System.Windows.Forms.Panel();
            this.ArcNewAssignmentPreviousButton = new System.Windows.Forms.Button();
            this.ArcSourceDirectoryButton = new System.Windows.Forms.Button();
            this.ArcSourceDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.ArcSourceDirectoryLabel = new System.Windows.Forms.Label();
            this.ArcAssignmentNameTextBox = new System.Windows.Forms.TextBox();
            this.ArcAssignmentNameLabel = new System.Windows.Forms.Label();
            this.ArcAssignmentLocationButton = new System.Windows.Forms.Button();
            this.ArcAssignmentLocationTextBox = new System.Windows.Forms.TextBox();
            this.ArcAssignmentLocationLabel = new System.Windows.Forms.Label();
            this.ArcNewAssignmentNextButton = new System.Windows.Forms.Button();
            this.ArcNewAssignmentLabel = new System.Windows.Forms.Label();
            this.ArcReportLocationPanel = new System.Windows.Forms.Panel();
            this.ArcReportPreviousButton = new System.Windows.Forms.Button();
            this.ArcReportLocationButton2 = new System.Windows.Forms.Button();
            this.ArcReportLocationTextBox = new System.Windows.Forms.TextBox();
            this.ArcReportLocationLabel = new System.Windows.Forms.Label();
            this.ArcReportNextButton = new System.Windows.Forms.Button();
            this.ArcViewGradeReportLabel = new System.Windows.Forms.Label();
            this.ArcReportPanel = new System.Windows.Forms.Panel();
            this.ArcReportTextBox = new System.Windows.Forms.TextBox();
            this.ArcDoneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArcLogo)).BeginInit();
            this.ArcRadioOptionsPanel.SuspendLayout();
            this.ArcMainPanel.SuspendLayout();
            this.ArcNewAssignmentPanel.SuspendLayout();
            this.ArcReportLocationPanel.SuspendLayout();
            this.ArcReportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArcLogo
            // 
            this.ArcLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ArcLogo.BackgroundImage")));
            this.ArcLogo.ErrorImage = null;
            this.ArcLogo.Location = new System.Drawing.Point(125, 10);
            this.ArcLogo.Name = "ArcLogo";
            this.ArcLogo.Size = new System.Drawing.Size(250, 150);
            this.ArcLogo.TabIndex = 0;
            this.ArcLogo.TabStop = false;
            // 
            // ArcRadioOptionsPanel
            // 
            this.ArcRadioOptionsPanel.Controls.Add(this.ArcGradeReportRadio);
            this.ArcRadioOptionsPanel.Controls.Add(this.ArcNewAssignmentRadio);
            this.ArcRadioOptionsPanel.Location = new System.Drawing.Point(12, 61);
            this.ArcRadioOptionsPanel.Name = "ArcRadioOptionsPanel";
            this.ArcRadioOptionsPanel.Size = new System.Drawing.Size(454, 150);
            this.ArcRadioOptionsPanel.TabIndex = 1;
            // 
            // ArcGradeReportRadio
            // 
            this.ArcGradeReportRadio.AutoSize = true;
            this.ArcGradeReportRadio.Location = new System.Drawing.Point(3, 38);
            this.ArcGradeReportRadio.Name = "ArcGradeReportRadio";
            this.ArcGradeReportRadio.Size = new System.Drawing.Size(179, 29);
            this.ArcGradeReportRadio.TabIndex = 2;
            this.ArcGradeReportRadio.Text = "View grade report";
            this.ArcGradeReportRadio.UseVisualStyleBackColor = true;
            // 
            // ArcNewAssignmentRadio
            // 
            this.ArcNewAssignmentRadio.AutoSize = true;
            this.ArcNewAssignmentRadio.Checked = true;
            this.ArcNewAssignmentRadio.Location = new System.Drawing.Point(3, 3);
            this.ArcNewAssignmentRadio.Name = "ArcNewAssignmentRadio";
            this.ArcNewAssignmentRadio.Size = new System.Drawing.Size(220, 29);
            this.ArcNewAssignmentRadio.TabIndex = 0;
            this.ArcNewAssignmentRadio.TabStop = true;
            this.ArcNewAssignmentRadio.Text = "Create new assignment";
            this.ArcNewAssignmentRadio.UseVisualStyleBackColor = true;
            // 
            // ArcMainLabel
            // 
            this.ArcMainLabel.Location = new System.Drawing.Point(102, 0);
            this.ArcMainLabel.Name = "ArcMainLabel";
            this.ArcMainLabel.Size = new System.Drawing.Size(273, 58);
            this.ArcMainLabel.TabIndex = 2;
            this.ArcMainLabel.Text = "Select one of the following options to continue:";
            this.ArcMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArcMainNextButton
            // 
            this.ArcMainNextButton.Location = new System.Drawing.Point(354, 306);
            this.ArcMainNextButton.Name = "ArcMainNextButton";
            this.ArcMainNextButton.Size = new System.Drawing.Size(112, 34);
            this.ArcMainNextButton.TabIndex = 3;
            this.ArcMainNextButton.Text = "Next";
            this.ArcMainNextButton.UseVisualStyleBackColor = true;
            this.ArcMainNextButton.Click += new System.EventHandler(this.ArcMainNextButton_Click);
            // 
            // ArcMainPanel
            // 
            this.ArcMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArcMainPanel.Controls.Add(this.ArcMainNextButton);
            this.ArcMainPanel.Controls.Add(this.ArcRadioOptionsPanel);
            this.ArcMainPanel.Controls.Add(this.ArcMainLabel);
            this.ArcMainPanel.Location = new System.Drawing.Point(0, 192);
            this.ArcMainPanel.Name = "ArcMainPanel";
            this.ArcMainPanel.Size = new System.Drawing.Size(478, 352);
            this.ArcMainPanel.TabIndex = 1;
            // 
            // ArcNewAssignmentPanel
            // 
            this.ArcNewAssignmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArcNewAssignmentPanel.Controls.Add(this.ArcNewAssignmentPreviousButton);
            this.ArcNewAssignmentPanel.Controls.Add(this.ArcSourceDirectoryButton);
            this.ArcNewAssignmentPanel.Controls.Add(this.ArcSourceDirectoryTextBox);
            this.ArcNewAssignmentPanel.Controls.Add(this.ArcSourceDirectoryLabel);
            this.ArcNewAssignmentPanel.Controls.Add(this.ArcAssignmentNameTextBox);
            this.ArcNewAssignmentPanel.Controls.Add(this.ArcAssignmentNameLabel);
            this.ArcNewAssignmentPanel.Controls.Add(this.ArcAssignmentLocationButton);
            this.ArcNewAssignmentPanel.Controls.Add(this.ArcAssignmentLocationTextBox);
            this.ArcNewAssignmentPanel.Controls.Add(this.ArcAssignmentLocationLabel);
            this.ArcNewAssignmentPanel.Controls.Add(this.ArcNewAssignmentNextButton);
            this.ArcNewAssignmentPanel.Controls.Add(this.ArcNewAssignmentLabel);
            this.ArcNewAssignmentPanel.Location = new System.Drawing.Point(0, 192);
            this.ArcNewAssignmentPanel.Name = "ArcNewAssignmentPanel";
            this.ArcNewAssignmentPanel.Size = new System.Drawing.Size(478, 352);
            this.ArcNewAssignmentPanel.TabIndex = 2;
            // 
            // ArcNewAssignmentPreviousButton
            // 
            this.ArcNewAssignmentPreviousButton.Location = new System.Drawing.Point(236, 306);
            this.ArcNewAssignmentPreviousButton.Name = "ArcNewAssignmentPreviousButton";
            this.ArcNewAssignmentPreviousButton.Size = new System.Drawing.Size(112, 34);
            this.ArcNewAssignmentPreviousButton.TabIndex = 18;
            this.ArcNewAssignmentPreviousButton.Text = "Previous";
            this.ArcNewAssignmentPreviousButton.UseVisualStyleBackColor = true;
            this.ArcNewAssignmentPreviousButton.Click += new System.EventHandler(this.ArcNewAssignmentPreviousButton_Click);
            // 
            // ArcSourceDirectoryButton
            // 
            this.ArcSourceDirectoryButton.Location = new System.Drawing.Point(343, 213);
            this.ArcSourceDirectoryButton.Name = "ArcSourceDirectoryButton";
            this.ArcSourceDirectoryButton.Size = new System.Drawing.Size(128, 34);
            this.ArcSourceDirectoryButton.TabIndex = 17;
            this.ArcSourceDirectoryButton.Text = "Browse...";
            this.ArcSourceDirectoryButton.UseVisualStyleBackColor = true;
            this.ArcSourceDirectoryButton.Click += new System.EventHandler(this.ArcSourceDirectoryButton_Click);
            // 
            // ArcSourceDirectoryTextBox
            // 
            this.ArcSourceDirectoryTextBox.Location = new System.Drawing.Point(12, 216);
            this.ArcSourceDirectoryTextBox.Name = "ArcSourceDirectoryTextBox";
            this.ArcSourceDirectoryTextBox.Size = new System.Drawing.Size(320, 31);
            this.ArcSourceDirectoryTextBox.TabIndex = 16;
            // 
            // ArcSourceDirectoryLabel
            // 
            this.ArcSourceDirectoryLabel.AutoSize = true;
            this.ArcSourceDirectoryLabel.Location = new System.Drawing.Point(12, 188);
            this.ArcSourceDirectoryLabel.Name = "ArcSourceDirectoryLabel";
            this.ArcSourceDirectoryLabel.Size = new System.Drawing.Size(186, 25);
            this.ArcSourceDirectoryLabel.TabIndex = 15;
            this.ArcSourceDirectoryLabel.Text = "Source Files Directory:";
            // 
            // ArcAssignmentNameTextBox
            // 
            this.ArcAssignmentNameTextBox.Location = new System.Drawing.Point(10, 154);
            this.ArcAssignmentNameTextBox.Name = "ArcAssignmentNameTextBox";
            this.ArcAssignmentNameTextBox.Size = new System.Drawing.Size(320, 31);
            this.ArcAssignmentNameTextBox.TabIndex = 14;
            // 
            // ArcAssignmentNameLabel
            // 
            this.ArcAssignmentNameLabel.AutoSize = true;
            this.ArcAssignmentNameLabel.Location = new System.Drawing.Point(12, 126);
            this.ArcAssignmentNameLabel.Name = "ArcAssignmentNameLabel";
            this.ArcAssignmentNameLabel.Size = new System.Drawing.Size(162, 25);
            this.ArcAssignmentNameLabel.TabIndex = 13;
            this.ArcAssignmentNameLabel.Text = "Assignment Name:";
            // 
            // ArcAssignmentLocationButton
            // 
            this.ArcAssignmentLocationButton.Location = new System.Drawing.Point(343, 90);
            this.ArcAssignmentLocationButton.Name = "ArcAssignmentLocationButton";
            this.ArcAssignmentLocationButton.Size = new System.Drawing.Size(128, 34);
            this.ArcAssignmentLocationButton.TabIndex = 12;
            this.ArcAssignmentLocationButton.Text = "Browse...";
            this.ArcAssignmentLocationButton.UseVisualStyleBackColor = true;
            this.ArcAssignmentLocationButton.Click += new System.EventHandler(this.ArcAssignmentLocationButton_Click);
            // 
            // ArcAssignmentLocationTextBox
            // 
            this.ArcAssignmentLocationTextBox.Location = new System.Drawing.Point(12, 92);
            this.ArcAssignmentLocationTextBox.Name = "ArcAssignmentLocationTextBox";
            this.ArcAssignmentLocationTextBox.Size = new System.Drawing.Size(320, 31);
            this.ArcAssignmentLocationTextBox.TabIndex = 11;
            // 
            // ArcAssignmentLocationLabel
            // 
            this.ArcAssignmentLocationLabel.AutoSize = true;
            this.ArcAssignmentLocationLabel.Location = new System.Drawing.Point(12, 64);
            this.ArcAssignmentLocationLabel.Name = "ArcAssignmentLocationLabel";
            this.ArcAssignmentLocationLabel.Size = new System.Drawing.Size(248, 25);
            this.ArcAssignmentLocationLabel.TabIndex = 10;
            this.ArcAssignmentLocationLabel.Text = "Assignment Storage Location:";
            // 
            // ArcNewAssignmentNextButton
            // 
            this.ArcNewAssignmentNextButton.Location = new System.Drawing.Point(354, 306);
            this.ArcNewAssignmentNextButton.Name = "ArcNewAssignmentNextButton";
            this.ArcNewAssignmentNextButton.Size = new System.Drawing.Size(112, 34);
            this.ArcNewAssignmentNextButton.TabIndex = 3;
            this.ArcNewAssignmentNextButton.Text = "Create";
            this.ArcNewAssignmentNextButton.UseVisualStyleBackColor = true;
            this.ArcNewAssignmentNextButton.Click += new System.EventHandler(this.ArcNewAssignmentNextButton_Click);
            // 
            // ArcNewAssignmentLabel
            // 
            this.ArcNewAssignmentLabel.Location = new System.Drawing.Point(102, 0);
            this.ArcNewAssignmentLabel.Name = "ArcNewAssignmentLabel";
            this.ArcNewAssignmentLabel.Size = new System.Drawing.Size(273, 58);
            this.ArcNewAssignmentLabel.TabIndex = 2;
            this.ArcNewAssignmentLabel.Text = "Fill in the following information to create a new assignment:";
            this.ArcNewAssignmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArcReportLocationPanel
            // 
            this.ArcReportLocationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArcReportLocationPanel.Controls.Add(this.ArcReportPreviousButton);
            this.ArcReportLocationPanel.Controls.Add(this.ArcReportLocationButton2);
            this.ArcReportLocationPanel.Controls.Add(this.ArcReportLocationTextBox);
            this.ArcReportLocationPanel.Controls.Add(this.ArcReportLocationLabel);
            this.ArcReportLocationPanel.Controls.Add(this.ArcReportNextButton);
            this.ArcReportLocationPanel.Controls.Add(this.ArcViewGradeReportLabel);
            this.ArcReportLocationPanel.Location = new System.Drawing.Point(0, 192);
            this.ArcReportLocationPanel.Name = "ArcReportLocationPanel";
            this.ArcReportLocationPanel.Size = new System.Drawing.Size(478, 352);
            this.ArcReportLocationPanel.TabIndex = 19;
            // 
            // ArcReportPreviousButton
            // 
            this.ArcReportPreviousButton.Location = new System.Drawing.Point(236, 306);
            this.ArcReportPreviousButton.Name = "ArcReportPreviousButton";
            this.ArcReportPreviousButton.Size = new System.Drawing.Size(112, 34);
            this.ArcReportPreviousButton.TabIndex = 18;
            this.ArcReportPreviousButton.Text = "Previous";
            this.ArcReportPreviousButton.UseVisualStyleBackColor = true;
            this.ArcReportPreviousButton.Click += new System.EventHandler(this.ArcReportPreviousButton_Click);
            // 
            // ArcReportLocationButton2
            // 
            this.ArcReportLocationButton2.Location = new System.Drawing.Point(343, 90);
            this.ArcReportLocationButton2.Name = "ArcReportLocationButton2";
            this.ArcReportLocationButton2.Size = new System.Drawing.Size(128, 34);
            this.ArcReportLocationButton2.TabIndex = 12;
            this.ArcReportLocationButton2.Text = "Browse...";
            this.ArcReportLocationButton2.UseVisualStyleBackColor = true;
            this.ArcReportLocationButton2.Click += new System.EventHandler(this.ArcReportLocationButton2_Click);
            // 
            // ArcReportLocationTextBox
            // 
            this.ArcReportLocationTextBox.Location = new System.Drawing.Point(12, 92);
            this.ArcReportLocationTextBox.Name = "ArcReportLocationTextBox";
            this.ArcReportLocationTextBox.Size = new System.Drawing.Size(320, 31);
            this.ArcReportLocationTextBox.TabIndex = 11;
            // 
            // ArcReportLocationLabel
            // 
            this.ArcReportLocationLabel.AutoSize = true;
            this.ArcReportLocationLabel.Location = new System.Drawing.Point(12, 64);
            this.ArcReportLocationLabel.Name = "ArcReportLocationLabel";
            this.ArcReportLocationLabel.Size = new System.Drawing.Size(248, 25);
            this.ArcReportLocationLabel.TabIndex = 10;
            this.ArcReportLocationLabel.Text = "Assignment Storage Location:";
            // 
            // ArcReportNextButton
            // 
            this.ArcReportNextButton.Location = new System.Drawing.Point(354, 306);
            this.ArcReportNextButton.Name = "ArcReportNextButton";
            this.ArcReportNextButton.Size = new System.Drawing.Size(112, 34);
            this.ArcReportNextButton.TabIndex = 3;
            this.ArcReportNextButton.Text = "Next";
            this.ArcReportNextButton.UseVisualStyleBackColor = true;
            this.ArcReportNextButton.Click += new System.EventHandler(this.ArcReportNextButton_Click);
            // 
            // ArcViewGradeReportLabel
            // 
            this.ArcViewGradeReportLabel.Location = new System.Drawing.Point(86, -4);
            this.ArcViewGradeReportLabel.Name = "ArcViewGradeReportLabel";
            this.ArcViewGradeReportLabel.Size = new System.Drawing.Size(319, 58);
            this.ArcViewGradeReportLabel.TabIndex = 2;
            this.ArcViewGradeReportLabel.Text = "Select the location of the assignment to pull the grade report:";
            this.ArcViewGradeReportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArcReportPanel
            // 
            this.ArcReportPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArcReportPanel.Controls.Add(this.ArcReportTextBox);
            this.ArcReportPanel.Controls.Add(this.ArcDoneButton);
            this.ArcReportPanel.Location = new System.Drawing.Point(0, 192);
            this.ArcReportPanel.Name = "ArcReportPanel";
            this.ArcReportPanel.Size = new System.Drawing.Size(478, 352);
            this.ArcReportPanel.TabIndex = 20;
            // 
            // ArcReportTextBox
            // 
            this.ArcReportTextBox.Location = new System.Drawing.Point(12, 12);
            this.ArcReportTextBox.Multiline = true;
            this.ArcReportTextBox.Name = "ArcReportTextBox";
            this.ArcReportTextBox.ReadOnly = true;
            this.ArcReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArcReportTextBox.Size = new System.Drawing.Size(454, 288);
            this.ArcReportTextBox.TabIndex = 4;
            // 
            // ArcDoneButton
            // 
            this.ArcDoneButton.Location = new System.Drawing.Point(354, 306);
            this.ArcDoneButton.Name = "ArcDoneButton";
            this.ArcDoneButton.Size = new System.Drawing.Size(112, 34);
            this.ArcDoneButton.TabIndex = 3;
            this.ArcDoneButton.Text = "Done";
            this.ArcDoneButton.UseVisualStyleBackColor = true;
            this.ArcDoneButton.Click += new System.EventHandler(this.ArcDoneButton_Click);
            // 
            // ArcAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 544);
            this.Controls.Add(this.ArcLogo);
            this.Controls.Add(this.ArcMainPanel);
            this.Controls.Add(this.ArcNewAssignmentPanel);
            this.Controls.Add(this.ArcReportPanel);
            this.Controls.Add(this.ArcReportLocationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArcAdminView";
            this.Text = "ArcticAG Admin";
            ((System.ComponentModel.ISupportInitialize)(this.ArcLogo)).EndInit();
            this.ArcRadioOptionsPanel.ResumeLayout(false);
            this.ArcRadioOptionsPanel.PerformLayout();
            this.ArcMainPanel.ResumeLayout(false);
            this.ArcNewAssignmentPanel.ResumeLayout(false);
            this.ArcNewAssignmentPanel.PerformLayout();
            this.ArcReportLocationPanel.ResumeLayout(false);
            this.ArcReportLocationPanel.PerformLayout();
            this.ArcReportPanel.ResumeLayout(false);
            this.ArcReportPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ArcLogo;
        private Panel ArcRadioOptionsPanel;
        private RadioButton ArcGradeReportRadio;
        private RadioButton ArcNewAssignmentRadio;
        private Label ArcMainLabel;
        private Button ArcMainNextButton;
        private Panel ArcMainPanel;
        private Panel ArcNewAssignmentPanel;
        private Button ArcNewAssignmentNextButton;
        private Label ArcNewAssignmentLabel;
        private Label ArcAssignmentLocationLabel;
        private TextBox ArcAssignmentLocationTextBox;
        private Button ArcAssignmentLocationButton;
        private TextBox ArcAssignmentNameTextBox;
        private Label ArcAssignmentNameLabel;
        private Button ArcSourceDirectoryButton;
        private TextBox ArcSourceDirectoryTextBox;
        private Label ArcSourceDirectoryLabel;
        private Button ArcNewAssignmentPreviousButton;
        private Panel ArcReportLocationPanel;
        private Button ArcReportPreviousButton;
        private TextBox ArcReportLocationTextBox;
        private Label ArcReportLocationLabel;
        private Button ArcReportNextButton;
        private Label ArcViewGradeReportLabel;
        private Panel ArcReportPanel;
        private Button ArcDoneButton;
        private Button ArcReportLocationButton2;
        private TextBox ArcReportTextBox;
    }
}