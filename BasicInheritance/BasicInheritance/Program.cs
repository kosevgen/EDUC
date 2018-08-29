using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicInheritance.message;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            human.HumanGeneral humanGen = new human.HumanGeneral();
            human.HumanGeneral koresh = new human.HumanGeneral(200, 230, 150, 300_000);

            //Message infoMessage = new Message();
            //infoMessage.writeMessages("Helo World");

            //ErrorMessage errorMessage = new ErrorMessage();
            //errorMessage.writeMessages("\t\t\tERROR\n\t!!!This is error message!!!");
            //errorMessage.getConsoleSate();

            //SuccessfullyMessage successfullyMessage = new SuccessfullyMessage();
            //successfullyMessage.writeMessages("\t\t\tSUCCESS!!!\n\t!!!This is success message!!!");
            //successfullyMessage.getConsoleSate();
        }
    }
}
