using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentOfTransport
{
    class Car : RoadVehicle
    {
        public bool HasTowBar { get; set; } = false;

        public Car(int EngineSerialNumber, int NumberOfWheels = 4, int CarriageCapacity = 5, bool HasTowBarFitted = false) : base(EngineSerialNumber, NumberOfWheels, CarriageCapacity)
        {
            HasTowBar = HasTowBarFitted;
            Console.WriteLine("car constructor: type " + this.GetType().ToString());
        }


        public override string Description
        {
            get
            {
                if(HasTowBar == true)
                {
                    return base.Description + ": has tow-bar";
                }
                else
                {
                    return base.Description;
                }
                
            }
        }
    }
}
