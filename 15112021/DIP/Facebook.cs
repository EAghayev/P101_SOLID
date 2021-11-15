using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    class Facebook : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Mesaj facebook uzerinden gonderildi!");
        }
    }
}
