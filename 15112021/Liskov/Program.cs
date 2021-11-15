using System;

namespace Liskov
{
    class Program
    {
        static void Main(string[] args)
        {

            BMW bMW = new BMW();
            Mercedes mercedes = new Mercedes();
            Qaz31 qaz31 = new Qaz31();


            bMW.Start();
            bMW.StartAirconditioner();

            mercedes.Start();
            mercedes.StartAirconditioner();

            qaz31.Start();
            //qaz31.StartAirconditioner();
        }

    }
}
