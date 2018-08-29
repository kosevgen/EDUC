using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance.human
{
    class EuropeansHuman : HumanGeneral
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
        public EuropeansHuman()
        {
            skinColorBlack = 80;
        }

        public void PublicTestFunc(byte bt)
        {
            Console.WriteLine("Test protect funk ... " + bt);
        }

        protected void ProtectedTestFunc(string mess)
        {
            Console.WriteLine("mess");
        }
    }
}
