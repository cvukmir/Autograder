using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGrader
{
    public partial class BaseView : Form
    {
        // Public Methods //
        public BaseView()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void _baseViewOpenInstructorFileButton_Click(object sender, EventArgs e)
        {
            FileHandler.getDirectory();
        }

        private void _baseViewOpenStudentFileButton_Click(object sender, EventArgs e)
        {
            FileHandler.getDirectory();
        }

        private void _baseViewRunAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._baseViewConsoleTextBox.AppendText(ExecuteProgram.executeAllPrograms("Selected directory").ToString());
        }

        private void _baseViewRunInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void _baseViewRsunStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
