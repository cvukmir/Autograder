using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArcticAG_Admin
{
    static class ArcExecuteProgram
    {
        // Public Methods - Static //

        public static ArcGradeInformation ExecuteSingleProgram(string directory)
        {
            return ExecuteProgram(directory);
        }

        // Private Methods - Static //

        private static void CreateBatFile_CPP(string directory)
        {
            // Remove .bat file if it already exists.
            if (Directory.GetFiles(directory).Contains(ArcConstants.EXEC_BAT_FILE))
            {
                File.Delete(directory + ArcConstants.EXEC_BAT_FILE);
            }

            // Find all files in the folder except for the main file.
            string fileString = " ";
            foreach (string file in Directory.GetFiles(directory))
            {
                if (file.EndsWith(".cpp") && !file.EndsWith("Main.cpp"))
                {
                    fileString += file.Split('\\').Last() + " ";
                }
            }
            
            // Create the bat file command to run the program.
            FileStream batFile = File.Create(directory + "\\" + ArcConstants.EXEC_BAT_FILE);

            StreamWriter streamWriter = new StreamWriter(batFile);
            streamWriter.WriteLine("@echo off");
            streamWriter.WriteLine("g++" + fileString + "Main.cpp -o program");
            streamWriter.WriteLine("start /wait program.exe");
            streamWriter.Write("echo \"FINAL_GRADE=%errorlevel%\"");
            streamWriter.Flush();
            streamWriter.Close();
            batFile.Close();
        }

        private static void CreateBatFile_JAVA(string directory)
        {
            // Remove .bat file if it already exists.
            if (Directory.GetFiles(directory).Contains(ArcConstants.EXEC_BAT_FILE))
            {
                File.Delete(directory + ArcConstants.EXEC_BAT_FILE);
            }

            // Find all files in the folder except for the main file.
            string fileString      = " ";
            string fileStringNoExt = " ";
            foreach (string file in Directory.GetFiles(directory))
            {
                if (file.EndsWith(".java") && !file.EndsWith("Main.java"))
                {
                    fileString      += file.Split('\\').Last() + " ";
                    fileStringNoExt += file.Split('\\').Last().Split('.').First() + " ";
                }
            }

            // Create the bat file command to run the program.
            FileStream batFile = File.Create(directory + "\\" + ArcConstants.EXEC_BAT_FILE);

            StreamWriter streamWriter = new StreamWriter(batFile);
            streamWriter.WriteLine("@echo off");
            streamWriter.WriteLine("javac" + fileString + "Main.java");
            streamWriter.WriteLine("java Main");
            streamWriter.Write("echo \"FINAL_GRADE=%errorlevel%\"");
            streamWriter.Flush();
            streamWriter.Close();
            batFile.Close();
        }

        private static ArcGradeInformation ExecuteProgram(string directory)
        {
            ArcGradeInformation logger = new ArcGradeInformation();

            logger.FilePath = directory;
            logger.Name     = directory.Split('\\').Last();
            logger.AddLog("Initializing execution for " + logger.Name);

            // Execute the code.
            logger.AddLog("Executing...");
            string output = RunCode(directory);
            logger.AddLog(output);

            // Get the grade
            int indexOfGrade = output.LastIndexOf("FINAL_GRADE=") + "FINAL_GRADE=".Length;
            int endOfLine    = output.IndexOf('\n', indexOfGrade) - 2;
            string? gradeStr = output.Substring(indexOfGrade, endOfLine - indexOfGrade);

            if (gradeStr != null)
            {
                double grade = double.Parse(gradeStr);
                switch (grade)
                {
                    case 0.0:
                        logger.Grade = 100;
                        break;
                    case > 1000:
                        logger.Grade = 0.0;
                        break;
                    default:
                        logger.Grade = grade;
                        break;
                }
            }
            else
            {
                logger.Grade = 0.0;
            }

            // Done!
            logger.AddLog("Finished!");

            return logger;
        }

        private static string FindFile(string directory, string fileName)
        {
            // See if current directory contains the file.
            if (directory.Contains(fileName))
            {
                return directory;
            }

            // Check all sub-directories.
            foreach (string subDirectory in Directory.EnumerateDirectories(directory))
            {
                return FindFile(subDirectory, fileName);
            }

            // Could not be found.
            throw new FileNotFoundException();
        }
        
        private static string RunCode(string directory)
        {
            // Create the program bat file
            CreateBatFile_CPP(directory);

            // Setup the process to execute the program.
            Process          process   = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            //startInfo.Arguments = "";
            startInfo.FileName               = directory + "\\" + ArcConstants.EXEC_BAT_FILE;
            startInfo.WorkingDirectory       = directory;
            startInfo.RedirectStandardError  = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute        = false;
            startInfo.WindowStyle            = ProcessWindowStyle.Hidden;
            
            // Execute the program and get the results.
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit(1000);
            string output = process.StandardOutput.ReadToEnd();
            string error  = process.StandardError.ReadToEnd();

            return output + error;
        }
    }
}
