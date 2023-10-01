using ArcticAG_Admin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ArcticAG_Server
{
    static public class ArcFileHandler
    {
        // Public Method(s) - Static //

        static public bool CheckForStudent(string studentLoginFile, string username, string password)
        {
            // Check whether the student login credentials are correct.
            FileStream studentFile = File.OpenRead(studentLoginFile);

            StreamReader streamReader = new StreamReader(studentFile);
            string? fileLine = null;

            while ((fileLine = streamReader.ReadLine()) != null)
            {
                if (fileLine.Contains(username) && fileLine.Contains(password))
                {
                    streamReader.Close();
                    studentFile.Close();

                    return true;
                }
            }

            streamReader.Close();
            studentFile.Close();

            return false;
        }

        static public void CopyFiles(string fromDirectory, string toDirectory, string fileType = "", uint level = 0)
        {
            // Copy files from one directory to another recursively for 3 sublevels to prevent copying a large amount of data
            foreach (string file in Directory.EnumerateFiles(fromDirectory))
            {
                if (fileType == string.Empty || file.EndsWith(fileType))
                {
                    File.Copy(file, toDirectory + "\\" + file.Split('\\').Last(), false);
                }
            }

            if (level > 3)
            {
                // Recursively loop throught the sub directories.
                foreach (string subDirectory in Directory.EnumerateDirectories(fromDirectory))
                {
                    CopyFiles(subDirectory, toDirectory, fileType, ++level);
                }
            }
        }

        static public void CopyFilesAndDelete(string fromDirectory, string toDirectory, uint level = 0)
        {
            // Deleting files from one directory and copies to another recursively for 3 sublevels to prevent copying a large amount of data
            foreach (string file in Directory.EnumerateFiles(fromDirectory))
            {
                File.Copy(file, toDirectory + "\\" + file.Split('\\').Last(), false);
            }

            if (level > 3)
            {
                // Recursively loop throught the sub directories.
                foreach (string subDirectory in Directory.EnumerateDirectories(fromDirectory))
                {
                    CopyFilesAndDelete(subDirectory, toDirectory, ++level);
                    Directory.Delete(subDirectory, true);
                }
            }
        }

        static public void WriteToFile(string fileName, string stringToWrite)
        {
            // Write a string to a file.
            FileStream studentFile = File.OpenWrite(fileName);
            StreamWriter streamWriter = new StreamWriter(studentFile);

            streamWriter.WriteLine(stringToWrite);

            streamWriter.Close();
            studentFile.Close();
        }
    }
}
