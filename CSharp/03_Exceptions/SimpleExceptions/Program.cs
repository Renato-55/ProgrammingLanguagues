using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SampleException.ThrowException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[-] Exception caught: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("[!] The 'try catch' is finished.");
            }

            Console.WriteLine("\n\n");

            try
            {
                SampleException.ThrowMathException();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("[-] Division by Zero Exception caught: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[-] Exception caught: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("[!] The 'try catch' is finished.");
            }

            Console.WriteLine("\n\n");

            try
            {
                SampleException.ThrowCustomException();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("[-] Division by Zero Exception caught: " + ex.Message);
            }
            catch (CustomException ex)
            {
                Console.WriteLine("[-] Custom Exception caught: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[-] Exception caught: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("[!] The 'try catch' is finished.");
            }

        }
    }
}
