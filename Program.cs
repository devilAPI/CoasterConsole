using System;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace CoasterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("/     _____                _             _____                      _                /");
            Console.WriteLine("/    / ____|              | |           / ____|                    | |               /");
            Console.WriteLine("/   | |     ___   __ _ ___| |_ ___ _ __| |     ___  _ __  ___  ___ | | ___           /");
            Console.WriteLine("/   | |    / _ \\ / _` / __| __/ _ \\ '__| |    / _ \\| '_ \\/ __|/ _ \\| |/ _ \\          /");
            Console.WriteLine("/   | |___| (_) | (_| \\__ \\ ||  __/ |  | |___| (_) | | | \\__ \\ (_) | |  __/          /");
            Console.WriteLine("/    \\_____\\___/ \\__,_|___/\\__\\___|_|   \\_____\\___/|_| |_|___/\\___/|_|\\___|          /");
            Console.WriteLine("/                                                                                    /");
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("Coaster OS [version 0.3]");
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
                Console.WriteLine("Currenty running on version [0.3]");
                Console.ReadLine();
            }


            if (ConsoleWrite1 == "changelog")
            {
                Console.WriteLine("Version 0.3 changelog:");
                Console.WriteLine("added calculator command");
                Console.WriteLine("Added paint command");
                Console.ReadLine();
            }
            if (ConsoleWrite1 == "commands")
            {
                Console.WriteLine("commands : brings up this pannel.");
                Console.WriteLine("changelog : brings up the changelog pannel.");
                Console.WriteLine("info : info about the console.");
                Console.WriteLine("Dir.S.D : brings up the Directory by letter. (you can change it in the console's code).");
                Console.WriteLine("ipshow : shows your local ip address");
                Console.WriteLine("hello : it does exactly what you think it does ;)");
                Console.WriteLine("paint : Opens mspaint.");
                Console.WriteLine("calculator : Opens calculator.");
            }
            if (ConsoleWrite1 == "paint")
            {
                Process.Start("mspaint.exe");

                Console.WriteLine("Happy drawing! Press any key to continue...");

                Console.ReadLine();
            }
            if (ConsoleWrite1 == "calculator")
            {
                Process.Start("calc.exe");

                Console.WriteLine("Calculator started. Press any key to continue...");

                Console.ReadLine();
            }
            if (ConsoleWrite1 == "test")
            {
                Console.WriteLine("Guess the first number from 0 to 10: ");
                int GuessGameAwn1 = Convert.ToInt32(Console.ReadLine());
                if (GuessGameAwn1 == 2)
                {
                    Console.WriteLine("You guessed the number!");
                } else
                {
                    Console.WriteLine("No you dumbass");
                }
                Console.WriteLine("Guess the second number from 0 to 10: ");
                int GuessGameAwn2 = Convert.ToInt32(Console.ReadLine());
                if (GuessGameAwn2 == 7)
                {
                    Console.WriteLine("You guessed the number!");
                }
                else
                {
                    foreach (var process in Process.GetProcessesByName("explorer"))
                    {
                        process.Kill();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
