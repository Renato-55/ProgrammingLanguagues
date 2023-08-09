using System;

namespace ExceptionTest
{
    class SampleException
    {
        public static void ThrowException()
        {
            Console.WriteLine("[!] Throwing an exception");
            throw new Exception("This is an exception");
        }

        public static void ThrowMathException()
        {
            Console.WriteLine("[!] Throwing a math exception");
            throw new DivideByZeroException("This is a math exception");
        }

        public static void ThrowCustomException()
        {
            Console.WriteLine("[!] Throwing a custom exception");
            throw new CustomException("This is a custom exception");
        }
    }

    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}
