using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance.human
{
    interface EuropeansHuman
    {
        string Address
        {
            get;
            set;
        }
        string SkinColor
        {
            get;
            set;
        }
        string Country //maybe not
        {
            get;
            set;
        }        
    }
}
