using System;
using System.Net;
using System.IO;

namespace CoasterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   _____                _             _____                      _      ");
            Console.WriteLine("  / ____|              | |           / ____|                    | |     ");
            Console.WriteLine(" | |     ___   __ _ ___| |_ ___ _ __| |     ___  _ __  ___  ___ | | ___ ");
            Console.WriteLine(" | |    / _ \\ / _` / __| __/ _ \\ '__| |    / _ \\| '_ \\/ __|/ _ \\| |/ _ \\");
            Console.WriteLine(" | |___| (_) | (_| \\__ \\ ||  __/ |  | |___| (_) | | | \\__ \\ (_) | |  __/");
            Console.WriteLine("  \\_____\\___/ \\__,_|___/\\__\\___|_|   \\_____\\___/|_| |_|___/\\___/|_|\\___|");
            Console.WriteLine("                                                                        ");
            Console.WriteLine("Coaster OS [version 0.1]");
            Console.WriteLine("C:\\CoasterOS\\System>");
            String ConsoleWrite1 = Console.ReadLine();
            if (ConsoleWrite1 == "hello")
            {
                Console.WriteLine("hello there!");
                Console.ReadLine();
            }
            if (ConsoleWrite1 == "ipshow")
            {
                string hostName = Dns.GetHostName();
                Console.WriteLine(hostName);
                string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                Console.WriteLine("My IP Address is :" + myIP);
                Console.ReadKey();
            }
            if (ConsoleWrite1 == "Dir.S.D")
            {
                try
                {
                    string[] dirs = Directory.GetDirectories(@"c:\", "p*", SearchOption.TopDirectoryOnly);
                    Console.WriteLine("The number of directories starting with p is {0}.", dirs.Length);
                    foreach (string dir in dirs)
                    {
                        Console.WriteLine(dir);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                }
            }
            if (ConsoleWrite1 == "info")
            {
                Console.WriteLine("(c) 2021 CoasterOS Corporation. All rights reserved.");
                Console.WriteLine("Info about CoasterOS:");
                Console.WriteLine("CoasterOS, developed in Lithuania.");
                Console.WriteLine("Currenty running on version [0.1]");
            }
            Console.ReadLine();
        }
    }
}
