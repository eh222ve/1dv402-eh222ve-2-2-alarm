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
        private static string HorizontalLine = "═══════════════════════════════════════════";

        static void Main(string[] args)
        {
            MyExtensions.PrettyConsole("Alarmklockan");

            MyExtensions.ChangeColor(ConsoleColor.White, ConsoleColor.DarkMagenta);
            Console.WriteLine(" ╔═════════════════════════════════════════╗ ");
            Console.WriteLine(" ║         Alarmklockan URLED (TM)         ║ ");
            Console.WriteLine(" ║        Modellnummer: 1DV402S2L2C        ║ ");
            Console.WriteLine(" ║          Tillverkad av: eh222ve         ║ ");
            Console.WriteLine(" ╚═════════════════════════════════════════╝ ");
            MyExtensions.ChangeColor();



            AlarmClock ac = new AlarmClock();

            ViewTestHeader("Test 1", "Test av standardkonstruktorn");
                try
                {
                    ac = new AlarmClock();
                    Console.WriteLine(ac.ToString());
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }

            ViewTestHeader("Test 2", "Test av konstruktorn med två parametrar:");
                try
                {
                    ac = new AlarmClock(9, 42);
                    Console.WriteLine(ac.ToString());
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }

            ViewTestHeader("Test 3", "Test av konstruktorn med fyra parametrar:");
                try
                {
                    ac = new AlarmClock(13, 24, 7, 35);
                    Console.WriteLine(ac.ToString());
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }

            ViewTestHeader("Test 4", "Test av konstruktorn med minst två parametrar:");
                try
                {
                    ac = new AlarmClock("7:07", "7:10", "7:15", "7:30");
                    Console.WriteLine(ac.ToString());
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }

            ViewTestHeader("Test 5", "Ställer ett befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.");
                try
                {
                    ac.Time = "23:58";
                    Run(ac, 13);
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }
            ViewTestHeader("Test 6", "Ställer befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 och låter den gå 6 minuter.");
                try
                {
                    ac.Time = "6:12";
                    ac.AlarmTimes = new string[1] { "6:15" };
                    Run(ac, 6);
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }
             ViewTestHeader("Test 7", "Test av egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
                try
                {
                    ac.Time = "24:89";
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }
                try
                {
                    ac.AlarmTimes = new string[1] { "7:69" };
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }
            ViewTestHeader("Test 8", "Test av konstruktorer så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
                try
                {
                    ac = new AlarmClock("32:03");
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }
                try
                {
                    ac = new AlarmClock("20:00", "27:00");
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }

            Console.ReadLine();
        }

        private static void ViewTestHeader(string title, string description) {

            Console.WriteLine();
            MyExtensions.ViewMessage(HorizontalLine, ConsoleColor.DarkMagenta);
            Console.WriteLine();
            MyExtensions.ViewMessage(title, ConsoleColor.DarkMagenta);
            Console.WriteLine();
            Console.WriteLine(description);
            Console.WriteLine();
                   
        }

        private static void ViewErrorMessage(string message) {
            MyExtensions.ViewMessage(message, ConsoleColor.White, ConsoleColor.Red);
        }

        private static void Run(AlarmClock ac, int minutes) {
            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock())
                {
                    MyExtensions.ViewMessage(String.Format("{0} - It's alarmtime!", ac.ToString()), ConsoleColor.White, ConsoleColor.DarkMagenta);
                }

                Console.WriteLine(ac.ToString());
            }
        
        }
    }
}
