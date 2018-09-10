using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance.human
{
    interface IEuropeansHuman
    {
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
