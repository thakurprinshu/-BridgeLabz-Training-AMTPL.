using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace basics.fileIO
{
    internal class UseStream
    {
        static void Main()
        {
            string path = "notes.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("First line");
                sw.WriteLine("Second line");
                sw.WriteLine("Third line");
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                Console.WriteLine("--- Reading File ---");

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
