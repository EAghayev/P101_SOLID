using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    class Email:IMessage
    {
        public void Send()
        {
            Console.WriteLine("Email uzerinden mesaj gonderildi!");
        }
    }
}
