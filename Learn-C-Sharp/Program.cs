// using is a keyword which imports a namespace (a collection of classes)
using System;
using System.Collections;
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
        // <visibility> <return type> <name>(<parameters>) { <function code> }
        public static int DoStuff(int n)
        {
            int value = (int)Math.Pow(n, 2);
            Console.WriteLine("DoStuff() is called and the return value will be " + value);
            return value;
        }

        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please enter a number: ");
            // improved parsing
            string input = Console.ReadLine();
            // { ... } is for blocks of >= 2 lines
            if (!int.TryParse(input, out number))
                number = -1;
            Console.WriteLine("You have entered " + number);
            switch(number)
            {
                case 0:
                case 1:
                    Console.WriteLine("Which is 0 or 1");
                    break;
                default:
                    Console.WriteLine("Which is some other number that is neither 0 nor 1");
                    break;
            }
            // while ( ... ) { ... }
            // do { ... } while ( ... );
            // for ( ... ; ... ; ... ) { ... }
            string[] alphabet = { "A", "B", "C" };
            foreach (string letter in alphabet)
            {
                Console.Write(letter);
            }
            // newline + newline
            Console.WriteLine('\n');
            ArrayList aList = new ArrayList();
            aList.Add("D");
            aList.Add(4);
            foreach (var item in aList)
                Console.Write(item);
            // newline + newline
            Console.WriteLine('\n');
            // there is a return value but no variable is bound to it
            DoStuff(number);
            Console.WriteLine("Hello, World!");
            // call ReadLine() so that the console will not close immediately after printing
            Console.ReadLine();
        }
    }
}
