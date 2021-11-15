using System;
using System.Collections.Generic;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Email email = new Email();
            //email.Send();

            //SMS sms = new SMS();
            //sms.Send();

            Email email = new Email();
            SMS sms = new SMS();
            Whatsapp  wp= new Whatsapp();
            Facebook facebook = new Facebook();

            List<IMessage> messageSenders = new List<IMessage>();
            messageSenders.Add(email);
            messageSenders.Add(sms);
            messageSenders.Add(wp);
            messageSenders.Add(facebook);

            Notification notification = new Notification(messageSenders);
            notification.Send();
        }
    }
}
