using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace AutoGrader
{
    class FileHandler
    {
        // Constuctor(s) //
        public FileHandler()
        {
            _instructorDirectory = String.Empty;
            _studentDirectory    = String.Empty;
        }
        
        // Public Properties //

        // Gets/sets the instructor directory
        public string InstructorDirectory
        {
            get => _instructorDirectory;
        }

        // Gets/sets the student directory
        public string StudentDirectory
        {
            get => _studentDirectory;
        }

        // Public Methods //
        
        public Dictionary<string, List<string>> getInstructorDirectory()
        {
            _instructorDirectory = getDirectory();

            return getSubFolders(_instructorDirectory);
        }

        public Dictionary<string, List<string>> getStudentDirectory()
        {
            _studentDirectory = getDirectory();

            return getSubFolders(_studentDirectory);
        }

        // Private Methods //

        private string getDirectory()
        {
            string directory = string.Empty;

            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                openFolderDialog.InitialDirectory = "c:\\";

                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    directory = openFolderDialog.SelectedPath;
                }
            }

            return directory;
        }

        private Dictionary<string, List<string>> getSubFolders(string currentDirectory)
        {
            Dictionary<string, List<string>> filesList = new Dictionary<string, List<string>>();

            // Recursively loop throught the sub directories.
            foreach (string subDirectory in Directory.EnumerateDirectories(currentDirectory))
            {
                foreach (KeyValuePair<string, List<string>> subFiles in getSubFolders(subDirectory))
                {
                    filesList.Add(subFiles.Key, subFiles.Value);
                }
            }

            List<string> files = new List<string>();

            // Get all the files in the current directory.
            foreach (string file in Directory.EnumerateFiles(currentDirectory))
            {
                files.Append(file);
            }

            filesList.Add(currentDirectory, files);

            return filesList;
        }


        // Private Variables //

        private string _instructorDirectory;
        private string _studentDirectory;
    }
}
