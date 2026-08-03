using System;

namespace multipleinterfaces
{
    public interface IOrderService
    {
        void ProcessOrder();
    }
    public class StanderDilavery : IOrderService
    {
        public void ProcessOrder() {
            Console.Write("Enter item name for Standerd Dilavery: ");
            string item = Console.ReadLine();
            Console.WriteLine(item);
        }  
    }
    public class ExpressDilavery : IOrderService
    {
        public void ProcessOrder()
        {
            Console.Write("Enter item name for Express Dilavery: ");
            string item = Console.ReadLine();
            Console.WriteLine(item);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IOrderService service;
            service = new StanderDilavery();
            Console.WriteLine("as");
            service.ProcessOrder();
        }
    }
}
