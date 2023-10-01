using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ArcticAG_Admin
{
    static class ArcFileHandler
    {
        // Public Methods - Static //

        public static void createAssignmentDirectory(string newDirectoryName, string directoryPath, string assignmentFilesPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException("Source directory does not exist.");
            }

            if (!validatePathname(newDirectoryName))
            {
                throw new InvalidDataException("Invalid character found in the directory name");
            }

            string newDirectory = directoryPath + "\\" + newDirectoryName;

            if (Directory.Exists(newDirectory))
            {
                throw new ArcDirectoryAlreadyExistsException();
            }

            Directory.CreateDirectory(newDirectory);

            string instructorDirectory = newDirectory + "\\INSTRUCTOR_FILES";

            Directory.CreateDirectory(instructorDirectory);

            foreach (string file in getAllFiles(assignmentFilesPath))
            {
                System.IO.File.Copy(file, instructorDirectory + "\\" + file.Split("\\").Last());
            }

            createGradingFile(instructorDirectory);
            File.Create(instructorDirectory + "\\STUDENT_GRADES");
        }

        public static string getDirectory()
        {
            string directory = string.Empty;

            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFolderDialog.SelectedPath;
                }
            }

            return string.Empty;
        }

        public static List<string> getGrades(string directory, string filename, uint level = 0)
        {
            List<string> gradeList = new List<string>();

            if (File.Exists(directory + "\\" + filename))
            {
                FileStream gradeFile = File.OpenRead(directory + "\\" + filename);
                StreamReader streamReader = new StreamReader(gradeFile);

                string? line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    gradeList.Add(line);
                }

                streamReader.Close();
                gradeFile.Close();

                return gradeList;
            }

            if (level == 3)
            {
                return gradeList;
            }

            foreach (string subDirectory in Directory.EnumerateDirectories(directory))
            {
                return getGrades(subDirectory, filename, ++level);
            }

            return gradeList;
        }

        public static bool validatePathname(string pathname)
        {
            char[] invalidCharacters = Path.GetInvalidPathChars();
            foreach (char invalidChar in invalidCharacters)
            {
                if (pathname.Contains(invalidChar))
                {
                    return false;
                }
            }

            return true;
        }

        // Private Methods - Static //

        private static void createGradingFile(string directory)
        {
            FileStream gradeFile = File.Create(directory + "\\GRADING_SCALE");

            StreamWriter streamWriter = new StreamWriter(gradeFile);
            streamWriter.Write(ArcConstants.GRADE_NO_MISSING_FILES + ArcConstants.GRADE_DEFAULT_VALUE + "\n");
            streamWriter.Write(ArcConstants.GRADE_NO_COMPILE_ERRORS + ArcConstants.GRADE_DEFAULT_VALUE + "\n");
            streamWriter.Write(ArcConstants.GRADE_CORRECT_OUTPUT + ArcConstants.GRADE_DEFAULT_VALUE + "\n");
            streamWriter.Flush();
            streamWriter.Close();
            gradeFile.Close();
        }

        private static List<string> getAllFiles(string directory, uint level = 0U)
        {
            if (level > 3U)
            {
                throw new ArcTooManyFilesException();
            }

            List<string> filesList = new List<string>();

            // Recursively loop throught the sub directories.
            foreach (string subDirectory in Directory.EnumerateDirectories(directory))
            {
                foreach (string file in getAllFiles(subDirectory, ++level))
                {
                    filesList.Add(file);
                }
            }

            foreach (string file in Directory.GetFiles(directory))
            {
                filesList.Add(file);
            }

            return filesList;
        }
    }
}
