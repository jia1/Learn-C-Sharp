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
        public static int DoStuff(ref int n)
        {
            int value = (int)Math.Pow(n, 2);
            Console.WriteLine("DoStuff() is called and the return value will be " + value);
            n = value;
            return value;
        }

        // static void PrintPeople(string[] names) { ... }
        // PrintPeople(new string[] { "A", "B", "C" });
        // static void PrintPeople(params string[] names) { ... }
        // PrintPeople("A", "B", "C");
        // params can only be used once per function, and must be the last parameter

        // Plus(int a, int b) { return Plus(a, b, 0); }
        // Plus(int a, int b, int c) { return Plus(a, b, c, 0); }
        // Plus(int a, int b, int c, int d) { return Plus(a, b, c, d); }

        // public - default for enums and interfaces, 
        // protected - can be reached from within the same class or from a class which inherits, 
        // internal - can be reached from within the same project only, 
        // protected internal - the same as internal + classes which inherit even if different project, 
        // private - members from the same class only, default for classes and structs

        class Car
        {
            private string colour;
            private string onlyColour = "AZURE";
            private int value;
            public Car()
            {
                Console.WriteLine("The Car Constructor with no parameters is called");
            }

            // the constructor with no parameters is called first to instantiate 
            // various objects for the class in the default constructor
            public Car(string colour, int price) : this()
            {
                // this.colour = colour;
                Colour = colour;
                value = price;
            }

            // Destructor
            ~Car()
            {
                Console.WriteLine("The Car Destructor is called");
                Console.ReadLine();
            }

            // property - controls the accessibility of class variables
            public string Colour
            {
                get { return colour.ToUpper(); }
                set
                {
                    value = value.ToUpper();
                    if (value == onlyColour)
                        colour = value;
                    else
                    {
                        Console.WriteLine(value + " is not available.");
                        colour = onlyColour;
                    }
                }
            }

            public string Describe()
            {
                return "The car is " + Colour + " in colour and is worth $" + value;
            }
        }

        static void Main(string[] args)
        {
            // var car may be used
            Car car = new Car("Blue", 1000000);
            Console.WriteLine(car.Describe());
            Console.ReadLine();

            /*
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
            // declare array: string[] anArray;
            // instantiate array: 
            //      anArray = new string[3]; // size - anArray.Length returns 3
            //      OR anArray = { "A", "B", "C" };
            //      OR anArray = new string[3] { "A", "B", "C" }; 
            //      // initializer must be length 3
            string[] alphabet = { "A", "B", "C" };
            // Array.Sort(alphabet) should cause no change to the already-sorted alphabet
            Array.Reverse(alphabet);
            // multidimensional: rectangular (m by n by ...) or 
            //      jagged (row 1 = 1 column, row 2 = 4 columns, ... irregular)
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
            // both number and the return value have the same value
            // due to pass by reference
            DoStuff(ref number);
            Console.WriteLine("Hello, World!");
            // call ReadLine() so that the console will not close immediately after printing
            Console.ReadLine();
            */
        }
    }
}
