using System;

namespace calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1 and Number 2: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition is: " + add(n1, n2));
            Console.WriteLine("Subtraction is: " + sub(n1, n2));
            Console.WriteLine("Multiplication is: " + mul(n1, n2));
            Console.WriteLine("Divition is: " + div(n1, n2));
            Console.ReadKey();
        }
        static int add(int n1, int n2)
        {
            return n1 + n2;
        }
        static int sub(int n1, int n2)
        {
            return n1 - n2;
        }
        static int mul(int n1, int n2)
        {
            return n1 * n2;
        }
        static int div(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
