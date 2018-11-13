using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class SDI_Lists
    {
        public static void Lists() {

            /*
            Mark Mckinney
            17 June 2018
            SDI Section 01
            Lists Assignment     
            */

            Console.Clear();
            Console.Title = "Mark Mckinney's - Scalable Data Infrastructures (SDI)";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("                               _      _     _ ");
            Console.WriteLine("                              | |    (_)   | |");
            Console.WriteLine("                              | |     _ ___| |  ___");
            Console.WriteLine("                              | |    | / __| __/ __|");
            Console.WriteLine("                              | |____| \\__ \\ |_\\__ \\");
            Console.WriteLine("                              |______|_|___/\\__|___/");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor(); Console.WriteLine(" Welcome to Lists:\r\n");
         
            //Users lists
            List<string> groceryList = new List<string>() { };
            List<decimal> priceList = new List<decimal>() { };

            //User Input
            Console.Write(" How many items are on your grocery list?: ");
            string listNumString = Console.ReadLine();
            int listNum;
            int.TryParse(listNumString, out listNum);
            //User validation
            int integers = 1;
            while (integers > listNum) {
                Console.Write(" Opps, please enter an integer greater than 0: ");
                listNumString = Console.ReadLine();
                int.TryParse(listNumString, out listNum);
            }

            //Loop for users number for grocery list
            for (int i = 0; i < listNum; i++) {
                Console.Write("\r\n {0}.Enter item: ",i + 1);

                string groceryListString = Console.ReadLine();
                groceryList.Add(groceryListString);
                while (string.IsNullOrWhiteSpace(groceryListString)) {
                    Console.Write(" Opps, please add an item to your list: ");
                    groceryListString = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(groceryListString)) {
                        groceryList.Remove(groceryList[i]);
                        groceryList.Add(groceryListString);
                    }     
                }
                
                Console.Write(" Enter cost: $");
                string priceListString = Console.ReadLine();
                decimal priceListDec;
                decimal.TryParse(priceListString, out priceListDec);
                priceList.Add(priceListDec);
                decimal dollarAmount = .01m;
                while (priceListDec < dollarAmount) {
                    Console.Write(" Opps, please enter a price: $");
                    priceListString = Console.ReadLine();
                    decimal.TryParse(priceListString, out priceListDec);
                    if (!(priceListDec <= 0)) {
                        priceList.Remove(priceList[i]);
                        priceList.Add(priceListDec);
                    }
                }
            }

            Console.WriteLine("\r\n---------------------------------------------------------------------------");
            Console.WriteLine("\r\n Our shopping list for a lovely trip to the grocery store:");

            //Combine the lists function
            CombineTheLists(groceryList, priceList);
            Console.WriteLine("\r\n The total for the groceries is: $" + Math.Round(priceList.Sum(), 2).ToString("0.00"));
            Console.WriteLine("\r\n ---------------------------------------------------------------------------");
            Console.Write(" Press enter to continue");
            Console.ReadLine();

            Console.WriteLine("\r\n I am going to take off the {0} and add ketchup:\r\n", groceryList[0]);

            //Remove Item
            groceryList.Remove(groceryList[0]);
            priceList.Remove(priceList[0]);

            //Insert Item
            groceryList.Insert(0, "ketchup");
            priceList.Insert(0, 1.99m);

            //Combine the lists function
            CombineTheLists(groceryList, priceList);

            Console.WriteLine("\r\n The new total for the groceries is: $" + Math.Round(priceList.Sum(), 2).ToString("0.00"));

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n ==============================================================================");
            Console.ResetColor(); Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Console.Clear();
            SDI_MainMenu.MainMenu();
        }

        //METHODS

        //Combine Method
        public static void CombineTheLists(List<string> gList, List<decimal> pList) {
            var groceryPrices = gList.Zip(pList, (grocery, price) => " - The " + grocery + " costs $" + Math.Round(price, 2).ToString("0.00"));
            foreach (string item in groceryPrices) {
                Console.WriteLine(item);         
            }
        }
    }
}
