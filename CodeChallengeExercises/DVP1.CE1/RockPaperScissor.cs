using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class RockPaperScissor
    {
        public static void RockPaperScissorChallenge()
        {
            //Name: Mark Mckinney
            //Date: August 2018
            //Course: Project & Portfolio I
            //Synopsis:Rock, paper, scissors game. User plays against the computer.
            Console.Clear();

            //Header
            Header();

            //Display for user options
            Console.WriteLine(" [1] = Rock");
            Console.WriteLine(" [2] = Paper");
            Console.WriteLine(" [3] = Scissors");
            Console.WriteLine("\r\n [0] = Exit");

            //User Input: select rock, paper, or scissors
            Console.Write("\r\n Make your selection: ");
            string userInputString = Console.ReadLine();
            int userInput;
            while (!(int.TryParse(userInputString, out userInput) && (userInput >= 0) && (userInput < 4))) {
                Console.Write(" Select [1] Rock, [2] Paper, [3] Scissors ");
                userInputString = Console.ReadLine();
                int.TryParse(userInputString, out userInput);
            }

            //Variables
            string userChoice = "";
            string compChoice = "";
            int number = 0;

            //Random Generator
            Random randomNumber = new Random();
            number = randomNumber.Next(1, 4);
            int compChoiceNumber = number;
            string winLose = "";

            //Win Lose Method
            WinLose(userInput, ref userChoice, compChoiceNumber, ref winLose, compChoiceNumber);

            //Console Output
            if (compChoiceNumber == 1) { compChoice = "ROCK"; }
            else if (compChoiceNumber == 2) { compChoice = "PAPER"; }
            else if (compChoiceNumber == 3) { compChoice = "SCISSORS"; }

            Console.WriteLine("\r\n You chose {0}, The computer chose {1}", userChoice, compChoice);
            Console.WriteLine("\r\n" + winLose);
            Console.Write("\r\n Would you like to play again? [1] Yes or [2] No : ");
            string playAgainString = Console.ReadLine();
            int playAgain;
            int.TryParse(playAgainString, out playAgain);
            if (playAgain == 1) {
                RockPaperScissor.RockPaperScissorChallenge();
            }

            //Return to main menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n\r\n ===========================================================================");
            Console.ResetColor();
            Console.WriteLine(" Press enter to return to the Main Menu");
            Console.ReadLine();
            Menu.MainMenu();
        }

        //METHODS

        //Outcomes for game: win, lose, or draw
        private static void WinLose(int userInput, ref string userChoice, int compChoiceNumber, ref string winLose, int compChoice) {
            if (userInput == 1) {
                userChoice = "ROCK";
                if (compChoiceNumber == 2) { winLose = " The Computer Wins"; }
                else { winLose = " You Won!"; }
            }

            if (userInput == 2) {
                userChoice = "PAPER";
                if (compChoiceNumber == 3) { winLose = " The Computer Wins"; }
                else { winLose = " You Won!"; }
            }

            if (userInput == 3) {
                userChoice = "SCISSORS";
                if (compChoiceNumber == 1) { winLose = " The Computer Wins"; }
                else { winLose = " You Won!"; ; }
            }

            if (userInput == compChoice) {
                winLose = " It's a Draw";  
            }

            if (userInput == 0){
                Menu.MainMenu();
            }

        }

        //Header
        public static void Header() {
            Console.Title = "Mark Mckinney's Code Challenges - Rock, Paper, Scissors";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("   ___         _       ___                       ___     _");
            Console.WriteLine("  | _ \\___  __| |__   | _ \\__ _ _ __  ___ _ _   / __| __(_)______ ___ _ _ ___");
            Console.WriteLine("  |   / _ \\/ _| / /_  |  _/ _` | '_ \\/ -_) '_|  \\__ \\/ _| (_-<_-</ _ \\ '_(_-<");
            Console.WriteLine("  |_|_\\___/\\__|_\\_( ) |_| \\__,_| .__/\\___|_|( ) |___/\\__|_/__/__/\\___/_| /__/");
            Console.WriteLine("                  |/           |_|          |/");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Rock, Paper, Scissors:\r\n");
        }
    }
}
