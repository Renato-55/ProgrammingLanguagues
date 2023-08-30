namespace BuilderPattern
{
    public class PizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PizzaBuilder SetSize(Size size)
        {
            _pizza.Size = size;
            return this;
        }

        public PizzaBuilder SetCrust(Crust crust)
        {
            _pizza.Crust = crust;
            return this;
        }

        public PizzaBuilder SetCheese(Cheese cheese)
        {
            _pizza.Cheese = cheese;
            return this;
        }

        public PizzaBuilder SetSauce(Sauce sauce)
        {
            _pizza.Sauce = sauce;
            return this;
        }

        public PizzaBuilder AddTopping(Topping topping)
        {
            _pizza.Toppings.Add(topping);
            return this;
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
}
