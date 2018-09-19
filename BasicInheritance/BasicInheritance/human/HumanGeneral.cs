using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance.human
{
    interface IHumanGeneral
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
        Object Father
        {
            get;
            set;
        }
        Object Mather
        {
            get;
            set;
        }
        Object Sister
        {
            get;
            set;
        }
        Object Brother
        {
            get;
            set;
        }
        void Love();
        void Emotion();
        

    }
}
