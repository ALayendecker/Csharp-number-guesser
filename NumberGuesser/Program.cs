using System;



//Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo Function to get information of the APP


            GreetUser();

            

            while (true)
            {


                // init correct Number
                //int correctNumber = 7;

                //create a new random object

                Random random = new Random();


                //init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int userGuess = 0;

                //prompt user to guess
                Console.WriteLine("Guess a number between 1-10.");


                // loop guess for when guess isn't correct
                while (userGuess != correctNumber)
                {
                    string input = Console.ReadLine();


                    //only allows for intergers
                    if (!int.TryParse(input, out userGuess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "I'm sorry! Please enter a number");

                        continue;
                    }

                    //parsing users input into an interger
                    //"Cast to int and put in guess"
                    userGuess = Int32.Parse(input);

                    //match the guess to the correct number
                    if (userGuess != correctNumber)
                    {
                        // Change Text color in console
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tells user they guessed the wrong number 
                        PrintColorMessage(ConsoleColor.Red, "Sorry guess was incorrect");

                        //reset color of foreground
                        Console.ResetColor();

                    }


                }

                // output success message


                // Change Text color in 
                // Write out App 
                PrintColorMessage(ConsoleColor.Yellow, "Congrats! You guessed the correct number");

                //reset color of foreground
                Console.ResetColor();

                // Do you want to play again?
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
               else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        static void GetAppInfo()
        {
            // Set app vars

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Andrew";

            // Change Text color in console
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out App 
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset color of foreground
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //asks users name
            Console.WriteLine("What is your name?");

            //Users input
            string inputName = Console.ReadLine();

        Console.WriteLine("Hello {0}, let's play a game", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            // Write out App 
            Console.WriteLine(message);

            //reset color of foreground
            Console.ResetColor();
        }
    }
}
