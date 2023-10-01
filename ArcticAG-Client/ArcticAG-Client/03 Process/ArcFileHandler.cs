using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace ArcticAG_Client
{
    static class ArcFileHandler
    {
        // Public Methods - Static //
        public static string getZipFile()
        {
            // Openm a file dialog and only allow for selcting of zip files
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter      = "Zip (*.zip)|*.zip";/*|7-Zip(*.7z)|*.7z*/
                openFileDialog.FilterIndex = 0;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }

            return string.Empty;
        }
    }
}
