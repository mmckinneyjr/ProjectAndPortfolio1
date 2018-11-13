using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class OpenScreen
    {
        public static void OpenScreenChallenge()
        {
            //Name: Mark Mckinney
            //Date: August 2018
            //Course: Project & Portfolio I
            //Synopsis: Color animated opening screen to code challenges.
            
            //List of Colors
            List<ConsoleColor> colors = new List<ConsoleColor>() { ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Red };

            Console.CursorVisible = false;
            Name();
            ColorChange(colors);
            
        }

        //METHODS

        //Color header loop
        public static void ColorChange(List<ConsoleColor> colors) {
            while (true) {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter) {
                    break;
                }
                for (int x = 0; x < 1; x++) {
                    foreach (ConsoleColor color in colors) {
                        Console.ForegroundColor = color;
                        for (int i = 0; i < 1; i++) {
                            DeleteColor(i);
                            Task.Delay(150).Wait();
                        }
                    }
                }
            }
            Console.CursorVisible = true;
            Console.Clear();           
        }

        //Delete for reloop
        public static void DeleteColor(int _delete) {
            Console.SetCursorPosition(0, _delete);
            Line();
        }

        //Header
        public static void Line() {
            Console.Title = "Mark Mckinney's Code Challenges";
            Console.WriteLine("\r\n\r\n                             ██████╗ ██████╗ ██████╗ ███████╗");
            Console.WriteLine("                            ██╔════╝██╔═══██╗██╔══██╗██╔════╝");
            Console.WriteLine("                            ██║     ██║   ██║██║  ██║█████╗");
            Console.WriteLine("                            ██║     ██║   ██║██║  ██║██╔══╝");
            Console.WriteLine("                            ╚██████╗╚██████╔╝██████╔╝███████╗");
            Console.WriteLine("                             ╚═════╝ ╚═════╝ ╚═════╝ ╚══════╝");
            Console.WriteLine("    ██████╗██╗  ██╗ █████╗ ██╗     ██╗     ███████╗███╗   ██╗ ██████╗ ███████╗███████╗");
            Console.WriteLine("   ██╔════╝██║  ██║██╔══██╗██║     ██║     ██╔════╝████╗  ██║██╔════╝ ██╔════╝██╔════╝");
            Console.WriteLine("   ██║     ███████║███████║██║     ██║     █████╗  ██╔██╗ ██║██║  ███╗█████   ███████╗");
            Console.WriteLine("   ██║     ██╔══██║██╔══██║██║     ██║     ██╔══╝  ██║╚██╗██║██║   ██║██╔══╝  ╚════██║");
            Console.WriteLine("   ╚██████╗██║  ██║██║  ██║███████╗███████╗███████╗██║ ╚████║╚██████╔╝███████╗███████║");
            Console.WriteLine("    ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝╚══════╝");
            Console.ResetColor();
        }

        public static void Name() {
            Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            Console.WriteLine("                                  PRESS ENTER TO CONTINUE\r\n\r\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                __  __          _     __  __    _   _");
            Console.WriteLine("               |  \\/  |__ _ _ _| |__ |  \\/  |__| |_(_)_ _  _ _  ___ _  _  ");
            Console.WriteLine("               | |\\/| / _` | '_| / / | |\\/| / _| / / | ' \\| ' \\/ -_) || |");
            Console.WriteLine("               |_|  |_\\__,_|_| |_\\_\\ |_|  |_\\__|_\\_\\_|_||_|_||_\\___|\\_, |");
            Console.WriteLine("                                                                    |__/ ");
            Console.WriteLine("\r\n\r\n\r\n");
        }
    }
}
