using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01
{
    internal class Variable
    {
        static void Main(string[] args) 
        {
            int a = 10;
            long b = 10000000000;
            double c = 1.23;
            char d = 'A';
            string e = "Hello, C#!";
            bool f = true;
            const int myNum = 15;
            //myNum = 20; // error
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            Console.WriteLine($"{a}, {b}, {c}, {d}, {e}, {f}");
            /*
                Data Type      Size                    Description
                -----------------------------------------------------------------------------------------
                int            4 bytes                 Stores whole numbers from -2,147,483,648 to 2,147,483,647
                long           8 bytes                 Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
                float          4 bytes                 Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
                double         8 bytes                 Stores fractional numbers. Sufficient for storing 15 decimal digits
                bool           1 byte                  Stores true or false values
                char           2 bytes                 Stores a single character/letter, surrounded by single quotes
                string         2 bytes per character   Stores a sequence of characters, surrounded by double quotes
            */
            
                int myInt = 9;
                double myDouble = myInt;       

                Console.WriteLine(myInt);     
                Console.WriteLine(myDouble);

                int myInt1 = 10;
                double myDouble1 = 5.25;
                bool myBool = true;
                string myString = "true";
                Console.WriteLine(Convert.ToString(myInt1));    // convert int to string
                Console.WriteLine(Convert.ToDouble(myInt1));    // convert int to double
                Console.WriteLine(Convert.ToInt32(myDouble1));  // convert double to int
                Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
                Console.WriteLine(Convert.ToBoolean(myString));
                /*
                    TYPE CASTING IN C#

                    1. Implicit Casting (automatically): 
                       Converting a smaller type to a larger type size.
                       Sequence: char -> int -> long -> float -> double

                    2. Explicit Casting (manually): 
                       Converting a larger type to a smaller size type.
                       Sequence: double -> float -> long -> int -> char
                       Note: Requires placing the type in parentheses, e.g., (int)myDouble;
                *Type Conversion method*
                *Convert.ToBoolean
                *Convert.ToDouble
                *Convert.ToString
                *Convert.ToInt32 (int) 
                *Convert.ToInt64 (long):
                */
        }
    }
}
