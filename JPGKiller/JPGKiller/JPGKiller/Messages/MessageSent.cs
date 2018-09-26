using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPGKiller.Messages
{
    public static class MessageSent
    {
        
        static public void SendErrorMessage(string errMess)
        {
            MessageForm messageForm = new MessageForm("Hello!!!");
        }

        static public void SendInfoMessage(string infoMess)
        {
            throw new NotImplementedException();
        }

        static public void SendMessage()
        {
            throw new NotImplementedException();
        }

        static public void SendSuccMessage(string succMess)
        {
            throw new NotImplementedException();
        }
    }
}
