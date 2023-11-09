namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add: " + Calculator.Add(5, 3));
            Console.WriteLine("Subtract: " + Calculator.Subtract(8, 4));
            Console.WriteLine("Multiply: " + Calculator.Multiply(2.5, 4));
            Console.WriteLine("Divide: " + Calculator.Divide(10, 2));
            Console.WriteLine("AbsoluteValue: " + Calculator.AbsoluteValue(-7));
            Console.WriteLine("Power: " + Calculator.Pow(4));

        }
    }
}

class Calculator
{
 
    public static dynamic Add(dynamic a, dynamic b)
    {
        return a + b;
    }

    public static dynamic Subtract(dynamic a, dynamic b)
    {
        return a - b;
    }

    public static dynamic Multiply(dynamic a, dynamic b)
    {
        return a * b;
    }


    public static dynamic Divide(dynamic a, dynamic b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Nolga bo'lib bo'lmaydi!");
            return null;
        }
    }


    public static dynamic AbsoluteValue(dynamic a)
    {
        return Math.Abs(a);
    }


    public static dynamic Pow(dynamic a)
    {
        return Math.Pow(a, 2);
    }
}




