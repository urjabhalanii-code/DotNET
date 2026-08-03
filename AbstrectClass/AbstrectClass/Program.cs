using System;


namespace AbstrectClass
{
    public abstract class Vehicle
    {
        public abstract void StartEngine();
    }
    public class Car: Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started...!");
        }
    }
    public class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started....");
        }
    }
    public class TestAbstrect
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle;

            myVehicle = new Car();
            myVehicle.StartEngine();

            myVehicle = new Motorcycle();
            myVehicle.StartEngine();
        }
    }
}
