using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            strFunctions();
            concatenation();
            interpolation();
            acessStrings();
        }

        static void acessStrings()
        {
            string myString = "Hello";
            Console.WriteLine(myString[0]); // Outputs "H"
            Console.WriteLine(myString[1]); // Outputs "e"
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);
        }

        static void strFunctions()
        {
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("\n" + txt);
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            txt = "Hello World";
            Console.WriteLine("\n" + txt);
            Console.WriteLine(txt.ToUpper()); // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower()); // Outputs "hello world"
        }

        static void concatenation()
        {
            // whitout string concat
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine("\nString Concatenation" + name);

            // whit string concat
            firstName = "John ";
            lastName = "Doe";
            name = string.Concat(firstName, lastName);
            Console.WriteLine(name);
        }

        static void interpolation()
        {
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine("\nInterpolation" + name);
        }
    }
}
