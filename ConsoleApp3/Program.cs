namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddNumbers calculator = new AddNumbers();

            int result1 = calculator.Add(2, 3);
            Console.WriteLine("Firs Result: "+result1);
            double result2= calculator.Add(2, 4.5);
            Console.WriteLine("Second Result: "+result2);
            double result3 = calculator.Add(2.5, 4.5,6.5);
            Console.WriteLine("Third Result: " + result3);
            string result4= calculator.Add("Hello ","World!");
            Console.WriteLine("Fourth result: " + result4);
            string result5 = calculator.Add(4, " apples");
            Console.WriteLine("Natija 5: " + result5);

        }
    }
}

class AddNumbers
{
    public int Add(int a , int b)
    { return a + b; }
    public double Add(int a, double b)
    { return a + b; }
    public double Add(double a, double b,double c)
    {
        return a + b + c;
    }
    public string Add (string a, string b)
    { return a + b; }
    public string Add (int a, string b)
    { return a + b; }



}
