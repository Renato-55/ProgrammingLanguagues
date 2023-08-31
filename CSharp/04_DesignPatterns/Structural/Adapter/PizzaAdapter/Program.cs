using System;
using System.Collections.Generic;

namespace AdapterPizzaPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============Adapter Pizza Ordering==============");

            // Create instances of the new system and the adapter
            var newSystem = new NewPizzaOrderingSystem();
            var adapter = new NewToLegacyAdapter(newSystem);

            // Use the adapter to place an order (using the old system's expectations)
            adapter.PlaceLegacyOrder("Pepperoni");
            adapter.PlaceLegacyOrder("Margherita");

            // Using the legacy system directly
            var legacySystem = new LegacyPizzaOrderingSystem();
            legacySystem.PlaceLegacyOrder(new List<string> { "Hawaiian", "Pepperoni" });
        }
    }
}
