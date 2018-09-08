using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance.human
{
    interface HumanGeneral
    {
        DateTime BornDate
        {
            get;
            set;
        }
        long IdNumber
        {
            get;
            set;
        }
        string PassportId
        {
            get;
            set;
        }

    }
}
