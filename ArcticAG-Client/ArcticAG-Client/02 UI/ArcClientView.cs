using ArcticAG_Client;
using System.Net;

namespace ArcticAG_Client
{
    public partial class ArcClientView : Form
    {
        public ArcClientView()
        {
            InitializeComponent();
            CenterToScreen();

            MinimizeBox = false;

            ArcAssignmentNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

               ArcConfirmPanel.Hide();
               ArcRunningPanel.Hide();
            ArcAssignmentPanel.Hide();
        }

        private void ArcBrowseButton_Click(object sender, EventArgs e)
        {
            ArcDirectoryTextBox.Text = ArcFileHandler.getZipFile();
        }

        private void ArcConfirmButton_Click(object sender, EventArgs e)
        {
            // Send the assignment to the autograder server.
            ArcRunReturnedGradeLabel.Text  = "Waiting...";
            ArcStatusLabel.Text            = "Initializing...";
            ArcRunAssignmentNameLabel.Text = ArcAssignmentNameTextBox2.Text;

            ArcRunningPanel.Show();
            ArcConfirmPanel.Hide();

            ArcTcpConnection serverConnection = new ArcTcpConnection();

            try
            {
                // Create the server connection
                ArcStatusLabel.Text = "Connecting...";
                serverConnection.initializeConnection(IPAddress.Parse(ArcIP1TextBox.Text + "." + 
                                                                      ArcIP2TextBox.Text + "." + 
                                                                      ArcIP3TextBox.Text + "." + 
                                                                      ArcIP4TextBox.Text), 
                                                                      int.Parse(ArcPortNumberTextBox.Text));

                // Send over the assignment zip
                ArcProgressBar.Value = 33;
                ArcStatusLabel.Text = "Processing...";
                double grade = serverConnection.sendData(ArcDirectoryTextBox2.Text, ArcAssignmentNameTextBox2.Text, ArcUserNameTextBox.Text);

                // Close connection
                ArcProgressBar.Value = 66;
                ArcStatusLabel.Text = "Closing...";
                serverConnection.closeConnection();
                
                // Finished!
                ArcProgressBar.Value    = 100;
                ArcStatusLabel.Text     = "Finished!";
                ArcFinishButton.Enabled = true;

                // Display grade
                if (grade < 0)
                {
                    ArcRunReturnedGradeLabel.Text = "Submission already made, file not graded.";
                }
                else
                {
                    ArcRunReturnedGradeLabel.Text = grade.ToString();
                }
            }
            catch (ArgumentNullException)
            {
                serverConnection.closeConnection();
                return;
            }
            catch (FormatException)
            {
                serverConnection.closeConnection();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Critical exception with executing program.");
                return;
            }
        }

        private void ArcFinishButton_Click(object sender, EventArgs e)
        {
            // Ask whether to return to main menu or close dialog.
            DialogResult dialogResult = MessageBox.Show("Do you want to submit another assignment?", "Close", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ArcFinishButton.Enabled = false;

                ArcAssignmentPanel.Show();
                   ArcRunningPanel.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                Close();
            }
        }

        private void ArcIPValueTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make sure only digits are input into this dialog.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ArcLoginButton_Click(object sender, EventArgs e)
        {
            // Attempt login to server.
            List<string> assignmentList = new List<string>();
            ArcTcpConnection serverConnection = new ArcTcpConnection();

            try
            {
                // Create connection to server.
                serverConnection.initializeConnection(IPAddress.Parse(ArcIP1TextBox.Text + "." +
                                                                      ArcIP2TextBox.Text + "." +
                                                                      ArcIP3TextBox.Text + "." +
                                                                      ArcIP4TextBox.Text),
                                                                      int.Parse(ArcPortNumberTextBox.Text));

                // Send over usernmane and password
                assignmentList = serverConnection.requestLogin(ArcUserNameTextBox.Text, ArcPasswordTextBox.Text);

                // Close the connection.
                serverConnection.closeConnection();
            }
            catch (ArgumentNullException)
            {
                serverConnection.closeConnection();
            }
            catch (FormatException)
            {
                serverConnection.closeConnection();
            }
            catch (ArcLoginConnectionErrorException)
            {
                serverConnection.closeConnection();
                MessageBox.Show("Could not login, please try again.");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Critical exception with login connection.");
                return;
            }

            // Login successful! Display assignments.
            ArcAssignmentNameComboBox.Items.Clear();
            foreach (string assignment in assignmentList)
            {
                ArcAssignmentNameComboBox.Items.Add(assignment);
            }

            ArcAssignmentPanel.Show();
                  ArcMainPanel.Hide();
        }

        private void ArcNextButton1_Click(object sender, EventArgs e)
        {
            // Validate and display the entered fields to the verification panel.
            string? assignmentName = ArcAssignmentNameComboBox.SelectedItem != null ? ArcAssignmentNameComboBox.SelectedItem.ToString() : null;
            string?       fileName = ArcDirectoryTextBox.Text;

            if (assignmentName == null)
            {
                MessageBox.Show("Please select an assignment");
                return;
            }
            else if (fileName == null || !File.Exists(fileName) || !fileName.EndsWith(".zip"))
            {
                MessageBox.Show("Select a valid zip file");
                return;
            }

            ArcAssignmentNameTextBox2.Text = assignmentName;
                 ArcDirectoryTextBox2.Text = fileName;

               ArcConfirmPanel.Show();
            ArcAssignmentPanel.Hide();
        }

        private void ArcPortNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make sure only a digit is input here
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ArcPreviousButton_Click(object sender, EventArgs e)
        {
            // Return to showing assignment panel.
            ArcAssignmentPanel.Show();
               ArcConfirmPanel.Hide();
        }
    }
}