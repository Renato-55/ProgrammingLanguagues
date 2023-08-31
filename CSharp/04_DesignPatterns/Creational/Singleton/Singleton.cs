using System;

namespace SingletonPattern
{
    // Singleton class representing a pizza ordering system
    public class PizzaOrderingSystem
    {
        private static PizzaOrderingSystem instance;
        private int orderCount;

        // Private constructor to prevent instantiation from outside
        private PizzaOrderingSystem()
        {
            orderCount = 0;
            Console.WriteLine("Pizza ordering system initialized.");
        }

        // Public method to access the singleton instance
        public static PizzaOrderingSystem GetInstance()
        {
            if (instance == null)
            {
                instance = new PizzaOrderingSystem();
            }
            return instance;
        }

        public void PlaceOrder(string pizzaType)
        {
            orderCount++;
            Console.WriteLine($"Order {orderCount}: One {pizzaType} pizza placed.");
        }
    }
}
