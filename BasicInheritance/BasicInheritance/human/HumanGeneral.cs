using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance.human
{
    class HumanGeneral
    {
        private byte head;
        private byte hends;
        private byte legs;
        private int mind;
        public byte Head
        {
            get { return head; }
            set
            {
                if (value.GetType() == typeof(byte))
                {
                    head = value;
                }
                else
                {
                    Console.WriteLine("\n\n\n\t\t\tSome error happened!!!\n May be Head not \"BYTE\" ???");
                }
            }
        }

        public byte Hends
        {
            get { return hends; }
            set
            {
                if (value.GetType() == typeof(byte))
                {
                    hends = value;
                }
                else
                {
                    Console.WriteLine("\n\n\n\t\t\tSome error happened!!!\n May be Hends not \"BYTE\" ???");
                }
            }
        }

        public byte Legs {
            get { return legs; }
            set
            {
                if (value.GetType() == typeof(byte))
                {
                    legs = value;
                }
                else
                {
                    Console.WriteLine("\n\n\n\t\t\tSome error happened!!!\n May be Legs not \"BYTE\" ???");
                }
            }
        }

        public int Mind {
            get { return mind; }
            set
            {
                if (value.GetType() == typeof(int))
                {
                    mind = value;
                }
                else
                {
                    Console.WriteLine("\n\n\n\t\t\tSome error happened!!!\n May be Mind not \"Int\" ???");
                }
            }
        }

        public HumanGeneral()
        {
            Head = 255;
            Hends = 255;
            Legs = 255;
            Mind = System.Int16.MaxValue;
            SetConsoleMessages("Super human create ... success\n "+Mind.ToString());
        }

        public HumanGeneral( byte _head, byte _hends, byte _legs, int _mind)
        {
            Head = _head;
            Hends = _hends;
            Legs = _legs;
            Mind = _mind;
            SetConsoleMessages(Head.ToString()+"\n"+Hends.ToString()+"\n"+Legs.ToString()+"\n"+Mind.ToString());
        }

        private void SetConsoleMessages (string mess)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t"+mess);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
