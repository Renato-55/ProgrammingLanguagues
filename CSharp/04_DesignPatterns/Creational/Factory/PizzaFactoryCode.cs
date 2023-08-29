using System;
using System.Text;
using System.Collections.Generic;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        protected string Name { get; set; }
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public string PreparePizza()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Preparing " + Name);
            sb.AppendLine("Tossing dough... " + dough);
            sb.AppendLine("Adding sauce..." + sauce);
            sb.AppendLine("Adding toppings: ");
            foreach (string topping in toppings)
            {
                sb.AppendLine(topping);
            }
            sb.AppendLine(Bake());
            sb.AppendLine(Cut());

            return sb.ToString();
        }

        public string GetPizzaName()
        {
            return Name;
        }

        public virtual string Bake()
        {
            return "Bake for 25 minutes at 350";
        }

        public virtual string Cut()
        {
            return "Cutting the pizza into diagonal slices";
        }
    }

    public class PizzaMozarela : Pizza
    {
        public PizzaMozarela()
        {
            Name = "Mozarela";
            dough = "Thin Crust";
            sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Fresh Mozzarella");
        }
    }

    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa()
        {
            Name = "Calabresa";
            dough = "Thin Crust";
            sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Fresh Tomato");
        }
        public override string Cut()
        {
            return "Cutting the pizza into Squad slices because this is a Calabresa Pizza";
        }
    }


    public sealed class PizzaFactory
    {
        public static Pizza CreatePizza(string type)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            return factory.CreatePizza(type);
        }
    }

    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("M"))
            {
                pizza = new PizzaMozarela();
            }
            else if (type.Equals("C"))
            {
                pizza = new PizzaCalabresa();
            }

            return pizza;
        }
    }

}
