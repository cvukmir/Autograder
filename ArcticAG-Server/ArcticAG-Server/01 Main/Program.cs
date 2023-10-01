using System.Net.Sockets;
using System.Net;

namespace ArcticAG_Server
{
    internal static class Program
    {
        static void Main()
        {
            // Get the file location
            Console.WriteLine("Enter location to deposit files ('Q' or 'Quit' to cancel):");

            string? directory;

            while (!Directory.Exists(directory = Console.ReadLine()))
            {
                if (directory == "Q" || directory == "q" || directory == "Quit")
                {
                    return;
                }

                Console.WriteLine("The directory \"" + directory + "\" is not valid, please try again:");
            }

            Console.WriteLine("Incoming files will be deposited at \"" + directory + "\"\n");

            // Get the IP address
            Console.WriteLine("Finding local IP Address...");

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress?  ipAddress = null;
            int         port = 80;

            // Get the IP address of this machine.
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddress = ip;
                    break;
                }
            }

            bool identifyNewIP = (ipAddress == null);

            // Ask whether the found IP address is the correct addresss.
            if (!identifyNewIP)
            {
                Console.WriteLine("Found IP Address: " + ipAddress.ToString() + "\n");
                Console.WriteLine("Is this the correct IP address (\'y\' or \'n\')");
                string? consoleInput = Console.ReadLine();
                while (consoleInput == null || (consoleInput != "y" && consoleInput != "Y" && consoleInput != "n" && consoleInput != "N"))
                {
                    if (consoleInput == "Q" || consoleInput == "q" || consoleInput == "Quit")
                    {
                        return;
                    }

                    Console.WriteLine("Invalid response.\n");
                    Console.WriteLine("Is this the correct IP address (\'y\' or \'n\')");
                    consoleInput = Console.ReadLine();
                }

                if (consoleInput == "n" || consoleInput == "N")
                {
                    identifyNewIP = true;
                    ipAddress     = null;
                }
            }
            
            // Identify a new IP address.
            if (identifyNewIP)
            {
                string? consoleInput = null;
                while (ipAddress == null)
                {
                    Console.WriteLine("Enter the IP Address to use:");
                    consoleInput = Console.ReadLine();
                    if (consoleInput == null)
                    {
                        Console.WriteLine("Invalid IP Address.");
                        continue;
                    }

                    if (consoleInput == "Q" || consoleInput == "q" || consoleInput == "Quit")
                    {
                        return;
                    }

                    try
                    {
                        ipAddress = IPAddress.Parse(consoleInput);
                    }
                    catch 
                    {
                        Console.WriteLine("Invalid IP Address.");
                        ipAddress = null;
                    }
                }
            }

            // Open the server.
            Console.WriteLine("Connecting to IP Address \'" + ipAddress.ToString() + "\' on port " + port + ".");

            ArcTcpConnection.OpenServer(ipAddress, port, directory);

            // Finished.
            Console.WriteLine("Connection closed, terminating program...");

            Console.WriteLine("Finished!");

        }
    }
}