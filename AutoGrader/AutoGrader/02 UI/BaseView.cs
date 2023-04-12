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
            _fileHandler = new FileHandler();
        }

        private void _baseViewOpenInstructorFileButton_Click(object sender, EventArgs e)
        {
            _fileHandler.getInstructorDirectory();
        }

        private void _baseViewOpenStudentFileButton_Click(object sender, EventArgs e)
        {
            _fileHandler.getStudentDirectory();
        }

        // Private Variables //
        FileHandler _fileHandler;
    }
}
