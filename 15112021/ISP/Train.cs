using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    class Train:IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
      

        public void Drive(int km)
        {
            //process
        }
    }
}
