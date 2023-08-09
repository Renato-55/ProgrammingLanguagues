using System;

namespace FunctionExample
{
    class Program
    {
        static void ifElse()
        {
            Console.WriteLine("\nifElse()");
            int number = 10;

            if (number > 5)
            {
                Console.WriteLine("Number is greater than 5");
            }
            else
            {
                Console.WriteLine("Number is not greater than 5");
            }
        }

        static void forLoop()
        {
            Console.WriteLine("\nforLoop()");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }
        }

        static void whileLoop()
        {
            Console.WriteLine("\nwhileLoop()");
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine($"Count: {count}");
                count++;
            }
        }

        static void breakContinue()
        {
            Console.WriteLine("\nbreakContinue()");
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Breaking the loop");
                    break;
                }
                Console.WriteLine($"Iteration {i}");
            }
        }

        static void Arrays()
        {
            Console.WriteLine("\nArrays()");
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int num in numbers)
            {
                Console.WriteLine($"Number: {num}");
            }
        }

        static void Switch()
        {
            Console.WriteLine("\nSwitch()");
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Other day");
                    break;
            }
        }

        static void Main(string[] args)
        {
            ifElse();
            forLoop();
            whileLoop();
            breakContinue();
            Arrays();
            Switch();
        }
    }
}
