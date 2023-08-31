using System;
using System.Collections.Generic;

namespace AdapterPizzaPattern
{
    // Adaptee: The legacy pizza ordering system
    public class LegacyPizzaOrderingSystem
    {
        public void PlaceLegacyOrder(List<string> pizzas)
        {
            Console.WriteLine("Placing a legacy pizza order:");
            foreach (var pizza in pizzas)
            {
                Console.WriteLine($" - {pizza} pizza ordered");
            }
        }
    }

    // Target: The new pizza ordering system
    public interface INewPizzaOrderingSystem
    {
        void PlaceNewOrder(string pizzaType);
    }

    // Adapter: Adapter to use the new system with the old system's expectations
    public class NewToLegacyAdapter : LegacyPizzaOrderingSystem
    {
        private readonly INewPizzaOrderingSystem newSystem;

        public NewToLegacyAdapter(INewPizzaOrderingSystem newSystem)
        {
            this.newSystem = newSystem;
        }

        public void PlaceLegacyOrder(string pizzaType)
        {
            newSystem.PlaceNewOrder(pizzaType);
        }
    }

    // Concrete implementation of the new system
    public class NewPizzaOrderingSystem : INewPizzaOrderingSystem
    {
        public void PlaceNewOrder(string pizzaType)
        {
            Console.WriteLine($"Placing a new {pizzaType} pizza order.");
        }
    }
}
