using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class Backwards
    {
        public static void BackwardsChallenge()
        {
            //Name: Mark Mckinney
            //Date: August 2018
            //Course: Project & Portfolio
            //Synopsis: User inputs at least a 6 word sentence and console outputs the sentence in reverse
            Console.Clear();

            //Header
            Console.Title = "Mark Mckinney's Code Challenges - Backwards";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine("                    ___          _                       _ ");
            Console.WriteLine("                   | _ ) __ _ __| |____ __ ____ _ _ _ __| |___");
            Console.WriteLine("                   | _ \\/ _` / _| / /\\ V  V / _` | '_/ _` (_-<");
            Console.WriteLine("                   |___/\\__,_\\__|_\\_\\ \\_/\\_/\\__,_|_| \\__,_/__/");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ==============================================================================");
            Console.ResetColor();
            Console.WriteLine(" Welcome to Backwards:\r\n");

            //Ask user to enter a sentence
            Console.WriteLine(" To begin, please enter a sentence containing at least 6 words.");
            Console.Write(" "); string sentence = Console.ReadLine();

            //Validate at least 6 words in sentence
            while (WordCount(sentence) < 6) {
                Console.WriteLine(" Please enter a sentence containing a least 6 words");
                sentence = Console.ReadLine();
            }

            //Console Output
            Console.WriteLine("\r\n You entered the sentence:\r\n {0}\r\n",RemoveExSpaces(sentence));
            Console.WriteLine(" Your senetence backwards is:\r\n {0}",Reverse(RemoveExSpaces(sentence)));

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

        //Count words
        public static int WordCount(string _sentence) {
            string[] spaces = {" "};
            string[] words = _sentence.Split(spaces, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            return wordCount;
        }

        //Remove Extra Spaces
        public static string RemoveExSpaces(string _sentence) {
            _sentence = String.Join(" ", _sentence.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries));
            return _sentence;
        }

        //Reverse Sentence
        public static string Reverse(string _sentence) {
            char[] reverseLetters = _sentence.ToCharArray();
            Array.Reverse(reverseLetters);
            string reversedSentence = new string(reverseLetters);
            return reversedSentence;
        }

    }
}
