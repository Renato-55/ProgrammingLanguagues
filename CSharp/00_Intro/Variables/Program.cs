using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            variableTypes();
            typeCasting();
            // Difference beetween variables and constants.
            // R: an constants cannot have their value reasigned

            // We can have multiple variable declarations like the following example
            // int x = 5, y = 6, z = 50;
            // Console.WriteLine(x + y + z);

            // What should I name my variables. Variable names must be unique, identified and descritive 
            //             The general rules for naming variables are:
            // Names can contain letters, digits and the underscore character (_)
            // Names must begin with a letter
            // Names should start with a lowercase letter and it cannot contain whitespace
            // Names are case sensitive ("myVar" and "myvar" are different variables)
            // Reserved words (like C# keywords, such as int or double) cannot be used as names

        }

        static void variableTypes() 
        {
            // In C#, there are different types of variables (defined with different keywords), for example:

            /* 
            int - stores integers (whole numbers), without decimals, such as 123 or -123
            double - stores floating point numbers, with decimals, such as 19.99 or -19.99
            char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
            string - stores text, such as "Hello World". String values are surrounded by double quotes
            bool - stores values with two states: true or false
            */
            int intValue = 123;
            double doubleValue = 19.99;
            char charValue = 'A';
            string stringValue = "Hello World";
            bool boolValue = true;

            Console.WriteLine("\n\t *** Variable Information ***\n");
            Console.WriteLine("+------------+----------------+---------------------+-------------------+");
            Console.WriteLine("|   Type     |      Name      |         Value       |      Data Type    |");
            Console.WriteLine("+------------+----------------+---------------------+-------------------+");
            Console.WriteLine($"|    int     |   intValue     |         {intValue}         |  {intValue.GetType()}     |");
            Console.WriteLine($"|   double   |  doubleValue   |       {doubleValue}         |  {doubleValue.GetType()}    |");
            Console.WriteLine($"|    char    |   charValue    |          {charValue}          |  {charValue.GetType()}      |");
            Console.WriteLine($"|   string   | stringValue    |   \"{stringValue}\"     |  {stringValue.GetType()}    |");
            Console.WriteLine($"|    bool    |   boolValue    |        {boolValue}         |  {boolValue.GetType()}   |");
            Console.WriteLine("+------------+----------------+---------------------+-------------------+");
            Console.WriteLine("\n");

        }

        static void typeCasting()
        {
            // Implicit Casting (Widening)
            int intValue = 10;
            double doubleValue = intValue; // Automatically converted to double
            Console.WriteLine($"Implicit Casting: int to double - {doubleValue}");

            // Explicit Casting (Narrowing)
            double largerValue = 19.99;
            int smallValue = (int)largerValue; // Manually cast double to int
            Console.WriteLine($"Explicit Casting: double to int - {smallValue}");

            // String to Number Conversion
            string numericString = "123";
            int parsedNumber = int.Parse(numericString); // Convert string to int
            Console.WriteLine($"String to Number Conversion: {parsedNumber}");
        }
    }
}
