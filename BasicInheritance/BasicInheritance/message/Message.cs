using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Message
    {
        public Message()
        {
            Console.Clear();
            Console.Title = "Console Massage";
            Console.SetWindowSize(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.SetWindowPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public Message(String title)
        {
            Console.Clear();
            Console.Title = title;
            Console.SetWindowSize(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.SetWindowPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
        }

        public virtual void writeMessages(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadKey();
            Console.Clear();
        }

        public void getConsoleSate()
        {
            Console.Write("\t Title" + Console.Title + "\n");
            Console.Write("\t Window size = " + Console.WindowHeight + " X " + Console.WindowWidth+ "\n");
            Console.Write("\t Background color " + Console.BackgroundColor + "\n");
            Console.Write("\t Foreground color " + Console.ForegroundColor + "\n");
            Console.Write("\t Windows buffer " + Console.BufferWidth + "\n");
            Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
