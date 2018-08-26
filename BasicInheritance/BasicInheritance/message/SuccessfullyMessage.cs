using System;

namespace BasicInheritance.message
{
    class SuccessfullyMessage : Message
    {
        public SuccessfullyMessage()
        {
            Console.Clear();
            Console.Title = "Error Massage";
            Console.SetWindowSize(65, 20);
            Console.SetWindowPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public override void writeMessages(string message)
        {
            Console.Clear();
            Console.WriteLine("\t\t\tThis is success message!!!\n\n");
            Console.WriteLine(message);
            Console.WriteLine("\tAll is well\n");
            Console.WriteLine("\tNo need to do anything...\n\n\n");
            Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
