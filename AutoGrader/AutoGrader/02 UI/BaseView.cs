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
        }

        private void _baseViewOpenInstructorFileButton_Click(object sender, EventArgs e)
        {
            FileHandler.getDirectory();
        }

        private void _baseViewOpenStudentFileButton_Click(object sender, EventArgs e)
        {
            FileHandler.getDirectory();
        }

        private void runAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void runInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void runStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
