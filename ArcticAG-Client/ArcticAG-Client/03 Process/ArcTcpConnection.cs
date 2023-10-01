using ArcticAG_Admin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ArcticAG_Client
{
    public class ArcTcpConnection
    {
        // Constructor(s) //

        public ArcTcpConnection()
        {
            _client = null;
            _stream = null;
        }

        // Public method(s) //

        public bool closeConnection()
        {
            // Close the stream and client connections (if currently active)
            validateConnection();

            _stream.Close();
            _client.Close();

            _stream = null;
            _client = null;

            return true;
        }

        public void initializeConnection(IPAddress iPAddress, int port)
        {
            // Create the stream and client connections (if not already currently active)
            if (_stream != null || _client != null)
            {
                throw new ArcConnectionAlreadyEstablishedException();
            }

            _client = new TcpClient(iPAddress.ToString(), port);
            _stream  = _client.GetStream();
        }

        public List<string> requestLogin(string username, string password)
        {
            // Make sure the connection is valid
            validateConnection();

            // Let server know we are trying to login.
            byte[] loginRequestCodeBytes = Encoding.ASCII.GetBytes(ArcConstants.TCP_CODE_LOGIN);
            _stream.Write(loginRequestCodeBytes, 0, loginRequestCodeBytes.Length);

            // Send the username
            byte[] usernameSizeBytes = BitConverter.GetBytes(username.Length);
            _stream.Write(usernameSizeBytes, 0, usernameSizeBytes.Length);

            byte[] usernameBytes = Encoding.ASCII.GetBytes(username);
            _stream.Write(usernameBytes, 0, usernameBytes.Length);

            // Send the password
            byte[] passwordSizeBytes = BitConverter.GetBytes(password.Length);
            _stream.Write(passwordSizeBytes, 0, passwordSizeBytes.Length);

            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);
            _stream.Write(passwordBytes, 0, passwordBytes.Length);

            // Read whether the login was successful or failed
            byte[] status = new byte[3];
            int bytes = _stream.Read(status, 0, status.Length);
            string loginResponse = Encoding.ASCII.GetString(status, 0, bytes);

            // Make sure login was successful
            if (loginResponse.Contains(ArcConstants.TCP_CODE_LOGIN_DENIED))
            {
                throw new ArcLoginConnectionErrorException();
            }

            // Read the assignment names
            byte[] assingmentNamesSizeBytes = new byte[4];
            _stream.Read(assingmentNamesSizeBytes, 0, assingmentNamesSizeBytes.Length);
            int nameSize = BitConverter.ToInt32(assingmentNamesSizeBytes, 0);

            byte[] assignmentNamesStringBytes = new byte[nameSize];
            bytes = _stream.Read(assignmentNamesStringBytes, 0, assignmentNamesStringBytes.Length);
            string names = Encoding.ASCII.GetString(assignmentNamesStringBytes, 0, bytes);

            // Pars the assignment names.
            List<string> assignmentNamesList = new List<string>();
            foreach (string assignmentName in names.Split(ArcConstants.TCP_FILE_SPLIT_DELIM))
            {
                if (assignmentName != null && assignmentName.Length != 0)
                {
                    assignmentNamesList.Add(assignmentName);
                }
            }

            return assignmentNamesList;
        }

        public double sendData(string fileName, string assignmentName, string userName)
        {
            // Make sure the connection is valid
            validateConnection();

            // Let server know we are sending data.
            byte[] loginRequestCodeBytes = Encoding.ASCII.GetBytes(ArcConstants.TCP_CODE_SEND_DATA);
            _stream.Write(loginRequestCodeBytes, 0, ArcConstants.TCP_CODE_SEND_DATA.Length);

            // Send the zip file to the server
            byte[] fileBytes     = File.ReadAllBytes(fileName);
            byte[] fileSizeBytes = BitConverter.GetBytes(fileBytes.Length);
            _stream.Write(fileSizeBytes, 0, fileSizeBytes.Length);
            _stream.Write(fileBytes, 0, fileBytes.Length);

            // Write the assignment name
            byte[] assignmentNameSizeBytes = BitConverter.GetBytes(assignmentName.Length);
            _stream.Write(assignmentNameSizeBytes, 0, assignmentNameSizeBytes.Length);

            byte[] assignmentNameBytes = Encoding.ASCII.GetBytes(assignmentName);
            _stream.Write(assignmentNameBytes, 0, assignmentNameBytes.Length);

            // Write the user name
            byte[] userNameSizeBytes = BitConverter.GetBytes(userName.Length);
            _stream.Write(userNameSizeBytes, 0, userNameSizeBytes.Length);

            byte[] userNameBytes = Encoding.ASCII.GetBytes(userName);
            _stream.Write(userNameBytes, 0, userNameBytes.Length);

            // Recieve the grade
            byte[] gradeBytes = new byte[8];
            int bytesRead = _stream.Read(gradeBytes, 0, gradeBytes.Length);
            string grade = Encoding.ASCII.GetString(gradeBytes, 0, bytesRead);

            return double.Parse(grade);
        }

        // Private method(s) //

        private void validateConnection()
        {
            if (_stream == null || _client == null)
            {
                throw new ArcInvalidConnectionException();
            }
        }

        // Private variable(s) //

        TcpClient?     _client; // Holds the client connection
        NetworkStream? _stream; // Holds the stream connection
    }
}
