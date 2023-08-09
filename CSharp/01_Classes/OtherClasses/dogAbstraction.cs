// dog.cs
namespace ClassTest
{
    class DogAbstraction : AnimalAbstraction // Derived class (child)
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The dog says: bow wow");
        }
    }
}
