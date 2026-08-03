using System;
using System.Xml.Linq;
public class Cal
{
    public int add(int a, int b)
    {
        return a + b;
    
}
    public static float add(float a, float b)
    {
        return a + b;
    }
}
public class TestMemberOverloading
{
    public static void Main()
    {
        Console.WriteLine(Cal.add(12, 23));
        Console.WriteLine(Cal.add(12.4f, 21.3f));
    }
}