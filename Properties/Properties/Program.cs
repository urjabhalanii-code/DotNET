using System;

namespace Properties
{
    public class Employee
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "Test";
            Console.WriteLine("Employee Name: "+e1.Name);
            Console.ReadKey();
        }
    }
}
