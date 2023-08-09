using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Function that acepts default arguments
            defaultArguments();
            defaultArguments("USA");

            // named elements
            namedElements(child3: "John", child1: "Liam", child2: "Liam");

            // method overloading
            // the first function acepts two ints and the second two doubles
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }

        static string defaultArguments(string country = "Norway")
        {
            Console.WriteLine("Country: " + country);

            // returns the country as well
            return country;
        }

        static void namedElements(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }
}
