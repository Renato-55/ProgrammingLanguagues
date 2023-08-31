using System;

namespace SingletonPattern
{
    // Singleton clas
    class Program
    {
static void Main(string[] args)
        {
            Console.WriteLine("==============Singleton Pizza Ordering System==============");

            // Access the pizza ordering system instance
            var orderingSystem1 = PizzaOrderingSystem.GetInstance();
            var orderingSystem2 = PizzaOrderingSystem.GetInstance();

            // Both instances are the same
            Console.WriteLine($"Is orderingSystem1 the same instance as orderingSystem2 ? {ReferenceEquals(orderingSystem1, orderingSystem2)}\n");

            // Place orders using the singleton instance
            orderingSystem1.PlaceOrder("Pepperoni");
            orderingSystem2.PlaceOrder("Margherita");
            orderingSystem1.PlaceOrder("Hawaiian");
        }
    }
}