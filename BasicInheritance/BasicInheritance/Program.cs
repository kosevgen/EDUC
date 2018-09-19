using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicInheritance.message;
using BasicInheritance.human.Ukraine;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("***Program is run!!!***\n\n\n");
            UkrainianHuman ukrainianHuman = new UkrainianHuman();
            ukrainianHuman.Love();
            ukrainianHuman.Emotion();
            ukrainianHuman.Job();
            Console.ReadKey();
        }
    }
}
