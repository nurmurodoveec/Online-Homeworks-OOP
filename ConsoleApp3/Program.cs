namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Duck duck = new Duck();
            duck.Quack();
            duck.Swim();
            duck.Display();
            
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Quack();
            mallardDuck.Swim();
            mallardDuck.Display();

            ReadheadDuck readheadDuck = new ReadheadDuck();
            readheadDuck.Quack();
            readheadDuck.Swim();
            readheadDuck.Display();


        }
    }
}

class Duck
{
 public void Quack()
    {
        Console.WriteLine("Duck is quacking...");
    }
    public void Swim()
    {
        Console.WriteLine("Duck is starts swimming...");
    }
    public virtual void Display() {
        Console.WriteLine("Other duck like- methods...");
    }
}
class MallardDuck:Duck
{
    public override void Display()
    {
       
        Console.WriteLine("Looks like mallard");
    }
}
class ReadheadDuck:Duck
{
    public override void Display()
    {
   
        Console.WriteLine("Looks like a readhead...");
    }
}




