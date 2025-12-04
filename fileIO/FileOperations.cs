using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace basics.fileIO
{
    internal class FileOperations
    {
        static void Main()
        {
            string path = "example.txt";
            File.WriteAllText(path, "Hello Priyanshu!\n");
            Console.WriteLine("File created and written.");

            File.AppendAllText(path, "This is appended text.\n");
            Console.WriteLine("Text appended.");

            string content = File.ReadAllText(path);
            Console.WriteLine("\n--- FILE CONTENT ---");
            Console.WriteLine(content);

            if (File.Exists(path))
                Console.WriteLine("File exists.");
        }
    }
}
