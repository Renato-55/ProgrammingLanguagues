using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public enum Size
    {
        SMALL,
        MEDIUM,
        LARGE
    }

    public enum Crust
    {
        THIN,
        THICK
    }

    public enum Cheese
    {
        MOZZARELLA,
        CHEDDAR,
        PARMESAN
    }

    public enum Sauce
    {
        TOMATO,
        BBQ,
        PESTO
    }

    public enum Topping
    {
        PEPPERONI,
        MUSHROOMS,
        ONIONS,
        OLIVES
    }

    public class Pizza
    {
        public Size Size { get; set; }
        public Crust Crust { get; set; }
        public Cheese Cheese { get; set; }
        public Sauce Sauce { get; set; }
        public List<Topping> Toppings { get; set; }

        public Pizza()
        {
            Toppings = new List<Topping>();
        }

        public void Display()
        {
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Crust: {Crust}");
            Console.WriteLine($"Cheese: {Cheese}");
            Console.WriteLine($"Sauce: {Sauce}");
            Console.WriteLine("Toppings:");
            foreach (var topping in Toppings)
            {
                Console.WriteLine($"  {topping}");
            }
        }
    }
}
