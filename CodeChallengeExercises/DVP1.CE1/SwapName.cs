using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class SwapName
    {
        public static void SwapNameChallenge()
        {
            //Name: Mark Mckinney
            //Date: August 2018
            //Course: Project & Portfolio
            //Synopsis: User inputs their name and the console outputs it in reverse.
            Console.Clear();

            //Header Swap Name
            Header();

            //First name request
            Console.Write("\r\n To begin, please enter your first name: ");
            string firstName = Console.ReadLine();
            firstName = Validation(firstName);
            firstName = TrimCap(firstName);

            //Last name request
            Console.Write(" Thank you {0}. Please enter your last name: ", firstName);
            string lastName = Console.ReadLine();
            lastName = Validation(lastName);
            lastName = TrimCap(lastName);

            //User Output
            Console.WriteLine("\r\n Awesome {0} {1}! Your name swapped is " + ReversedName(firstName, lastName), firstName, lastName);

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n\r\n ===========================================================================");
            Console.ResetColor();
            Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            Menu.MainMenu();
        }

        //METHODS

        //Reverse Name Order
        public static string ReversedName(string firstN, string lastN) {
            string swapped = lastN + ", " + firstN;
            return swapped;
        }

        //Trims & capitalizes first letter
        public static string TrimCap(string _name) {
            _name = _name.Trim();
            _name = char.ToUpper(_name[0]) + _name.Substring(1);
            return _name;
        }

        //String validation
        public static string Validation(string _name) {
            while (string.IsNullOrWhiteSpace(_name)) {
                Console.Write(" Please do not leave blank. Please enter your last name: ");
                _name = Console.ReadLine();
            }
            return _name;
        }
        
        //Header
        public static void Header() {
            Console.Title = "Mark Mckinney's Code Challenges - Swap Name";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("                     ___                    _  _               ");
            Console.WriteLine("                    / __|_ __ ____ _ _ __  | \\| |__ _ _ __  ___");
            Console.WriteLine("                    \\__ \\ V  V / _` | '_ \\ | .` / _` | '  \\/ -_)");
            Console.WriteLine("                    |___/\\_/\\_/\\__,_| .__/ |_|\\_\\__,_|_|_|_\\___|");
            Console.WriteLine("                                    |_|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Welcome to SwapName:\r\n\r\n");
        }
    }
}
