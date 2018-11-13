using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class AgeConvert
    {
        public static void AgeConvertChallenge()
        {
            //Name: Mark Mckinney
            //Date: August 2018
            //Course: Project & Portfolio
            //Synopsis: User inputs their name and birthday. The console calculate their age and converts 
            //it the number of days, hours, minutes, and seconds old they are.
            Console.Clear();

            //Header
            Console.Title = "Mark Mckinney's Code Challenges - Age Conversion";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("                      _               ___                     _");
            Console.WriteLine("                     /_\\  __ _ ___   / __|___ _ ___ _____ _ _| |_ ");
            Console.WriteLine("                    / _ \\/ _` / -_) | (__/ _ \\ ' \\ V / -_) '_|  _|");
            Console.WriteLine("                   /_/ \\_\\__, \\___|  \\___\\___/_||_\\_/\\___|_|  \\__|");
            Console.WriteLine("                         |___/ ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("\r\n Welcome to Age Convert:\r\n Today's date is " + DateTime.Today.ToString("MMMM dd, yyyy.") + "\r\n We are going to find out how old you are in days, hours, minutes, & seconds.\r\n");

            //Prompt User for their name
            Console.Write(" Let me start by asking you for your name: ");
            string name = Console.ReadLine();
            name = name.Trim().ToLower();
            while (string.IsNullOrWhiteSpace(name)) {
                Console.Write(" Please do not leave blank.\r\n Please enter your name: ");
                name = Console.ReadLine();
                name = name.Trim().ToLower();
            }

            //Prompt User for their birth "Month"
            Console.Write("\r\n Hello {0}! What is your birthday?\r\n Please enter the month you were born 1 - 12: ", CapitalizeFirstLetter(name));
            string birthMonthString = Console.ReadLine();
            int birthMonth;
            while (!(int.TryParse(birthMonthString, out birthMonth) && (birthMonth > 0 && birthMonth <= 12))) {
                Console.Write(" Opps! Please enter a number for the month you were born: ");
                birthMonthString = Console.ReadLine();
                int.TryParse(birthMonthString, out birthMonth);
            }
            DateTime monthConvert = new DateTime(1, birthMonth, 1);

            //Prompt User for their birth "Day"
            Console.Write(" Please enter the day you were born on: ", name);
            string birthDayString = Console.ReadLine();
            int birthDay;
            while (!(int.TryParse(birthDayString, out birthDay) && (birthDay < 32) && (birthDay > 0))) {
                Console.Write(" Opps! please enter a valid date for {0}: ", monthConvert.ToString("MMMM"));
                birthDayString = Console.ReadLine();
                int.TryParse(birthDayString, out birthDay);
            }
            //Validation for February which only has 28 days
            while ((birthMonth == 2) && (birthDay > 28)) {
                Console.Write(" Opps! please enter a valid date for {0}: ", monthConvert.ToString("MMMM"));
                birthDayString = Console.ReadLine();
                int.TryParse(birthDayString, out birthDay);
            }
            //Valiation for months that only have 30 days
            while (((birthMonth == 4) || (birthMonth == 6) || (birthMonth == 9) || (birthMonth == 11)) && !(birthDay < 31)) {
                Console.Write(" Opps! please enter a valid date for {0}: ", monthConvert.ToString("MMMM"));
                birthDayString = Console.ReadLine();
                int.TryParse(birthDayString, out birthDay);
            }

            //Prompt User for their birth "Year"
            Console.Write(" Finally, please enter the year of your birth: ");
            string birthYearString = Console.ReadLine();
            int birthYear;
            while (!(int.TryParse(birthYearString, out birthYear))) {
                Console.Write(" Opps! Please enter a number for the day you were born: ");
                birthYearString = Console.ReadLine();
                int.TryParse(birthYearString, out birthYear);
            }

            //Console output: users age and birthday.
            DateTime usersBirthday = new DateTime(birthYear, birthMonth, birthDay);
            int usersAge;
            int.TryParse(UsersAgeString(usersBirthday), out usersAge);
            Console.WriteLine("\r\n {0}, since your birthday is " + usersBirthday.ToString("MMMM dd, yyyy,") + " that makes you {1} years old!", CapitalizeFirstLetter(name), UsersAgeString(usersBirthday));
            Console.WriteLine(" Let's see how many days, hours, minutes, & seconds that is:");
            Console.Write("\r\n <Press enter to continue>");
            Console.ReadLine();

            //Console output: age in days, hours, minutes, and seconds.
            Console.WriteLine("\r\n Did you know that is equivalent to:\r\n\r\n {0:n0} days\r\n -or-\r\n {1:n0} hours\r\n -or-\r\n {2:n0} minutes\r\n -or-\r\n {3:n0} seconds\r\n", Days(usersAge), Hours(usersAge), Minutes(usersAge), Seconds(usersAge));

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            Menu.MainMenu();
        }

        //METHODS

        //Capitalizes first letter of users name
        public static string CapitalizeFirstLetter(string _name) {
            string[] splitString = _name.Split(' ');
            for (int i = 0; i < splitString.Length; i++) { 
                splitString[i] = splitString[i].First().ToString().ToUpper() + splitString[i].Substring(1);
            }
            return string.Join(" ",splitString);
        }

        //Age converted to days
        public static int Days(int _age) {
            _age = _age * 365;
            return _age;
        }

        //Age converted to hours
        public static int Hours(int _age) {
            _age = (_age * 365) * 24;
            return _age;
        }

        //Age converted to minutes
        public static int Minutes(int _age) {
            _age = ((_age * 365) * 24) * 60;
            return _age;
        }

        //Age converted to seconds
        public static int Seconds(int _age) {
            _age = (((_age * 365) * 24) * 60) * 60;
            return _age;
        }

        //Calculate users age
        public static string UsersAgeString(DateTime _usersBirthday) {
            TimeSpan subtractDays = DateTime.Today - _usersBirthday;
            double days = subtractDays.TotalDays;
            var today = ((days / 365));
            string usersAge = today.ToString().Split('.')[0];
            return usersAge;
        }
    }
    
}
