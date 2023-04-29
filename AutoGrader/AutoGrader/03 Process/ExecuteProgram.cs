using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoGrader
{
    static class ExecuteProgram
    {
        // Public Methods - Static //

        // Executes a single program from the given directory.
        public static GradeInformation executeSingleProgram(string directory)
        {
            return executeProgram_CPP(directory);
        }

        // Executes all progarms within the subfolders of the given directory.
        public static List<GradeInformation> executeAllPrograms(string directory)
        {
            List<GradeInformation> gradeInfoList = new List<GradeInformation>();

            foreach (string subDirectory in Directory.EnumerateDirectories(directory))
            {
                gradeInfoList.Add(executeProgram_CPP(subDirectory));
            }

            return gradeInfoList;
        }


        // Private Methods - Static //

        private static string createBatFile(string directory)
        {
            if (Directory.GetFiles(directory).Contains("__exec_bat_file.bat"))
            {
                File.Delete(directory + "__exec_bat_file.bat");
            }
            
            FileStream batFile = File.Create(directory + "__exec_bat_file.bat");

            StreamWriter streamWriter = new StreamWriter(batFile);
            streamWriter.Write("echo Hello World");
            streamWriter.Flush();
            streamWriter.Close();
            batFile.Close();

            return "";
        }

        private static string runCode(string file)
        {
            createBatFile("C:\\Users\\Chris\\Desktop\\");

            Process          process   = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            //startInfo.Arguments = "";
            startInfo.FileName               = "C:\\Users\\Chris\\Desktop\\__exec_bat_file.bat";
            startInfo.RedirectStandardError  = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute        = false;
            startInfo.WindowStyle            = ProcessWindowStyle.Hidden;
            
            process.StartInfo = startInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error  = process.StandardError.ReadToEnd();
            process.WaitForExit();

            File.Delete("C:\\Users\\Chris\\Desktop\\__exec_bat_file.bat");

            return output + error;
        }

        private static GradeInformation executeProgram_CPP(string directory)
        {
            GradeInformation logger = new GradeInformation();

            logger.FilePath = directory;
            logger.Name     = directory.Split('\\').Last();
            logger.addLog("Initializing execution for " + logger.Name);

            // Find the makefile.
            logger.addLog("Finding makefile");
            try
            {
                findFile(directory, "Makefile");

                // Found makefile! Adding grade to total.
                logger.Grade += Constants.GRADE_MAKEFILE;
            }
            catch (FileNotFoundException)
            {
                logger.addLog("Could not find the makefile, assigning grade of " + logger.Grade.ToString());
                return logger;
            }

            // Find the main.cpp file.
            logger.addLog("Finding the main program");
            try
            {
                findFile(directory, "Main");

                // Found main file! Adding grade to total.
                logger.Grade += Constants.GRADE_MAINFILE;
            }
            catch (FileNotFoundException)
            {
                logger.addLog("Could not find the main file, assigning grade of " + logger.Grade.ToString());
                return logger;
            }

            // Compile the code.
            logger.addLog("Compiling...");
            logger.addLog(runCode("Insert directory here"));

            // Execute the code.
            logger.addLog("Executing...");
            logger.addLog(runCode("Insert directory here"));

            // Done!
            logger.addLog("Finished!");

            return logger;
        }

        private static string findFile(string directory, string fileName)
        {
            // See if current directory contains the file.
            if (directory.Contains(fileName))
            {
                return directory;
            }

            // Check all sub-directories.
            foreach (string subDirectory in Directory.EnumerateDirectories(directory))
            {
                return findFile(subDirectory, fileName);
            }

            // Could not be found.
            throw new FileNotFoundException();
        }
    }
}
