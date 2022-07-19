using System;
using System.Collections.Generic;

namespace English_To_Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Translator from english to morse code";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This is a translator for english words to morse code.");
            Message();

            string input = Console.ReadLine().ToUpper();
            bool isCorrectFormat = false;

            while (!isCorrectFormat)
            {
                foreach (char character in input)
                {
                    if (!(Char.IsLetterOrDigit(character) || character == ' '))
                    {
                        Message();
                        input = Console.ReadLine().ToUpper();
                        break;
                    }

                    isCorrectFormat = true;
                }
            }

            string[] inputWords = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<List<string>> outputWords = new List<List<string>>();

            foreach (string word in inputWords)
            {
                List<string> currentWordToMorseCode = TranslateWordToMorseCode(word);

                outputWords.Add(currentWordToMorseCode);

            }

            Console.WriteLine("Every word is printed on a new row and every letter is separated by '||'.");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Your input: ");
            Console.ResetColor();
            Console.WriteLine($"\"{input}\"");

            int number = 0;
            foreach (var word in outputWords)
            {
                number++;
                Console.Write($"{number}) ");
                Console.WriteLine(String.Join ("||", word));
            }

            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }


        private static List<string> TranslateWordToMorseCode(string word)
        {
            List<string> list = new List<string>();
            
            foreach (char letter in word)
            {
                string code = String.Empty;
                switch (letter)
                {
                    case 'A': code = ".-"; break;
                    case 'B': code = "-..."; break;
                    case 'C': code = "-.-."; break;
                    case 'D': code = "-.."; break;
                    case 'E': code = "."; break;
                    case 'F': code = "..-."; break;
                    case 'G': code = "--."; break;
                    case 'H': code = "...."; break;
                    case 'I': code = ".."; break;
                    case 'J': code = ".---"; break;
                    case 'K': code = "-.-"; break;
                    case 'L': code = ".-.."; break;
                    case 'M': code = "--"; break;
                    case 'N': code = "-."; break;
                    case 'O': code = "---"; break;
                    case 'P': code = ".--."; break;
                    case 'Q': code = "--.-"; break;
                    case 'R': code = ".-."; break;
                    case 'S': code = "..."; break;
                    case 'T': code = "-"; break;
                    case 'U': code = "..-"; break;
                    case 'V': code = "...-"; break;
                    case 'W': code = ".--"; break;
                    case 'X': code = "-..-"; break;
                    case 'Y': code = "-.--"; break;
                    case 'Z': code = "--.."; break;
                    case '0': code = "-----"; break;
                    case '1': code = ".----"; break;
                    case '2': code = "..---"; break;
                    case '3': code = "...--"; break;
                    case '4': code = "....-"; break;
                    case '5': code = "....."; break;
                    case '6': code = "-...."; break;
                    case '7': code = "--..."; break;
                    case '8': code = "---.."; break;
                    case '9': code = "----."; break;
                }
                list.Add(code);
            }

            return list;
        }

        private static void Message()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Write a word or sentence in english. Use only ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("LETTERS");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" or ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("NUMBERS");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" !");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Enter input: ");
            Console.ResetColor();
        }
    }
}
