using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void LogHandler(string message);

namespace basics.Delegates
{
    internal class Logger
    {
        public static void LogToConsole(string msg)
       => Console.WriteLine("Console Log: " + msg);

        public static void LogToFile(string msg)
            => Console.WriteLine("File Log: " + msg);

        public static void LogToEmail(string msg)
            => Console.WriteLine("Email Log: " + msg);
    }

    class Execute
    {
        static void Main()
        {
            LogHandler log = Logger.LogToConsole;
            log += Logger.LogToFile;
            log += Logger.LogToEmail;

            log("User logged in successfully!");
        }
    }
}
