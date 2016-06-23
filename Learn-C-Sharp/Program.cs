// using is a keyword which imports a namespace (a collection of classes)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Program
    {
        // bool, int, string, char, float
        // <visibility> <data type> <name> = <value>;
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please enter a number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("You have entered " + number);
            Console.WriteLine("Hello, World!");
            // call ReadLine() so that the console will not close immediately after printing
            Console.ReadLine();
        }
    }
}
