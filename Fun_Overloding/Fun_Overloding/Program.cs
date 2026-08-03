using System;
using System.Data;

namespace Fun_Overloding
{
    public class Cal
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static float add(float a, float b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Cal.add(12, 23));
            Console.WriteLine(Cal.add(12.4f, 23.3f));
        }
    }
}
