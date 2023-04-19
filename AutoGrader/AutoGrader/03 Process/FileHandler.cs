using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace AutoGrader
{
    static class FileHandler
    {
        // Public Methods - Static //
        public static void getDirectory()
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

            getSubFolders(directory);
        }

        // Private Methods - Static /
        private static Dictionary<string, List<string>> getSubFolders(string currentDirectory)
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
    }
}
