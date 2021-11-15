using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    class Car : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get ; set; }
        public int FuelCapacity { get ; set ; }

        public void AddFuel(int fuel)
        {
            //prosess
        }

        public void Drive(int km)
        {
            //process
        }
    }
}
