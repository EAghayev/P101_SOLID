using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    class Notification
    {
        List<IMessage> _messages;
            
        public Notification(List<IMessage> messages)
        {
            //_email = new Email();
            //_sms = new SMS();
            //_whatsapp = new Whatsapp();

            _messages = messages;
        }

        public void Send()
        {
            //_email.Send();
            //_sms.Send();
            //_whatsapp.Send();

            foreach (var item in _messages)
            {
                item.Send();
            }
        }
    }
}
