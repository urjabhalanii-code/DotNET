using System;

namespace PlusOperator
{
    class class1
    {
        public int rno;
        public string name;

        public class1(int n, string nm)
        {
            rno = n;
            name = nm;
        }
        public static class1 operator + (class1 c1)
        {
            c1.rno = c1.rno + 100;
            c1.name = "Hello " + c1.name;
            return c1;
        }
        public void Print()
        {
            Console.WriteLine("Roll no. : " + rno);
            Console.WriteLine("Name : " + name);
        }
        static void Main(string[] args)
        {
            class1 calc = new class1(10, "Urja");
            calc.Print();
            calc = +calc;
            Console.WriteLine("\n----------------------After Operator Overloding------------------------");
            calc.Print();
            Console.ReadKey();
        }
    }
}
