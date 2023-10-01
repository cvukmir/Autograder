using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcticAG_Admin
{
    public partial class ArcAdminView : Form
    {
        public ArcAdminView()
        {
            InitializeComponent();
            CenterToScreen();

            MaximizeBox = false;

                    ArcReportPanel.Hide();
             ArcNewAssignmentPanel.Hide();
            ArcReportLocationPanel.Hide();
        }

        private void ArcAssignmentLocationButton_Click(object sender, EventArgs e)
        {
            ArcAssignmentLocationTextBox.Text = ArcFileHandler.getDirectory();
        }

        private void ArcDoneButton_Click(object sender, EventArgs e)
        {
            // Return to main menu.
            ArcReportLocationTextBox.Text = string.Empty;

            ArcReportPanel.Hide();
            ArcMainPanel.Show();
        }

        private void ArcMainNextButton_Click(object sender, EventArgs e)
        {
            // Go to the menu that matches the option selected.
            if (ArcNewAssignmentRadio.Checked)
            {
                ArcAssignmentLocationTextBox.Clear();
                ArcAssignmentNameTextBox.Clear();
                ArcSourceDirectoryTextBox.Clear();
                ArcNewAssignmentPanel.Show();
                ArcMainPanel.Hide();
            }
            else if (ArcGradeReportRadio.Checked)
            {
                ArcReportLocationTextBox.Clear();
                ArcReportLocationPanel.Show();
                ArcMainPanel.Hide();
            }
        }

        private void ArcNewAssignmentNextButton_Click(object sender, EventArgs e)
        {
            // Create the new assignment
            try
            {
                ArcFileHandler.createAssignmentDirectory(ArcAssignmentNameTextBox.Text,
                                                         ArcAssignmentLocationTextBox.Text,
                                                         ArcSourceDirectoryTextBox.Text);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Assingment source directory not found.");
                ArcAssignmentNameTextBox.Clear();
                ArcAssignmentLocationTextBox.Clear();
                ArcSourceDirectoryTextBox.Clear();

                ArcMainPanel.Show();
                ArcNewAssignmentPanel.Hide();
                ArcReportLocationPanel.Hide();
                return;
            }
            catch (InvalidDataException)
            {
                MessageBox.Show("Invalid character found in the directory name.");
                ArcAssignmentNameTextBox.Clear();
                ArcAssignmentLocationTextBox.Clear();
                ArcSourceDirectoryTextBox.Clear();

                ArcMainPanel.Show();
                ArcNewAssignmentPanel.Hide();
                ArcReportLocationPanel.Hide();
                return;
            }
            catch (ArcDirectoryAlreadyExistsException)
            {
                MessageBox.Show("Assignment already exists in this directory.");
                ArcAssignmentNameTextBox.Clear();
                ArcAssignmentLocationTextBox.Clear();
                ArcSourceDirectoryTextBox.Clear();

                ArcMainPanel.Show();
                ArcNewAssignmentPanel.Hide();
                ArcReportLocationPanel.Hide();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Critical exception when creating assignment directory.");
                ArcAssignmentNameTextBox.Clear();
                ArcAssignmentLocationTextBox.Clear();
                ArcSourceDirectoryTextBox.Clear();

                ArcMainPanel.Show();
                ArcNewAssignmentPanel.Hide();
                ArcReportLocationPanel.Hide();
                return;
            }

            // Assignment was sucessfully created, ask whether to quit or return to main menu.
            if (MessageBox.Show(ArcAssignmentNameTextBox.Text + " was created at " + ArcAssignmentLocationTextBox.Text + ". Would you like to quit?", "Sucess!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                ArcAssignmentNameTextBox.Clear();
                ArcAssignmentLocationTextBox.Clear();
                ArcSourceDirectoryTextBox.Clear();

                ArcMainPanel.Show();
                ArcNewAssignmentPanel.Hide();
                ArcReportLocationPanel.Hide();
            }
        }

        private void ArcNewAssignmentPreviousButton_Click(object sender, EventArgs e)
        {
            ArcMainPanel.Show();
            ArcNewAssignmentPanel.Hide();
        }

        private void ArcReportLocationButton2_Click(object sender, EventArgs e)
        {
            ArcReportLocationTextBox.Text = ArcFileHandler.getDirectory();
        }

        private void ArcReportNextButton_Click(object sender, EventArgs e)
        {
            // Show the grades for the selcted assignment.
            ArcReportTextBox.Text = string.Empty;
            List<string> gradeList = ArcFileHandler.getGrades(ArcReportLocationTextBox.Text, "STUDENT_GRADES");

            if (gradeList.Count() == 0)
            {
                ArcReportTextBox.Text = "No grades found.";
            }
            else
            {
                foreach (string grade in gradeList)
                {
                    ArcReportTextBox.Text += grade + "\n";
                }
            }

            ArcReportPanel.Show();
            ArcReportLocationPanel.Hide();
        }

        private void ArcReportPreviousButton_Click(object sender, EventArgs e)
        {
            // Return to the main menu
                      ArcMainPanel.Show();
            ArcReportLocationPanel.Hide();
        }

        private void ArcSourceDirectoryButton_Click(object sender, EventArgs e)
        {
            ArcSourceDirectoryTextBox.Text = ArcFileHandler.getDirectory();
        }
    }
}
