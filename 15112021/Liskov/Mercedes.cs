using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class Mercedes : Car, IAirConditioner
    {
        public override void Start()
        {
            Console.WriteLine("Mercedes started");
        }

        public  void StartAirconditioner()
        {
            Console.WriteLine("Mercedes airconditioner started");
        }
    }
}
