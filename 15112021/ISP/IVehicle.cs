using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        void Drive(int km);
    }
}
