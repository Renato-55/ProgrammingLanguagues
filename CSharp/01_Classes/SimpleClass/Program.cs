using System;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit banana = new Fruit();
            Console.WriteLine("Fruit name: {0} - Color: {1}", banana.name, banana.color);
        }
    }

    // Class declaration
    public class Fruit
    {
        public string color { get; set; }
        public string name { get; set; }
        public Boolean isExpired = false;

        // Default constructor
        public Fruit()
        {
            this.color = "";
            this.name = "banana";
        }
    
        // constructor whit parms
        public Fruit(string _color, string _name = "banana", Boolean _isExpired = false)
        {
            this.color = _color;
            this.name = _name;
        }
    }
}