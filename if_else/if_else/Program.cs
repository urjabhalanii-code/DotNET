using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("Invalid Age...");
            }
            else if (age <= 12)
            {
                Console.WriteLine("Child...");
            }
            else if (age <= 19)
            {
                Console.WriteLine("Teenager...");
            }
            else if (age <= 59)
            {
                Console.WriteLine("Adult...");
            }
            else
            {
                Console.WriteLine("Senior Citizen...");
            }
            Console.ReadKey();

        }
    }
}
