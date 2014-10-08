using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DV402.S2.L02C.Properties;

namespace _1DV402.S2.L02C
{
    public class MyExtensions
    {
        //Displays message to user
        public static void ViewMessage(string message, ConsoleColor backgroundColor = ConsoleColor.Blue, ConsoleColor foregroundColor = ConsoleColor.White)
        {
            MyExtensions.ChangeColor(backgroundColor, foregroundColor);

            Console.WriteLine(message);

            MyExtensions.ChangeColor(ConsoleColor.Black, ConsoleColor.White);
        }

        //Changes appearance of console window
        public static void PrettyConsole(string title, ConsoleColor backgroundColor = ConsoleColor.White, ConsoleColor foregroundColor = ConsoleColor.Black)
        {
            Console.Title = title;
            ChangeColor(foregroundColor, backgroundColor);
            Console.Clear();
        }


        //Changes appearance of console text
        public static void ChangeColor(ConsoleColor foregroundColor = ConsoleColor.Black, ConsoleColor backgroundColor = ConsoleColor.White)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
        }
    }
}