using System;

namespace BasicInheritance.message
{
    class ErrorMessage : Message
    {
        public ErrorMessage()
        {
            Console.Clear();
            Console.Title = "Error Massage";
            Console.SetWindowSize(65, 20);
            Console.SetWindowPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public override void writeMessages(string message)
        {
            Console.Clear();
            Console.WriteLine("\t\t\tThis ERROR!!!\n\n");
            Console.WriteLine(message);
            Console.WriteLine("\tYou have to do something\n");
            Console.WriteLine("\tIf you do not do anything, the error will repeat itself\n\n\n");
            Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
