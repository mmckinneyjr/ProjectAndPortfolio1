using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class TempConvert
    {
        public static void TempConvertChallenge()
        {
            //Name: Mark Mckinney
            //Date: August 2018
            //Course: Project & Portfolio I
            //Synopsis:User selects temperature measurement and convert it to their choosing.
            Console.Clear();

            //Header
            Console.Title = "Mark Mckinney's Code Challenges - Temperature Conversion";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("              _____                  ___                     _ ");
            Console.WriteLine("             |_   _|__ _ __  _ __   / __|___ _ ___ _____ _ _| |_");
            Console.WriteLine("               | |/ -_) '  \\| '_ \\ | (__/ _ \\ ' \\ V / -_) '_|  _|");
            Console.WriteLine("               |_|\\___|_|_|_| .__/  \\___\\___/_||_\\_/\\___|_|  \\__|");
            Console.WriteLine("                            |_|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Welcome to Temp Convert:\r\n");

            Console.WriteLine(" F = Fahrenheit, C = Celsius, & K = Kelvin\r\n");

            //User prompt for change temp FROM
            Console.Write(" Enter the measurement you want to convert FROM: ");
            string fromMeasurement = Console.ReadLine();
            fromMeasurement = fromMeasurement.ToUpper();
            while (!(fromMeasurement == "F" || fromMeasurement == "C" || fromMeasurement == "K")) {
                Console.WriteLine(" Please select from the following options:\r\n F = Fahrenheit, C = Celsius, &K = Kelvin");
                fromMeasurement = Console.ReadLine();
                fromMeasurement = fromMeasurement.ToUpper();
            }

            //User prompt for change temp TO
            Console.Write(" Enter the measurement you want to convert °{0} TO: ",fromMeasurement);
            string toMeasurement = Console.ReadLine();
            toMeasurement = toMeasurement.ToUpper();
            while (!(toMeasurement == "F" || toMeasurement == "C" || toMeasurement == "K")) {
                Console.Write(" F = Fahrenheit, C = Celsius, &K = Kelvin\r\n Please try again: ");
                toMeasurement = Console.ReadLine();
                toMeasurement = toMeasurement.ToUpper();
            }

            //User prompt for temperature to be converted
            Console.Write("\r\n You want to convert from °{0} to °{1}\r\n Please enter the temperature you want to convert: ", fromMeasurement, toMeasurement);
            string tempString = Console.ReadLine();
            double temp;
            while (!(double.TryParse(tempString, out temp))) {
                Console.Write(" Please enter a number to convert: ");
                tempString = Console.ReadLine();
                double.TryParse(tempString, out temp);
            }

            //Console output of converted temp
            //F-to-C
            if (fromMeasurement == "F" && toMeasurement == "C") {
                Console.WriteLine("\r\n The temperature {0}°F converts to {1}°C.", temp, FCconvert(temp)); }
            //F-to-K
            else if (fromMeasurement == "F" && toMeasurement == "K") {
                Console.WriteLine("\r\n The temperature {0}°F converts to {1}°K.", temp, FKconvert(temp)); }
            //C-to-F
            else if (fromMeasurement == "C" && toMeasurement == "F") {
                Console.WriteLine("\r\n The temperature {0}°C converts to {1}°F.", temp, CFconvert(temp)); }
            //C-to-K
            else if (fromMeasurement == "C" && toMeasurement == "K") {
                Console.WriteLine("\r\n The temperature {0}°C converts to {1}°K.", temp, CKconvert(temp)); }
            //K-to-F
            else if (fromMeasurement == "K" && toMeasurement == "F") {
                Console.WriteLine("\r\n The temperature {0}°K converts to {1}°F.", temp, KFconvert(temp)); }
            //K-to-C
            else if (fromMeasurement == "K" && toMeasurement == "C") {
                Console.WriteLine("\r\n The temperature {0}°K converts to {1}°C.", temp, KCconvert(temp)); }
            //SameTemp-to-SameTemp
            else {
                Console.WriteLine("\r\n The temperature {0}°{1} converts to {2}°{3}.", temp,fromMeasurement,temp,toMeasurement); }

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n\r\n ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            Menu.MainMenu();
        }

        //METHODS

        //Temp conversions
        //F-to-C
        public static double FCconvert(double _temp) {
            _temp = Math.Round((5.0/9) * (_temp - 32), 1);
            return _temp; }
        //F-to-K
        public static double FKconvert(double _temp) {
            _temp = Math.Round((5.0/9) * (_temp - 32) + (273.15), 1);
            return _temp; }
        //C-to-F
        public static double CFconvert(double _temp) {
            _temp = Math.Round((9/5.0) * (_temp) + (32), 1);
            return _temp; }
        //C-to-K
        public static double CKconvert(double _temp) {
            _temp = Math.Round(_temp + 273.15, 1);
            return _temp; }
        //K-to-F
        public static double KFconvert(double _temp) {      
            _temp = Math.Round((9/5.0) * (_temp - 273.15) + (32),1);
            return _temp; }
        //K-to-C
        public static double KCconvert(double _temp) {
            _temp = Math.Round(_temp - 273.15,1);
            return _temp; }
    }
}
