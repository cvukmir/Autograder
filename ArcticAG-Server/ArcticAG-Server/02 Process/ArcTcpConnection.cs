using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ArcticAG_Admin;
using System.IO.Compression;

namespace ArcticAG_Server
{
    static public class ArcTcpConnection
    {
        // Public Method(s) - Static //

        static public void OpenServer(IPAddress ipAddress, int port, string saveDirectory)
        {
            // Open the server.
            TcpListener listener = new TcpListener(ipAddress, port);
            listener.Start();

            // Keep an open connection.
            while (true)
            {
                // Wait for connection.
                Console.WriteLine("Awaiting connection...");
                TcpClient client = listener.AcceptTcpClient();

                // Connection found!
                NetworkStream stream = client.GetStream();

                IPEndPoint remoteIpEndPoint = client.Client.RemoteEndPoint as IPEndPoint;
                Console.WriteLine("Connection established with " + remoteIpEndPoint.Address);

                int bytesRead;

                // Check what the request is for.
                byte[] loginRequestCode = new byte[3];
                bytesRead = stream.Read(loginRequestCode, 0, loginRequestCode.Length);
                string requestCode = Encoding.ASCII.GetString(loginRequestCode, 0, bytesRead);

                if (requestCode == ArcConstants.TCP_CODE_LOGIN) // Login request
                {
                    int receiveSize;

                    // Read username
                    byte[] usernameSizeBytes = new byte[4];
                    stream.Read(usernameSizeBytes, 0, usernameSizeBytes.Length);
                    receiveSize = BitConverter.ToInt32(usernameSizeBytes, 0);

                    byte[] usernameBytes = new byte[receiveSize];
                    bytesRead = stream.Read(usernameBytes, 0, receiveSize);
                    string username = Encoding.ASCII.GetString(usernameBytes, 0, bytesRead);

                    // Read password
                    byte[] passwordSizeBytes = new byte[4];
                    stream.Read(passwordSizeBytes, 0, passwordSizeBytes.Length);
                    receiveSize = BitConverter.ToInt32(passwordSizeBytes, 0);

                    byte[] passwordBytes = new byte[receiveSize];
                    bytesRead = stream.Read(passwordBytes, 0, receiveSize);
                    string password = Encoding.ASCII.GetString(passwordBytes, 0, bytesRead);

                    // Check to see if the student login info is correct
                    if (ArcFileHandler.CheckForStudent(saveDirectory + "\\STUDENT_LOGINS", username, password))
                    {
                        Console.WriteLine("Requesting login...");

                        // Get the list of assignments
                        byte[] loginApprovedCodeBytes = Encoding.ASCII.GetBytes(ArcConstants.TCP_CODE_LOGIN_APPROVED);
                        stream.Write(loginApprovedCodeBytes, 0, loginApprovedCodeBytes.Length);

                        string assignmentNames = string.Empty;

                        foreach (string directoryName in Directory.GetDirectories(saveDirectory))
                        {
                            assignmentNames += directoryName.Split("\\").Last() + ArcConstants.TCP_FILE_SPLIT_DELIM;
                        }

                        // Write the assignment names
                        byte[] assignmentNamesSizeBytes = BitConverter.GetBytes(assignmentNames.Length);
                        stream.Write(assignmentNamesSizeBytes, 0, assignmentNamesSizeBytes.Length);

                        byte[] assignmentNamesBytes = Encoding.ASCII.GetBytes(assignmentNames);
                        stream.Write(assignmentNamesBytes, 0, assignmentNames.Length);
                    }
                    else
                    {
                        // Login denied.
                        byte[] loginDeniedCodeBytes = Encoding.ASCII.GetBytes(ArcConstants.TCP_CODE_LOGIN_DENIED);
                        stream.Write(loginDeniedCodeBytes, 0, loginDeniedCodeBytes.Length);
                    }
                }
                else if (requestCode == ArcConstants.TCP_CODE_SEND_DATA) // Data request.
                {
                    Console.WriteLine("Assignment is being turned in...");

                    int receiveSize;

                    // Read the zip file
                    byte[] fileSizeBytes = new byte[4];
                    stream.Read(fileSizeBytes, 0, fileSizeBytes.Length);
                    receiveSize = BitConverter.ToInt32(fileSizeBytes, 0);

                    byte[] fileBytes = new byte[receiveSize];
                    stream.Read(fileBytes, 0, fileBytes.Length);

                    // Read the assignment name
                    byte[] assignmentNameSizeBytes = new byte[4];
                    stream.Read(assignmentNameSizeBytes, 0, assignmentNameSizeBytes.Length);
                    receiveSize = BitConverter.ToInt32(assignmentNameSizeBytes, 0);

                    byte[] assignmentNameBytes = new byte[receiveSize];
                    bytesRead = stream.Read(assignmentNameBytes, 0, assignmentNameBytes.Length);
                    string assignmentName = Encoding.ASCII.GetString(assignmentNameBytes, 0, bytesRead);

                    // Read the student name
                    byte[] studentNameSizeBytes = new byte[4];
                    stream.Read(studentNameSizeBytes, 0, studentNameSizeBytes.Length);
                    receiveSize = BitConverter.ToInt32(studentNameSizeBytes, 0);

                    byte[] studentNameBytes = new byte[receiveSize];
                    bytesRead = stream.Read(studentNameBytes, 0, studentNameBytes.Length);
                    string studentName = Encoding.ASCII.GetString(studentNameBytes, 0, bytesRead);

                    // Save, extract, run and grade the program
                    string assignmentDirectory        = saveDirectory + "\\" + assignmentName;
                    string studentAssignmentDirectory = assignmentDirectory + "\\" + studentName;
                    string studentZipFile             = studentAssignmentDirectory + "\\assignment.zip";

                    // Check for prior submission
                    if (Directory.Exists(studentAssignmentDirectory))
                    {
                        // Return an error response.
                        byte[] responseBytes = Encoding.ASCII.GetBytes("-1");
                        stream.Write(responseBytes, 0, responseBytes.Length);
                    }
                    else
                    {
                        Directory.CreateDirectory(studentAssignmentDirectory);
                        File.WriteAllBytes(studentZipFile, fileBytes);
                        ZipFile.ExtractToDirectory(studentZipFile, studentAssignmentDirectory);
                        File.Delete(studentZipFile);

                        ArcFileHandler.CopyFilesAndDelete(studentAssignmentDirectory, studentAssignmentDirectory);
                        ArcFileHandler.CopyFiles(assignmentDirectory + "\\INSTRUCTOR_FILES", studentAssignmentDirectory, ".cpp");

                        double grade = ArcExecuteProgram.ExecuteSingleProgram(studentAssignmentDirectory).Grade;

                        ArcFileHandler.WriteToFile(assignmentDirectory + "\\INSTRUCTOR_FILES\\STUDENT_GRADES", studentName + "-" + grade.ToString());

                        // Return the grade.
                        byte[] responseBytes = Encoding.ASCII.GetBytes(grade.ToString());
                        stream.Write(responseBytes, 0, responseBytes.Length);
                    }
                }

                Console.WriteLine("Closing connection with " + remoteIpEndPoint.Address);
                client.Close();
            }
        }

    }
}
