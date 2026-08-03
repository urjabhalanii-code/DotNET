using System;

namespace Armstrong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rem, num, temp, sum = 0;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("Number is an Armstrong number");
            }
            else
            {
                Console.WriteLine("Number is not an Armstrong number");
            }
            Console.ReadKey();
        }

    }
    
}
