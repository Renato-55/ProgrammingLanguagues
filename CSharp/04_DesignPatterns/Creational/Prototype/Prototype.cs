using System;

namespace PrototypePattern
{
    // The prototype interface
    public interface IPizzaPrototype
    {
        IPizzaPrototype Clone();
    }

    // Concrete pizza class
    public class Pizza : IPizzaPrototype
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }

        public Pizza(string name, string dough, string sauce)
        {
            Name = name;
            Dough = dough;
            Sauce = sauce;
        }

        public IPizzaPrototype Clone()
        {
            // Create a new pizza instance with the same properties
            return new Pizza(Name, Dough, Sauce);
        }

        public void Display()
        {
            Console.WriteLine($"Pizza: {Name}");
            Console.WriteLine($"Dough: {Dough}");
            Console.WriteLine($"Sauce: {Sauce}");
        }
    }
}