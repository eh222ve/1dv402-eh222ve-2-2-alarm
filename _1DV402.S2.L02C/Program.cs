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
        private static string HorizontalLine = "═══════════════════════════════════════════════";

        static void Main(string[] args)
        {
            MyExtensions.PrettyConsole(Strings.App_Title);

            MyExtensions.ChangeColor(ConsoleColor.White, ConsoleColor.DarkMagenta);
            Console.WriteLine(" ╔═════════════════════════════════════════════╗ ");
            Console.WriteLine(" ║           Alarmklockan URLED (TM)           ║ ");
            Console.WriteLine(" ║          Modellnummer: 1DV402S2L2C          ║ ");
            Console.WriteLine(" ║            Tillverkad av: eh222ve           ║ ");
            Console.WriteLine(" ╚═════════════════════════════════════════════╝ ");
            MyExtensions.ChangeColor();

            RunTest();

            MyExtensions.ViewMessage(Strings.Continue_Prompt, ConsoleColor.White, ConsoleColor.DarkGreen);
            Console.ReadKey();
        }

        //Kör alla tester
        private static void RunTest() {

            AlarmClock ac = new AlarmClock();

            ViewTestHeader("Test 1", Strings.Test1_Description);
            try
            {
                ac = new AlarmClock();
                Console.WriteLine(ac.ToString());
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            ViewTestHeader("Test 2", Strings.Test2_Description);
            try
            {
                ac = new AlarmClock(9, 42);
                Console.WriteLine(ac.ToString());
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            ViewTestHeader("Test 3", Strings.Test3_Description);
            try
            {
                ac = new AlarmClock(13, 24, 7, 35);
                Console.WriteLine(ac.ToString());
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            ViewTestHeader("Test 4", Strings.Test4_Description);
            try
            {
                ac = new AlarmClock("7:07", "7:10", "7:15", "7:30");
                Console.WriteLine(ac.ToString());
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            ViewTestHeader("Test 5", Strings.Test5_Description);
            try
            {
                ac.Time = "23:58";
                Run(ac, 13);
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            ViewTestHeader("Test 6", Strings.Test6_Description);
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
            ViewTestHeader("Test 7", Strings.Test7_Description);
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
            ViewTestHeader("Test 8", Strings.Test8_Description);
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

            Console.WriteLine();
            MyExtensions.ViewMessage(HorizontalLine, ConsoleColor.DarkMagenta);
            Console.WriteLine();
        
        }

        //Skriver t rubrik för individuellt test
        private static void ViewTestHeader(string title, string description) {

            Console.WriteLine();
            MyExtensions.ViewMessage(HorizontalLine, ConsoleColor.DarkMagenta);
            Console.WriteLine();
            MyExtensions.ViewMessage(title, ConsoleColor.DarkMagenta);
            Console.WriteLine();
            Console.WriteLine(description);
            Console.WriteLine();
                   
        }

        //Visar upp felmeddelande
        private static void ViewErrorMessage(string message) {
            MyExtensions.ViewMessage(message, ConsoleColor.White, ConsoleColor.Red);
        }

        //Kör klockan givet antal minuter
        private static void Run(AlarmClock ac, int minutes) {
            SoundPlayer sp = new SoundPlayer("../../Alarm.wav");
            sp.Load();
            
            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock())
                {
                    MyExtensions.ViewMessage(String.Format(" ♫ {0} - Vakna!", ac.ToString()), ConsoleColor.White, ConsoleColor.DarkMagenta);
                    sp.PlaySync();
                }

                Console.WriteLine("   {0}", ac.ToString());
            }

            sp.Dispose();
        }
    }
}
