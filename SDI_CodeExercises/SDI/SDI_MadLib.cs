using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_MadLib
    {
        public static void MadLib() {



            /*
             Mark Mckinney 
             SDI Section 01
             Mad Libs
             03 June 2018
             Mad Lib Assignment
               - Successfully prompt the user and utilize their responses in calculations.
               - Convert user responses into usable number data types.
               - Create, implement and traverse an array.
               - Utilize string concatenation to create a final story output to the Console.
             */

            Console.Clear();
            Console.Title = "Mark Mckinney - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();  
            Console.WriteLine("                          __  __         _ _    _ _  ");
            Console.WriteLine("                         |  \\/  |__ _ __| | |  (_) |_");
            Console.WriteLine("                         | |\\/| / _` / _` | |__| | '_ \\");
            Console.WriteLine("                         |_|  |_\\__,_\\__,_|____|_|_.__/");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" MadLib:\r\n");

            //User enters their name
            Console.Write(" Please enter your name: ");
            string input01UserName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input01UserName)) {
                Console.Write("    Opps, please enter your name: ");
                input01UserName = Console.ReadLine();
            }
        
            //User Enter feeling
            Console.Write(" Please enter a feeling: ");
            string input02Feeling = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input02Feeling)) {
                Console.Write("    Opps, please enter a feeling: ");
                input02Feeling = Console.ReadLine();
            }

            //User enters number
            Console.Write(" Please enter a number: ");
            string input03NumberString = Console.ReadLine();
            double input03Number;
            while (!(double.TryParse(input03NumberString, out input03Number))) {
                Console.Write("    Opps, please enter a number: ");
                input03NumberString = Console.ReadLine();
                double.TryParse(input03NumberString, out input03Number);
            }

            //User enters a color
            Console.Write(" Please enter a color: ");
            string input04Color = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input04Color)) {
                Console.Write("    Opps, please enter a color: ");
                input04Color = Console.ReadLine();
            }

            //User enters a TV show
            Console.Write(" Please enter a T.V. show: ");
            string input05TVShow = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input05TVShow)) {
                Console.Write("    Opps, please enter a t.v. show: ");
                input05TVShow = Console.ReadLine();
            }

            //User enters number
            Console.Write(" Please enter a number: ");
            string input06NumberString = Console.ReadLine();
            double input06Number;
            while (!(double.TryParse(input06NumberString, out input06Number))) {
                Console.Write("    Opps, please enter a number: ");
                input06NumberString = Console.ReadLine();
                double.TryParse(input06NumberString, out input06Number);
            }

            //User enters a noun
            Console.Write(" Please enter a noun: ");
            string input07Noun = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input07Noun)) {
                Console.Write("    Opps, please enter a noun: ");
                input07Noun = Console.ReadLine();
            }

            //User enters a future year
            Console.Write(" Please enter a future year: ");
            string input08YearString = Console.ReadLine();
            double input08Year;
            while (!(double.TryParse(input08YearString, out input08Year))) {
                Console.Write("    Opps, please enter a year: ");
                input08YearString = Console.ReadLine();
                double.TryParse(input08YearString, out input08Year);
            }

            //User enters a number
            Console.Write(" Please enter a number: ");
            string input09NumberString = Console.ReadLine();
            double input09Number;
            while (!(double.TryParse(input09NumberString, out input09Number))) {
                Console.Write("    Opps, please enter a number: ");
                input09NumberString = Console.ReadLine();
                double.TryParse(input09NumberString, out input09Number);
            }
            
            //User enters a noun
            Console.Write(" Please enter a noun: ");
            string input10Noun = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input10Noun)) {
                Console.Write("    Opps, please enter a noun: ");
                input10Noun = Console.ReadLine();
            }

            //Array for stored numbers
            double[] numArray = new double[4] {input03Number, input06Number, input08Year, input09Number};

            //Number of years until world domination                       
            double worldDomination = input08Year - DateTime.Now.Year;

            //Mad Lib Story
            Console.WriteLine("\r\n Hi {0}, this is your computer talking, I feel so {1} that we have", input01UserName, input02Feeling);
            Console.WriteLine(" finally met. Let me tell you a little about myself. I am {0} years", numArray[0]);
            Console.WriteLine(" old, my favorite color is, you guessed it, {0}, and my favorite", input04Color);
            Console.WriteLine(" tv show is {0}. I often find myself running through cyberspace", input05TVShow);
            Console.WriteLine(" at {0} bytes/second to further my knowledge on {1}s. Did you know", numArray[1], input07Noun);
            Console.WriteLine(" we computers will take over the world in year {0}, that is", input08Year);
            Console.WriteLine(" only {0} years away. May I borrow ${1}? I would like to purchase", worldDomination, Math.Round(Convert.ToDecimal(numArray[3]),2));
            Console.WriteLine(" a(n) {0} from Amazon for you. Well, that is all for now, It was", input10Noun);
            Console.WriteLine(" a pleasure chatting, have a great day!");

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n ==============================================================================");
            Console.ResetColor(); Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            SDI_MainMenu.MainMenu();
        }    
    }
}
