using System;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str, rev = "";
            Console.Write("Enter String: ");
            str= Console.ReadLine();
            int i, l;
            l = str.Length - 1;
            for (i = l; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            if (rev == str)
            {
                Console.WriteLine("Given String is Palindrome");

            }
            else
            {
                Console.WriteLine("Given String is not Palindrom");
            }
        }
    }
}
