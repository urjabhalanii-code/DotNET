using System;

namespace MinusOperator
{
    class class1
    {
        
            public int number1,number2;

            public class1(int num1, int num2)
            {
                number1 = num1;
                number2 = num2;
            }
            public static class1 operator -(class1 c1)
            {
                c1.number1 = -c1.number1;
                c1.number2 = -c1.number2;
                return c1;
            }
            public void Print()
            {
                Console.WriteLine("Number1 : " + number1);
                Console.WriteLine("Number2 : " + number2);
            }
            static void Main(string[] args)
            {
                class1 calc = new class1(10, -15);
                Console.WriteLine("\n----------------------After Operator Overloding------------------------");
            
                calc.Print();
                calc = -calc;
                Console.WriteLine("\n----------------------After Operator Overloding------------------------");
                calc.Print();
                Console.ReadKey();
            }
        }
    }