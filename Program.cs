using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();
            greetUser();
            

            while (true)
            { //to let the game continue till 'N' is pressed

                //define a random object then use that object to generate a random number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guessNumber = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guessNumber != correctNumber)
                {
                    String input = Console.ReadLine();//this is a string, we need to convert it

                    if (!int.TryParse(input, out guessNumber))
                    {
                        printMessageWithColor(ConsoleColor.Red, "Please enter an actual number");
                        continue;
                    }
                    guessNumber = Int32.Parse(input);//converting using Int32.Parse(), Parse accepts an argument, add the variable to convert it

                    if (guessNumber != correctNumber)
                    {
                        printMessageWithColor(ConsoleColor.Red, "Wrong! Try one more time!");
                        continue;
                    }

                }

                printMessageWithColor(ConsoleColor.Yellow, "Correct! You are right! Wanna play again? [Y or N]");
                String answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
            }
            

        }
        static void GetAppInfo()
        {
            String appName = "Number Guesser";
            String appVer = "1.0.0";
            String appAuthor = "Kumar Ankit";


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} version {1} by {2}", appName, appVer, appAuthor);
            Console.ResetColor();
        }
        static void greetUser()
        {
            Console.WriteLine("Enter Your Name:");

            String inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, lets play a game!", inputName);
        }
        static void printMessageWithColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}