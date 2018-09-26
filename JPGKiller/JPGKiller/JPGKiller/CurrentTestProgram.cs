using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPGKiller.Messages;
using System.Threading;

namespace JPGKiller
{
    public class CurrentTestProgram
    {
        public CurrentTestProgram()
        {
             void funcForThread()
             {
                Messages.MessageForm testForm = new Messages.MessageForm("Test messages");
                testForm.Show();
             }
             Thread runMessageWindow = new Thread(new ThreadStart(funcForThread));
             runMessageWindow.Name = "MESS";
             runMessageWindow.Priority = ThreadPriority.Normal;
             runMessageWindow.Start();
        }
    }
}
