using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============Pizza Builder Pattern==============");

            PizzaBuilder builder = new PizzaBuilder();

            Pizza pizza1 = builder
                .SetSize(Size.LARGE)
                .SetCrust(Crust.THIN)
                .SetCheese(Cheese.MOZZARELLA)
                .SetSauce(Sauce.TOMATO)
                .AddTopping(Topping.PEPPERONI)
                .AddTopping(Topping.MUSHROOMS)
                .Build();

            Pizza pizza2 = builder
                .SetSize(Size.MEDIUM)
                .SetCrust(Crust.THICK)
                .SetCheese(Cheese.CHEDDAR)
                .SetSauce(Sauce.BBQ)
                .AddTopping(Topping.ONIONS)
                .Build();

            Console.WriteLine("Pizza 1:");
            pizza1.Display();

            Console.WriteLine("\nPizza 2:");
            pizza2.Display();
        }
    }
}
