using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============Pizza Prototype Pattern==============");

            // Create the original pizza
            var originalPizza = new Pizza("Pepperoni", "Thin Crust", "Tomato Sauce");

            // Clone the original pizza
            var clonedPizza = originalPizza.Clone() as Pizza;

            // Modify the cloned pizza
            clonedPizza.Name = "Vegetarian";
            clonedPizza.Dough = "Whole Wheat";
            clonedPizza.Sauce = "Pesto Sauce";

            // Display the pizzas
            Console.WriteLine("Original Pizza:");
            originalPizza.Display();

            Console.WriteLine("\nCloned Pizza:");
            clonedPizza.Display();
        }
    }
}
