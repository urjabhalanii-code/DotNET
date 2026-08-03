using System;

namespace Boxing_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 24;
            Object obj = num;
            int i = (int)obj;

            Console.WriteLine("num Type: " + num.GetType());
            Console.WriteLine("obj Type: " + obj.GetType());
            Console.WriteLine("i Type: " + i.GetType());
            Console.ReadKey();
        }
    }
}
