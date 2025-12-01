using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace basics.Linq
{
    internal class BasicOperations
    {
        public class Student
        {
            public string Name { get; set; }
            public int Marks { get; set; }

        }
        static void Main()
        {
            var students = new List<Student> {
                new Student{Name = "Abhay" , Marks = 60 },
                new Student{Name = "Arav", Marks = 80},
                new Student{Name = "Chhotu", Marks = 100 },
            };
            var top = students.Where(s => s.Marks > 80);
            Console.WriteLine("Students with marks > 80:");

            foreach (var s in top)
            {
                Console.WriteLine($"{s.Name} - {s.Marks}");
            }
            

        }
    }
}

