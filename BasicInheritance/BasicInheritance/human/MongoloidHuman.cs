using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance.human
{
    class MongoloidHuman : HumanGeneral
    {
        private byte skinColorBlack;
        public byte SkinColorBlack
        {
            get { return skinColorBlack; }
            set
            {
                if (value.GetType() == typeof(byte))
                {
                    skinColorBlack = value;
                }
                else
                {
                    Console.WriteLine("\n\n\n\t\t\tSome error happened!!!\n May be veriable not \"BYTE\" ???");
                }
            }
        }
        public MongoloidHuman()
        {
            skinColorBlack = 140;
        }
    }
}
