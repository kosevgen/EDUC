using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JPGKiller.Threads
{
    interface IThread
    {
        Thread CreateThread();
        void SetNameThread(Thread thread, string name);
        bool SetPriorityThread(Thread thread, ThreadPriority priority);
        bool RunThread(Thread thread);
    }
}
