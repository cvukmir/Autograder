namespace ArcticAG_Client
{
    partial class ArcClientView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcClientView));
            this.ArcLogo = new System.Windows.Forms.PictureBox();
            this.ArcMainPanel = new System.Windows.Forms.Panel();
            this.ArcIP4TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ArcIP3TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ArcIP2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ArcIP1TextBox = new System.Windows.Forms.TextBox();
            this.ArcServerLabel = new System.Windows.Forms.Label();
            this.ArcUserNameLabel = new System.Windows.Forms.Label();
            this.ArcPassewordLabel = new System.Windows.Forms.Label();
            this.ArcPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ArcLoginButton = new System.Windows.Forms.Button();
            this.ArcUserNameTextBox = new System.Windows.Forms.TextBox();
            this.ArcInfoLabel = new System.Windows.Forms.Label();
            this.ArcPortNumberTextBox = new System.Windows.Forms.TextBox();
            this.ArcPortNumberLabel = new System.Windows.Forms.Label();
            this.ArcRunningPanel = new System.Windows.Forms.Panel();
            this.ArcRunReturnedGradeLabel = new System.Windows.Forms.Label();
            this.ArcRunAssignmentNameLabel = new System.Windows.Forms.Label();
            this.ArcRunAssignmentLabel = new System.Windows.Forms.Label();
            this.ArcRunGradeLabel = new System.Windows.Forms.Label();
            this.ArcFinishButton = new System.Windows.Forms.Button();
            this.ArcStatusLabel = new System.Windows.Forms.Label();
            this.ArcProgressBar = new System.Windows.Forms.ProgressBar();
            this.ArcAssignmentPanel = new System.Windows.Forms.Panel();
            this.ArcBrowseButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ArcAssignmentNameComboBox = new System.Windows.Forms.ComboBox();
            this.ArcDirectoryLabel = new System.Windows.Forms.Label();
            this.ArcNextButton1 = new System.Windows.Forms.Button();
            this.ArcDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ArcPreviousButton3 = new System.Windows.Forms.Button();
            this.ArcConfirmButton = new System.Windows.Forms.Button();
            this.ArcInfoLabel2 = new System.Windows.Forms.Label();
            this.ArcConfirmPanel = new System.Windows.Forms.Panel();
            this.ArcAssignmentNameTextBox2 = new System.Windows.Forms.TextBox();
            this.ArcAssignmentNameLabel2 = new System.Windows.Forms.Label();
            this.ArcDirectoryLabel2 = new System.Windows.Forms.Label();
            this.ArcDirectoryTextBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArcLogo)).BeginInit();
            this.ArcMainPanel.SuspendLayout();
            this.ArcRunningPanel.SuspendLayout();
            this.ArcAssignmentPanel.SuspendLayout();
            this.ArcConfirmPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArcLogo
            // 
            this.ArcLogo.BackgroundImage = global::ArcticAG_Client.Properties.Resources.ArcitcLogo;
            this.ArcLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ArcLogo.Location = new System.Drawing.Point(125, 10);
            this.ArcLogo.Name = "ArcLogo";
            this.ArcLogo.Size = new System.Drawing.Size(250, 150);
            this.ArcLogo.TabIndex = 0;
            this.ArcLogo.TabStop = false;
            // 
            // ArcMainPanel
            // 
            this.ArcMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArcMainPanel.Controls.Add(this.ArcIP4TextBox);
            this.ArcMainPanel.Controls.Add(this.label3);
            this.ArcMainPanel.Controls.Add(this.ArcIP3TextBox);
            this.ArcMainPanel.Controls.Add(this.label2);
            this.ArcMainPanel.Controls.Add(this.ArcIP2TextBox);
            this.ArcMainPanel.Controls.Add(this.label1);
            this.ArcMainPanel.Controls.Add(this.ArcIP1TextBox);
            this.ArcMainPanel.Controls.Add(this.ArcServerLabel);
            this.ArcMainPanel.Controls.Add(this.ArcUserNameLabel);
            this.ArcMainPanel.Controls.Add(this.ArcPassewordLabel);
            this.ArcMainPanel.Controls.Add(this.ArcPasswordTextBox);
            this.ArcMainPanel.Controls.Add(this.ArcLoginButton);
            this.ArcMainPanel.Controls.Add(this.ArcUserNameTextBox);
            this.ArcMainPanel.Controls.Add(this.ArcInfoLabel);
            this.ArcMainPanel.Controls.Add(this.ArcPortNumberTextBox);
            this.ArcMainPanel.Controls.Add(this.ArcPortNumberLabel);
            this.ArcMainPanel.Location = new System.Drawing.Point(0, 192);
            this.ArcMainPanel.Name = "ArcMainPanel";
            this.ArcMainPanel.Size = new System.Drawing.Size(478, 352);
            this.ArcMainPanel.TabIndex = 1;
            // 
            // ArcIP4TextBox
            // 
            this.ArcIP4TextBox.Location = new System.Drawing.Point(201, 110);
            this.ArcIP4TextBox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ArcIP4TextBox.MaxLength = 3;
            this.ArcIP4TextBox.Name = "ArcIP4TextBox";
            this.ArcIP4TextBox.PlaceholderText = "999";
            this.ArcIP4TextBox.ShortcutsEnabled = false;
            this.ArcIP4TextBox.Size = new System.Drawing.Size(43, 31);
            this.ArcIP4TextBox.TabIndex = 5;
            this.ArcIP4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArcIP4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ArcIPValueTextbox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = ".";
            // 
            // ArcIP3TextBox
            // 
            this.ArcIP3TextBox.Location = new System.Drawing.Point(138, 110);
            this.ArcIP3TextBox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ArcIP3TextBox.MaxLength = 3;
            this.ArcIP3TextBox.Name = "ArcIP3TextBox";
            this.ArcIP3TextBox.PlaceholderText = "999";
            this.ArcIP3TextBox.ShortcutsEnabled = false;
            this.ArcIP3TextBox.Size = new System.Drawing.Size(43, 31);
            this.ArcIP3TextBox.TabIndex = 4;
            this.ArcIP3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArcIP3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ArcIPValueTextbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = ".";
            // 
            // ArcIP2TextBox
            // 
            this.ArcIP2TextBox.Location = new System.Drawing.Point(75, 110);
            this.ArcIP2TextBox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.ArcIP2TextBox.MaxLength = 3;
            this.ArcIP2TextBox.Name = "ArcIP2TextBox";
            this.ArcIP2TextBox.PlaceholderText = "999";
            this.ArcIP2TextBox.ShortcutsEnabled = false;
            this.ArcIP2TextBox.Size = new System.Drawing.Size(43, 31);
            this.ArcIP2TextBox.TabIndex = 3;
            this.ArcIP2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArcIP2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ArcIPValueTextbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = ".";
            // 
            // ArcIP1TextBox
            // 
            this.ArcIP1TextBox.Location = new System.Drawing.Point(12, 110);
            this.ArcIP1TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ArcIP1TextBox.MaxLength = 3;
            this.ArcIP1TextBox.Name = "ArcIP1TextBox";
            this.ArcIP1TextBox.PlaceholderText = "999";
            this.ArcIP1TextBox.ShortcutsEnabled = false;
            this.ArcIP1TextBox.Size = new System.Drawing.Size(43, 31);
            this.ArcIP1TextBox.TabIndex = 2;
            this.ArcIP1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArcIP1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ArcIPValueTextbox_KeyPress);
            // 
            // ArcServerLabel
            // 
            this.ArcServerLabel.AutoSize = true;
            this.ArcServerLabel.Location = new System.Drawing.Point(12, 82);
            this.ArcServerLabel.Name = "ArcServerLabel";
            this.ArcServerLabel.Size = new System.Drawing.Size(136, 25);
            this.ArcServerLabel.TabIndex = 8;
            this.ArcServerLabel.Text = "Server IP (IPV4):";
            // 
            // ArcUserNameLabel
            // 
            this.ArcUserNameLabel.AutoSize = true;
            this.ArcUserNameLabel.Location = new System.Drawing.Point(12, 144);
            this.ArcUserNameLabel.Name = "ArcUserNameLabel";
            this.ArcUserNameLabel.Size = new System.Drawing.Size(103, 25);
            this.ArcUserNameLabel.TabIndex = 7;
            this.ArcUserNameLabel.Text = "User Name:";
            // 
            // ArcPassewordLabel
            // 
            this.ArcPassewordLabel.AutoSize = true;
            this.ArcPassewordLabel.Location = new System.Drawing.Point(12, 206);
            this.ArcPassewordLabel.Name = "ArcPassewordLabel";
            this.ArcPassewordLabel.Size = new System.Drawing.Size(91, 25);
            this.ArcPassewordLabel.TabIndex = 6;
            this.ArcPassewordLabel.Text = "Password:";
            // 
            // ArcPasswordTextBox
            // 
            this.ArcPasswordTextBox.Location = new System.Drawing.Point(12, 234);
            this.ArcPasswordTextBox.MaxLength = 20;
            this.ArcPasswordTextBox.Name = "ArcPasswordTextBox";
            this.ArcPasswordTextBox.PasswordChar = '*';
            this.ArcPasswordTextBox.Size = new System.Drawing.Size(320, 31);
            this.ArcPasswordTextBox.TabIndex = 9;
            this.ArcPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ArcLoginButton
            // 
            this.ArcLoginButton.Location = new System.Drawing.Point(354, 306);
            this.ArcLoginButton.Name = "ArcLoginButton";
            this.ArcLoginButton.Size = new System.Drawing.Size(112, 34);
            this.ArcLoginButton.TabIndex = 1;
            this.ArcLoginButton.Text = "Login";
            this.ArcLoginButton.UseVisualStyleBackColor = true;
            this.ArcLoginButton.Click += new System.EventHandler(this.ArcLoginButton_Click);
            // 
            // ArcUserNameTextBox
            // 
            this.ArcUserNameTextBox.Location = new System.Drawing.Point(12, 172);
            this.ArcUserNameTextBox.MaxLength = 20;
            this.ArcUserNameTextBox.Name = "ArcUserNameTextBox";
            this.ArcUserNameTextBox.Size = new System.Drawing.Size(320, 31);
            this.ArcUserNameTextBox.TabIndex = 7;
            // 
            // ArcInfoLabel
            // 
            this.ArcInfoLabel.Location = new System.Drawing.Point(51, 0);
            this.ArcInfoLabel.Name = "ArcInfoLabel";
            this.ArcInfoLabel.Size = new System.Drawing.Size(367, 52);
            this.ArcInfoLabel.TabIndex = 10;
            this.ArcInfoLabel.Text = "Enter the server IP/port and then enter your Username and Pasword below.";
            this.ArcInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArcPortNumberTextBox
            // 
            this.ArcPortNumberTextBox.Location = new System.Drawing.Point(354, 110);
            this.ArcPortNumberTextBox.MaxLength = 5;
            this.ArcPortNumberTextBox.Name = "ArcPortNumberTextBox";
            this.ArcPortNumberTextBox.PlaceholderText = "99999";
            this.ArcPortNumberTextBox.ShortcutsEnabled = false;
            this.ArcPortNumberTextBox.Size = new System.Drawing.Size(64, 31);
            this.ArcPortNumberTextBox.TabIndex = 6;
            this.ArcPortNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArcPortNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ArcPortNumberTextBox_KeyPress);
            // 
            // ArcPortNumberLabel
            // 
            this.ArcPortNumberLabel.AutoSize = true;
            this.ArcPortNumberLabel.Location = new System.Drawing.Point(354, 82);
            this.ArcPortNumberLabel.Name = "ArcPortNumberLabel";
            this.ArcPortNumberLabel.Size = new System.Drawing.Size(48, 25);
            this.ArcPortNumberLabel.TabIndex = 19;
            this.ArcPortNumberLabel.Text = "Port:";
            // 
            // ArcRunningPanel
            // 
            this.ArcRunningPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArcRunningPanel.Controls.Add(this.ArcRunReturnedGradeLabel);
            this.ArcRunningPanel.Controls.Add(this.ArcRunAssignmentNameLabel);
            this.ArcRunningPanel.Controls.Add(this.ArcRunAssignmentLabel);
            this.ArcRunningPanel.Controls.Add(this.ArcRunGradeLabel);
            this.ArcRunningPanel.Controls.Add(this.ArcFinishButton);
            this.ArcRunningPanel.Controls.Add(this.ArcStatusLabel);
            this.ArcRunningPanel.Controls.Add(this.ArcProgressBar);
            this.ArcRunningPanel.Location = new System.Drawing.Point(0, 192);
            this.ArcRunningPanel.Name = "ArcRunningPanel";
            this.ArcRunningPanel.Size = new System.Drawing.Size(478, 352);
            this.ArcRunningPanel.TabIndex = 35;
            this.ArcRunningPanel.Visible = false;
            // 
            // ArcRunReturnedGradeLabel
            // 
            this.ArcRunReturnedGradeLabel.AutoSize = true;
            this.ArcRunReturnedGradeLabel.Location = new System.Drawing.Point(133, 206);
            this.ArcRunReturnedGradeLabel.Name = "ArcRunReturnedGradeLabel";
            this.ArcRunReturnedGradeLabel.Size = new System.Drawing.Size(84, 25);
            this.ArcRunReturnedGradeLabel.TabIndex = 6;
            this.ArcRunReturnedGradeLabel.Text = "Waiting...";
            // 
            // ArcRunAssignmentNameLabel
            // 
            this.ArcRunAssignmentNameLabel.AutoSize = true;
            this.ArcRunAssignmentNameLabel.Location = new System.Drawing.Point(133, 144);
            this.ArcRunAssignmentNameLabel.Name = "ArcRunAssignmentNameLabel";
            this.ArcRunAssignmentNameLabel.Size = new System.Drawing.Size(65, 25);
            this.ArcRunAssignmentNameLabel.TabIndex = 5;
            this.ArcRunAssignmentNameLabel.Text = "Assign";
            // 
            // ArcRunAssignmentLabel
            // 
            this.ArcRunAssignmentLabel.AutoSize = true;
            this.ArcRunAssignmentLabel.Location = new System.Drawing.Point(12, 144);
            this.ArcRunAssignmentLabel.Name = "ArcRunAssignmentLabel";
            this.ArcRunAssignmentLabel.Size = new System.Drawing.Size(115, 25);
            this.ArcRunAssignmentLabel.TabIndex = 4;
            this.ArcRunAssignmentLabel.Text = "Assignment: ";
            // 
            // ArcRunGradeLabel
            // 
            this.ArcRunGradeLabel.AutoSize = true;
            this.ArcRunGradeLabel.Location = new System.Drawing.Point(10, 206);
            this.ArcRunGradeLabel.Name = "ArcRunGradeLabel";
            this.ArcRunGradeLabel.Size = new System.Drawing.Size(63, 25);
            this.ArcRunGradeLabel.TabIndex = 3;
            this.ArcRunGradeLabel.Text = "Grade:";
            // 
            // ArcFinishButton
            // 
            this.ArcFinishButton.Enabled = false;
            this.ArcFinishButton.Location = new System.Drawing.Point(359, 306);
            this.ArcFinishButton.Name = "ArcFinishButton";
            this.ArcFinishButton.Size = new System.Drawing.Size(112, 34);
            this.ArcFinishButton.TabIndex = 2;
            this.ArcFinishButton.Text = "Finish";
            this.ArcFinishButton.UseVisualStyleBackColor = true;
            this.ArcFinishButton.Click += new System.EventHandler(this.ArcFinishButton_Click);
            // 
            // ArcStatusLabel
            // 
            this.ArcStatusLabel.AutoSize = true;
            this.ArcStatusLabel.Location = new System.Drawing.Point(10, 52);
            this.ArcStatusLabel.Name = "ArcStatusLabel";
            this.ArcStatusLabel.Size = new System.Drawing.Size(91, 25);
            this.ArcStatusLabel.TabIndex = 1;
            this.ArcStatusLabel.Text = "Initializing";
            // 
            // ArcProgressBar
            // 
            this.ArcProgressBar.Location = new System.Drawing.Point(12, 80);
            this.ArcProgressBar.Name = "ArcProgressBar";
            this.ArcProgressBar.Size = new System.Drawing.Size(454, 34);
            this.ArcProgressBar.TabIndex = 0;
            // 
            // ArcAssignmentPanel
            // 
            this.ArcAssignmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArcAssignmentPanel.Controls.Add(this.ArcBrowseButton);
            this.ArcAssignmentPanel.Controls.Add(this.label7);
            this.ArcAssignmentPanel.Controls.Add(this.ArcAssignmentNameComboBox);
            this.ArcAssignmentPanel.Controls.Add(this.ArcDirectoryLabel);
            this.ArcAssignmentPanel.Controls.Add(this.ArcNextButton1);
            this.ArcAssignmentPanel.Controls.Add(this.ArcDirectoryTextBox);
            this.ArcAssignmentPanel.Controls.Add(this.label13);
            this.ArcAssignmentPanel.Location = new System.Drawing.Point(0, 192);
            this.ArcAssignmentPanel.Name = "ArcAssignmentPanel";
            this.ArcAssignmentPanel.Size = new System.Drawing.Size(478, 352);
            this.ArcAssignmentPanel.TabIndex = 26;
            // 
            // ArcBrowseButton
            // 
            this.ArcBrowseButton.Location = new System.Drawing.Point(338, 150);
            this.ArcBrowseButton.Name = "ArcBrowseButton";
            this.ArcBrowseButton.Size = new System.Drawing.Size(128, 34);
            this.ArcBrowseButton.TabIndex = 13;
            this.ArcBrowseButton.Text = "Browse...";
            this.ArcBrowseButton.UseVisualStyleBackColor = true;
            this.ArcBrowseButton.Click += new System.EventHandler(this.ArcBrowseButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Assignment:";
            // 
            // ArcAssignmentNameComboBox
            // 
            this.ArcAssignmentNameComboBox.FormattingEnabled = true;
            this.ArcAssignmentNameComboBox.Location = new System.Drawing.Point(12, 85);
            this.ArcAssignmentNameComboBox.Name = "ArcAssignmentNameComboBox";
            this.ArcAssignmentNameComboBox.Size = new System.Drawing.Size(320, 33);
            this.ArcAssignmentNameComboBox.TabIndex = 11;
            // 
            // ArcDirectoryLabel
            // 
            this.ArcDirectoryLabel.AutoSize = true;
            this.ArcDirectoryLabel.Location = new System.Drawing.Point(12, 121);
            this.ArcDirectoryLabel.Name = "ArcDirectoryLabel";
            this.ArcDirectoryLabel.Size = new System.Drawing.Size(88, 25);
            this.ArcDirectoryLabel.TabIndex = 7;
            this.ArcDirectoryLabel.Text = "Directory:";
            // 
            // ArcNextButton1
            // 
            this.ArcNextButton1.Location = new System.Drawing.Point(354, 306);
            this.ArcNextButton1.Name = "ArcNextButton1";
            this.ArcNextButton1.Size = new System.Drawing.Size(112, 34);
            this.ArcNextButton1.TabIndex = 1;
            this.ArcNextButton1.Text = "Next";
            this.ArcNextButton1.UseVisualStyleBackColor = true;
            this.ArcNextButton1.Click += new System.EventHandler(this.ArcNextButton1_Click);
            // 
            // ArcDirectoryTextBox
            // 
            this.ArcDirectoryTextBox.Location = new System.Drawing.Point(12, 152);
            this.ArcDirectoryTextBox.Name = "ArcDirectoryTextBox";
            this.ArcDirectoryTextBox.Size = new System.Drawing.Size(320, 31);
            this.ArcDirectoryTextBox.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(51, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(367, 54);
            this.label13.TabIndex = 10;
            this.label13.Text = "Select an assignment and your assignment zip to upload below.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArcPreviousButton3
            // 
            this.ArcPreviousButton3.Location = new System.Drawing.Point(236, 306);
            this.ArcPreviousButton3.Name = "ArcPreviousButton3";
            this.ArcPreviousButton3.Size = new System.Drawing.Size(112, 34);
            this.ArcPreviousButton3.TabIndex = 1;
            this.ArcPreviousButton3.Text = "Previous";
            this.ArcPreviousButton3.UseVisualStyleBackColor = true;
            this.ArcPreviousButton3.Click += new System.EventHandler(this.ArcPreviousButton_Click);
            // 
            // ArcConfirmButton
            // 
            this.ArcConfirmButton.Location = new System.Drawing.Point(354, 306);
            this.ArcConfirmButton.Name = "ArcConfirmButton";
            this.ArcConfirmButton.Size = new System.Drawing.Size(112, 34);
            this.ArcConfirmButton.TabIndex = 2;
            this.ArcConfirmButton.Text = "Confirm";
            this.ArcConfirmButton.UseVisualStyleBackColor = true;
            this.ArcConfirmButton.Click += new System.EventHandler(this.ArcConfirmButton_Click);
            // 
            // ArcInfoLabel2
            // 
            this.ArcInfoLabel2.Location = new System.Drawing.Point(57, -2);
            this.ArcInfoLabel2.Name = "ArcInfoLabel2";
            this.ArcInfoLabel2.Size = new System.Drawing.Size(367, 56);
            this.ArcInfoLabel2.TabIndex = 16;
            this.ArcInfoLabel2.Text = "Confirm that the following selections are correct.";
            this.ArcInfoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArcConfirmPanel
            // 
            this.ArcConfirmPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArcConfirmPanel.Controls.Add(this.ArcAssignmentNameTextBox2);
            this.ArcConfirmPanel.Controls.Add(this.ArcAssignmentNameLabel2);
            this.ArcConfirmPanel.Controls.Add(this.ArcDirectoryLabel2);
            this.ArcConfirmPanel.Controls.Add(this.ArcDirectoryTextBox2);
            this.ArcConfirmPanel.Controls.Add(this.ArcInfoLabel2);
            this.ArcConfirmPanel.Controls.Add(this.ArcConfirmButton);
            this.ArcConfirmPanel.Controls.Add(this.ArcPreviousButton3);
            this.ArcConfirmPanel.Location = new System.Drawing.Point(0, 192);
            this.ArcConfirmPanel.Name = "ArcConfirmPanel";
            this.ArcConfirmPanel.Size = new System.Drawing.Size(478, 352);
            this.ArcConfirmPanel.TabIndex = 2;
            this.ArcConfirmPanel.Visible = false;
            // 
            // ArcAssignmentNameTextBox2
            // 
            this.ArcAssignmentNameTextBox2.Enabled = false;
            this.ArcAssignmentNameTextBox2.Location = new System.Drawing.Point(12, 85);
            this.ArcAssignmentNameTextBox2.Name = "ArcAssignmentNameTextBox2";
            this.ArcAssignmentNameTextBox2.ReadOnly = true;
            this.ArcAssignmentNameTextBox2.Size = new System.Drawing.Size(320, 31);
            this.ArcAssignmentNameTextBox2.TabIndex = 21;
            // 
            // ArcAssignmentNameLabel2
            // 
            this.ArcAssignmentNameLabel2.AutoSize = true;
            this.ArcAssignmentNameLabel2.Location = new System.Drawing.Point(12, 57);
            this.ArcAssignmentNameLabel2.Name = "ArcAssignmentNameLabel2";
            this.ArcAssignmentNameLabel2.Size = new System.Drawing.Size(110, 25);
            this.ArcAssignmentNameLabel2.TabIndex = 20;
            this.ArcAssignmentNameLabel2.Text = "Assignment:";
            // 
            // ArcDirectoryLabel2
            // 
            this.ArcDirectoryLabel2.AutoSize = true;
            this.ArcDirectoryLabel2.Location = new System.Drawing.Point(12, 124);
            this.ArcDirectoryLabel2.Name = "ArcDirectoryLabel2";
            this.ArcDirectoryLabel2.Size = new System.Drawing.Size(88, 25);
            this.ArcDirectoryLabel2.TabIndex = 17;
            this.ArcDirectoryLabel2.Text = "Directory:";
            // 
            // ArcDirectoryTextBox2
            // 
            this.ArcDirectoryTextBox2.Enabled = false;
            this.ArcDirectoryTextBox2.Location = new System.Drawing.Point(12, 152);
            this.ArcDirectoryTextBox2.Name = "ArcDirectoryTextBox2";
            this.ArcDirectoryTextBox2.ReadOnly = true;
            this.ArcDirectoryTextBox2.Size = new System.Drawing.Size(320, 31);
            this.ArcDirectoryTextBox2.TabIndex = 18;
            // 
            // ArcClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 540);
            this.Controls.Add(this.ArcLogo);
            this.Controls.Add(this.ArcAssignmentPanel);
            this.Controls.Add(this.ArcMainPanel);
            this.Controls.Add(this.ArcRunningPanel);
            this.Controls.Add(this.ArcConfirmPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArcClientView";
            this.Text = "ArcticAG Client";
            ((System.ComponentModel.ISupportInitialize)(this.ArcLogo)).EndInit();
            this.ArcMainPanel.ResumeLayout(false);
            this.ArcMainPanel.PerformLayout();
            this.ArcRunningPanel.ResumeLayout(false);
            this.ArcRunningPanel.PerformLayout();
            this.ArcAssignmentPanel.ResumeLayout(false);
            this.ArcAssignmentPanel.PerformLayout();
            this.ArcConfirmPanel.ResumeLayout(false);
            this.ArcConfirmPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ArcLogo;
        private Panel ArcMainPanel;
        private TextBox ArcIP1TextBox;
        private Label ArcServerLabel;
        private Label ArcUserNameLabel;
        private Button ArcLoginButton;
        private TextBox ArcUserNameTextBox;
        private Label ArcInfoLabel;
        private Label ArcPortNumberLabel;
        private TextBox ArcPortNumberTextBox;
        private Label label1;
        private TextBox ArcIP2TextBox;
        private TextBox ArcIP4TextBox;
        private Label label3;
        private TextBox ArcIP3TextBox;
        private Label label2;
        private Panel ArcRunningPanel;
        private ProgressBar ArcProgressBar;
        private Label ArcStatusLabel;
        private Button ArcFinishButton;
        private Label ArcRunGradeLabel;
        private Label ArcRunAssignmentLabel;
        private Label ArcRunReturnedGradeLabel;
        private Label ArcRunAssignmentNameLabel;
        private Panel ArcAssignmentPanel;
        private Label ArcDirectoryLabel;
        private Button ArcNextButton1;
        private TextBox ArcDirectoryTextBox;
        private Label label13;
        private ComboBox ArcAssignmentNameComboBox;
        private Button ArcBrowseButton;
        private Label label7;
        private Label ArcPassewordLabel;
        private TextBox ArcPasswordTextBox;
        private Button ArcPreviousButton3;
        private Button ArcConfirmButton;
        private Label ArcInfoLabel2;
        private Panel ArcConfirmPanel;
        private Label ArcAssignmentNameLabel2;
        private Label ArcDirectoryLabel2;
        private TextBox ArcDirectoryTextBox2;
        private TextBox ArcAssignmentNameTextBox2;
    }
}