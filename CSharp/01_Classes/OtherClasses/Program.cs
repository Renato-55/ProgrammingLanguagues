using System;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*** Inheritance ***/
            Console.WriteLine("\nInheritance");
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            /*** Polymorphism ***/
            Console.WriteLine("\nPolymorphism");
            Animal myAnimal = new Animal(); // Create a Animal object
            Animal myPig = new Pig(); // Create a Pig object
            Animal myDog = new Dog(); // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            /*** Abstraction ***/
            Console.WriteLine("\nAbstraction");
            PigAbstraction myPig1 = new PigAbstraction(); // Create a Pig object
            myPig1.animalSound(); // Call the abstract method
            myPig1.sleep(); // Call the regular method
        }
    }
}