using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class BMW : Car, IAirConditioner
    {
        public override void Start()
        {
            Console.WriteLine("BMW started");
        }

        public  void StartAirconditioner()
        {
            Console.WriteLine("BMW airconditioner started");
        }
    }
}
