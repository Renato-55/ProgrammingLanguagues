// dog.cs
namespace ClassTest
{
    class Dog : Animal // Derived class (child)
    {
        public override void  animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}
