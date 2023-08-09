// animal.cs
namespace ClassTest
{
    abstract class AnimalAbstraction // Base class (parent)
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();

        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}
