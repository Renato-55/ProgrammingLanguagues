// pig.cs
namespace ClassTest
{
    class PigAbstraction : AnimalAbstraction // Derived class (child)
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
