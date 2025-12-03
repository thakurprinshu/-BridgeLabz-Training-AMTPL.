using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int Operation(int a, int b);

namespace basics.Delegates
{
    internal class Calculator
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => a / b;
    }

    class Program
    {
        static void Main()
        {
        
            Operation op;

            op = Calculator.Add;
            Console.WriteLine("Add: " + op(10, 70));

            op = Calculator.Multiply;
            Console.WriteLine("Multiply: " + op(10, 50));

            op = Calculator.Subtract;
            Console.WriteLine("Subtract: " + op(10, 20));

            op = Calculator.Divide;
            Console.WriteLine("Divide: " + op(10, 30));
        }
    }
}
