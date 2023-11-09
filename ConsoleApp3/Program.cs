using System.Runtime.InteropServices.Marshalling;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog animal= new Dog();
            animal.Sound();
            Cat cat = new Cat();
            cat.Sound();
            Duck duck = new Duck();
            duck.Sound();

         


        }
    }
}

class Animal
{
    public virtual void Sound()
    {
        Console.Write($"This animals sound:  ");
    }
}
class Dog:Animal
{
    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Bow Bow ");
    }
}
class Cat:Animal
{
    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Meow Meow");
    }
}
class Duck:Animal
{
    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("quack quack");
    }
}



