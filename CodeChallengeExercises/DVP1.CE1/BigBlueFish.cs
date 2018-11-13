using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class BigBlueFish
    {
        public static void BigBlueFishChallenge()
        {
            //Name: Mark Mckinney
            //Date: August 2018
            //Course: Project & Portfolio
            //Synopsis: User selects a fish color and then the biggest or smallest. The console out puts the smallest
                      //or biggest fish of that color from the array.
            Console.Clear();

            //Header
            Console.Title = "Mark Mckinney's Code Challenges - Big Blue Fish";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
            Console.WriteLine(" ><(((°>  ><(((°>  ><(((°>  ><(((°>  ><(((°>  ><(((°>  ><(((°>  ><(((°>  ><(((°>");
            Console.WriteLine(" °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                    ___ _        ___ _            ___ _    _              °");
            Console.WriteLine("           °       | _ |_)__ _  | _ ) |_  _ ___  | __(_)__| |        ><((°>");
            Console.WriteLine("          °        | _ \\ / _` | | _ \\ | || / -_) | _|| (_-< ' \\");
            Console.WriteLine("           °       |___/_\\__, | |___/_|\\_,_\\___| |_| |_/__/_||_|");
            Console.WriteLine("      ><((°>             |___/  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
            Console.WriteLine(" ><(((°>  ><(((°>  ><(((°>  ><(((°>  ><(((°>  ><(((°>  ><(((°>  ><(((°>  ><(((°>");
            Console.WriteLine(" °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
            Console.ResetColor();
            Console.WriteLine(" Welcome to Big Blue Fish:                                   ><((°>\r\n\r\n Looking for the biggest fish matching a certain color?\r\n Please select a fish color:\r\n                                                    ><((°>");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("      [1] Red");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("      [2] Blue"); Console.ResetColor(); Console.WriteLine("                        ><(((°>");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("      [3] Yellow"); Console.ResetColor(); Console.WriteLine("                                ><((°>");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("      [4] Green"); Console.ResetColor(); Console.WriteLine("                                                     ><(((°>");

            //Ask user Fish Color
            Console.Write("\r\n Selection: ");
            string colorString = Console.ReadLine();
            int color;
            int.TryParse(colorString, out color);
            while (!(color > 0) || !(color < 5)) {
                Console.Write(" You did NOT enter a value 1-4.\r\nPlease choose a color [1-4]: ");
                colorString = Console.ReadLine();
                int.TryParse(colorString, out color);
            }

            string userColor = "";
            if (color == 1) {
                userColor = "red";
            }
            else if (color == 2) {
                userColor = "blue";
            }
            else if (color == 3) {
                userColor = "yellow";
            }
            else if (color == 4) {
                userColor = "green";
            }

            //Ask user to select Big or Small fish
            Console.WriteLine("\r\n Do you want the weight of the [1] Biggest or [2] Smallest {0} Fish?", userColor);
            Console.Write(" Selection: ");
            string bigOrSmallString = Console.ReadLine();
            int bigOrSmall;
            int.TryParse(bigOrSmallString, out bigOrSmall);
            while (!(bigOrSmall > 0) || !(bigOrSmall < 3)) {
                Console.Write(" Please choose [1] Biggest or [2] Smallest: ");
                bigOrSmallString = Console.ReadLine();
                int.TryParse(bigOrSmallString, out bigOrSmall);
            }

            //Arrays of fish color and sizes
            string[] colorArray = new string[12] { "Red", "Green", "Green", "Yellow", "Blue", "Blue", "Blue", "Red", "Red", "Red", "Blue", "Red" };
            double[] sizeArray = new double[12] { 2.7, 4.5, 7.34, 10.3, 1.2, .8, 1.9, 9.8, 8.9, 5.2, 3.6, 2.6 };

            //Variables
            string variableColor = "purple";
            double bigOrSmallSize = sizeArray[0];
            int fishCount = 0;
            string isOrAre = "";
            int colorTest = 4;

            //Red Fishes
            if (color == 1) {
                for (int i = 0; i < colorArray.Length; i++) {
                    if (colorArray[i] == "Red") {
                        fishCount += 1;
                        if (fishCount == 1) {
                            if (sizeArray[i] > bigOrSmallSize) {
                                bigOrSmallSize = sizeArray[i];
                            }
                        }
                        else if (bigOrSmall == 1) {
                            if (sizeArray[i] > bigOrSmallSize) {
                                bigOrSmallSize = sizeArray[i];
                            }
                        }
                        else if (bigOrSmall == 2) {
                            if (sizeArray[i] < bigOrSmallSize) {
                                bigOrSmallSize = sizeArray[i];
                            }
                        }
                    }
                }
            }

            //Blue Fishes
            else if (color == 2) {
                for (int i = 0; i < colorArray.Length; i++) {
                    if (colorArray[i] == "Blue") {
                        fishCount += 1;

                        if (fishCount == 1) {
                            if (sizeArray[i] > bigOrSmallSize) {
                                bigOrSmallSize = sizeArray[i];
                            }
                        }
                        else if (bigOrSmall == 1) {
                            if (sizeArray[i] > bigOrSmallSize) {
                                bigOrSmallSize = sizeArray[i];
                            }
                        }
                        else if (bigOrSmall == 2) {
                            if (sizeArray[i] < bigOrSmallSize) {
                                bigOrSmallSize = sizeArray[i];
                            }
                        }
                    }
                }
            }


            //Yellow Fishes
            else if (color == 3) {
                for (int i = 0; i < colorArray.Length; i++) {
                    if (colorArray[i] == "Yellow") {
                        fishCount += 1;
                        if (fishCount == 1) {
                            if (sizeArray[i] > bigOrSmallSize){
                                bigOrSmallSize = sizeArray[i];
                            }
                        }

                        else if (bigOrSmall == 1) {
                            if (sizeArray[i] > bigOrSmallSize) {
                                bigOrSmallSize = sizeArray[i];
                            }
                        }

                        else if (bigOrSmall == 2) {
                            if (sizeArray[i] < bigOrSmallSize) {
                                bigOrSmallSize = sizeArray[i];
                            }
                        }
                    }
                }
            }

            //Green Fishes
            else if (color == 4) {
                for (int i = 0; i < colorArray.Length; i++) {
                    if (colorArray[i] == "Green") {
                        fishCount += 1;
                        if (fishCount == 1) {
                            if (sizeArray[i] > bigOrSmallSize) {
                                bigOrSmallSize = sizeArray[i];
                            }
                        }
                        else if (bigOrSmall == 1) {
                            if (sizeArray[i] > bigOrSmallSize) {
                                bigOrSmallSize = sizeArray[i];
                            }
                        }
                        else if (bigOrSmall == 2) {
                            if (sizeArray[i] < bigOrSmallSize) {
                                bigOrSmallSize = sizeArray[i];
                            }
                        }
                    }
                }
            }

            //Grammer fix if one/multiple fish "is/are" selected
            if (fishCount == 1) {
                isOrAre = "is";
            }
            else {
                isOrAre = "are";
            }

            //Console output: how many fish, color of fish, big or small, and weight
            Console.WriteLine("\r\n There {0} {1} {2} fish, the {3} is {4} pounds. ><(((°>", isOrAre, fishCount, userColor, BigOrSmall(bigOrSmall), bigOrSmallSize);

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

        //Selection of biggest or smallest
        public static string BigOrSmall(int bigOrSmall) {
            string bigOrSmallOutput = "";
            if (bigOrSmall == 1) {
                bigOrSmallOutput = "biggest";
            }
            else if (bigOrSmall == 2) {
                bigOrSmallOutput = "smallest";
            }
            return bigOrSmallOutput;
        }
    }
}
