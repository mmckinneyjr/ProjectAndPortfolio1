using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_StringObjects
    {
        public static void StringObjects() {

            /*
            Mark Mckinney 
            17 June 2018
            SDI Section 01
            String Objects Assignment  
              - validate email address
              - swap out a separator from a list
            */

            Console.Clear();
            Console.Title = "Mark Mckinney - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("           ___ _       _              ___  _     _        _ ");
            Console.WriteLine("          / __| |_ _ _(_)_ _  __ _   / _ \\| |__ (_)___ __| |_ ___");
            Console.WriteLine("          \\__ \\  _| '_| | ' \\/ _` | | (_) | '_ \\| / -_) _|  _(_-<");
            Console.WriteLine("          |___/\\__|_| |_|_||_\\__, |  \\___/|_.__// \\___\\__|\\__/__/");
            Console.WriteLine("                              |___/            |__/");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" String Objects:\r\n");

            //PROBLEM #1: EMAIL ADDRESS CHECKER
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor(); Console.WriteLine(" PROBLEM #1: EMAIL ADDRESS CHECKER");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.Write(" Please enter your email address: ");
            string emailString = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(emailString)) {
                Console.Write(" Opps! Please do not leave blank: ");
                emailString = Console.ReadLine();
            }

            bool x = EmailValidation(emailString);
            if (x == true) {
                Console.WriteLine("\r\n The email address {0} is a valid email address.", emailString);
            }
            else {
                Console.WriteLine("\r\n The email address {0} is a NOT valid email address.", emailString);
            }

            /*
            Data Sets To Test
            Email – test @fullsail.com
            Results - “The email address test@fullsail.com is a valid email address.”
            
            Email – test @full@sail.com
            Results -“The email address test@full@sail.com is NOT a valide mail address.”

            Email – test @full sail.com
            Results -“The email address test@full sail.com is NOT a valid email address.”
            
            Email - test mdmckinney@student.fullsail.edu
            Results - "The email address mdmckinney@student.fullsail.edu is a valid email address."
             */

            Console.WriteLine("\r\n Press enter to continue");
            Console.ReadLine();

            //PROBLEM #2: SEPARATOR SWAP OUT
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\n ------------------------------------------------------------------------------");
            Console.ResetColor(); Console.WriteLine(" PROBLEM #2: SEPARATOR SWAP OUT");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ------------------------------------------------------------------------------\r\n");
            Console.ResetColor();

            //Please enter a string
            Console.Write("\r\n Please enter a list of items using the same seperator between each: ");
            string input01String = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input01String)) {
                Console.Write("    Opps! Please do not leave blank: ");
                input01String = Console.ReadLine();
            }

            //Separator used
            Console.Write("\r\n Enter the seperator you used: ");
            string input02String = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input02String)) {
                Console.Write("    Opps! Please do not leave blank: ");
                input02String = Console.ReadLine();
            }

            //Change to separator
            Console.Write("\r\n Enter the seperator you would like to change it to: ");
            string input03String = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input03String)) {
                Console.Write("    Opps! Please do not leave blank: ");
                input03String = Console.ReadLine();
            }

            //Function output
            string sepReplace = SeparatorSwapOut(input01String, input02String, input03String);
            Console.WriteLine("\r\n The original string was: \"{0}\" \r\n with the new separator it is now: \"{1}\"", input01String, sepReplace);

            /*
            DATA SETS TO TEST
            List – “1,2,3,4,5” orginal Separator – “,” new Separator – “-”
            Results – “The original string was 1,2,3,4,5 with the new separator it is now 1-2-3-4-5.”

            List – “red: blue: green: pink” orginal Separator – “:” new Separator – “,”
            Results–“The original string was "red: blue: green: pink with the new separator it is now "red, blue, green, pink.”

            List - "123=abc=456=def=789=ghi" orginal Separator – “=” new Separator – “ ”
            Results - "The original string was 123=abc=456=def=789=ghi with the new separator it is now 123 abc 456 def 789 ghi."
             */

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            SDI_MainMenu.MainMenu();
        }

        public static bool EmailValidation(string emailString) {

           int white = emailString.Count(whiteCnt => whiteCnt == ' ');
           int atSign = emailString.IndexOf("@");
           int atCount = emailString.Count(atCnt => atCnt == '@');
           int periodSignF = emailString.IndexOf(".");
           int periodSign = emailString.LastIndexOf(".");
           int periodCount = emailString.Count(perCnt => perCnt == '.');

           bool x = true;
           if ((atSign > 0) && (periodSignF >= 1) && (atCount == 1) && (periodSign > 1 + atSign) && (white == 0)) {
           x = true;
           }

           else {
           x = false;
           }
              return x;

        /*
        //Testing returns
        Console.WriteLine("@ count {0}", atCount);
        Console.WriteLine(". count {0}", periodCount);
        Console.WriteLine("where . is:{0}", periodSign2);
        Console.WriteLine("where @ is:{0}", atSign);
        Console.WriteLine("The email address: {0}", emailString);
        */
        }

        public static string SeparatorSwapOut(string in1, string in2, string in3) {
        string x = in1.Replace(in2, in3);
        return x;
        }
    }
}
