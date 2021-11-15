using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class Qaz31 : Car
    {
        public override void Start()
        {
            Console.WriteLine("Qaz31 started");
        }

        //public override void StartAirconditioner()
        //{
        //    throw new NotImplementedException();
        //}

        //public override void StartAirconditioner()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
