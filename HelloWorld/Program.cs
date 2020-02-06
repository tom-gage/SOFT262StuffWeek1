using System;

namespace DepartmentOfTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver commuter1 = new Driver(Name: "Regular Dave", new Car(EngineSerialNumber: 12345, HasTowBarFitted: true));
            Driver commuter2 = new Driver(Name: "Cool Dave", new Motorbike(EngineSerialNumber: 333555));
            Driver commuter3 = new Driver(Name: "Peasant Dave", null);

            Console.WriteLine(commuter1.Description);
            Console.WriteLine(commuter2.Description);
            Console.WriteLine(commuter3.Description);
        }
    }
}
