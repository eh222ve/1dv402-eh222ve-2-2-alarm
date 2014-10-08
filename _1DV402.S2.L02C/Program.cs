using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using _1DV402.S2.L02C.Properties;

namespace _1DV402.S2.L02C
{
    class Program
    {
        static void Main(string[] args)
        {
            MyExtensions.PrettyConsole("Alarmklockan");

            MyExtensions.ChangeColor(ConsoleColor.White, ConsoleColor.DarkMagenta);
            Console.WriteLine(" ╔═════════════════════════════════╗ ");
            Console.WriteLine(" ║     Alarmklockan URLED (TM)     ║ ");
            Console.WriteLine(" ║    Modellnummer: 1DV402S2L2C    ║ ");
            Console.WriteLine(" ║      Tillverkad av: eh222ve     ║ ");
            Console.WriteLine(" ╚═════════════════════════════════╝ ");
            MyExtensions.ChangeColor();

            AlarmClock ac = new AlarmClock("20:56", new string[3] { "20:57", "21:00", "21:12" });

            Console.WriteLine("Test 1:");
            Console.WriteLine("Test av standardkonstruktorn");
            try
            {
                AlarmClock t1AC = new AlarmClock();
                Console.WriteLine(t1AC.ToString());
            }
            catch (Exception)
            {
                MyExtensions.ViewMessage("fel", ConsoleColor.Red);
            }

            for (int i = 0; i < 20; i++)
            {
                if (ac.TickTock())
                {
                    
                    Console.WriteLine("Alarms went off");
                }
                Console.WriteLine(ac.ToString());
            }

            Console.ReadLine();
        }
    }
}
