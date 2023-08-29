using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============Pizza Factory Method==============");
            Console.WriteLine("Choose a pizza: ");
            Console.WriteLine("M - Mozarela");
            Console.WriteLine("C - Calabresa");
            string type = Console.ReadLine().ToUpper();

            try
            {
                Pizza pizza = PizzaFactory.CreatePizza(type);
                Console.WriteLine("Pizza {0} is ready!", pizza.GetPizzaName());
                
                Console.WriteLine("\n==============Preparing Pizza==============\n{0}", pizza.PreparePizza());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}