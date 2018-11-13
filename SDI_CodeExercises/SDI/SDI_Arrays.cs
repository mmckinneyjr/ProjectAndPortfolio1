using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_Arrays
    {
        public static void Arrays() {
            /*
            Mark Mckinney
            SDI Section 01
            03 June 2018
            Arrays Assignment
            Synopsis:
            Create your own project and call it Lastname_Firstname_Arrays
            Copy this code inside of this Main section into your Main Section
            Work through each of the sections
            */

            Console.Clear();
            Console.Title = "Mark Mckinney - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("                     __      _                            __");
            Console.WriteLine("                    / /     /_\\  _ _ _ _ __ _ _  _ ___    \\ \\");
            Console.WriteLine("                   / |     / _ \\| '_| '_/ _` | || (_-<     | \\");
            Console.WriteLine("                   \\ |    /_/ \\_\\_| |_| \\__,_|\\_, /__/     | /");
            Console.WriteLine("                    \\_\\                       |__/        /_/");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Welcome to Arrays:\r\n");

            //Declare and Define The Starting Number Arrays
            int[] firstArray = new int[4] { 4, 20, 60, 150 };
            double[] secondArray = new double[4] { 5, 40.5, 65.4, 145.98 };

            //Find the total of each array and store it in a variable and output to console

            //Total of Array Number One!!!
            int totalOfArray1 = firstArray[0] + firstArray[1] + firstArray[2] + firstArray[3];
            Console.WriteLine(" The total of array number one {{{0}}} is {1}.", string.Join(", ", firstArray), totalOfArray1);

            //Total of Array Number Two!!!
            double totalOfArray2 = secondArray[0] + secondArray[1] + secondArray[2] + secondArray[3];
            Console.WriteLine(" The total of array number two is {{{0}}} is {1}.", string.Join(", ", secondArray), totalOfArray2);

            //Line Break
            Console.WriteLine();

            //Calculate the average of each array and store it in a variable and output to console
            //Just a reminder to check the averages with a calculator as well, to make sure they are correct.

            //Convert int to decimal
            double Array1ConvertedToDouble = (double)totalOfArray1;
            //Total of array values divided by the number of array elements 
            double avgOfArray1 = Array1ConvertedToDouble / firstArray.Length;
            Console.WriteLine(" The average of array one is " + avgOfArray1);

            double avgOfArray2 = totalOfArray2 / firstArray.Length;
            Console.WriteLine(" The average of array two is " + avgOfArray2);

            //Line Break
            Console.WriteLine("\r\n Press enter to continue");
            Console.ReadLine();

            /*
            Create a 3rd number array.  
            The values of this array will come from the 2 given arrays.
                -You will take the first item in each of the 2 number arrays, add them together and then store this sum inside of the new array.
                -For example Add the index#0 of array 1 to index#0 of array2 and store this inside of your new array at the index#0 spot.
                -Repeat this for each index #.
                -Do not add them by hand, the computer must add them.
                -Do not use the numbers themselves, use the array elements.
                -After you have the completed new array, output this to the Console.
             */

            //Third Array
            double[] thirdArray = new double[4] { firstArray[0] + secondArray[0], firstArray[1] + secondArray[1], firstArray[2] + secondArray[2], firstArray[3] + secondArray[3] };

            //Third Array outputted
            Console.WriteLine(" Let's create a third Array adding Array one and Array two.\r\n");
            Console.WriteLine(" The first element for Array three is: " + thirdArray[0]);
            Console.WriteLine(" The second element for Array three is: " + thirdArray[1]);
            Console.WriteLine(" The third element for Array three is: " + thirdArray[2]);
            Console.WriteLine(" The fourth element for Array three is: " + thirdArray[3]);
            Console.WriteLine("\r\n A third array created adding Array one and Array two is:\r\n {{{0}}}.", string.Join(", ", thirdArray));

            //Break
            Console.WriteLine();

            /*
            Given the array of strings below named MixedUp.  
            You must create a string variable that puts the items in the correct order to make a complete sentence.
               -Use each element in the array, do not re-write the strings themselves.
               -Concatenate them in the correct order to form a sentence.
               -Store this new sentence string inside of a string variable you create.
               -Output this new string variable to the console.
            */

            //Declare and Define The String Array
            string[] MixedUp = new string[] { "but the lighting of a", "Education is not", "fire.", "the filling", "of a bucket," };
            Console.WriteLine(" The jumbled up Array:\r\n {{{0}}}\r\n\r\n In the correct order:", string.Join(", ", MixedUp));

            string yeates = MixedUp[1] + " " + MixedUp[3] + " " + MixedUp[4] + " " + MixedUp[0] + " " + MixedUp[2];

            Console.WriteLine(" \"{0}\"", yeates);

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n\r\n ===========================================================================");
            Console.ResetColor();
            Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            SDI_MainMenu.MainMenu();
        }
    }
}
