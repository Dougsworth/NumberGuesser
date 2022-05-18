using System;

//Namespace
namespace NumberGuesser
{
    //Main class
     class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo function to get info

            GreetUser(); //Ask for users name and greet

            while (true)
            {



                //int correctNumber = 7;

                //Create a new Radom Object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Please guess a number between 1 and 10");

                //While guess isn't correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {

                        //Print error message. 
                        PrintColorMessage(ConsoleColor.DarkRed, "Please use an actual number");
                       
                        //Keep going
                        continue;
                    }

                    //Cast(make the string an integer) to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print Error Mesasage
                        PrintColorMessage(ConsoleColor.DarkRed, "Awss wrong number, please try again");

                    }

                }

                //Success Message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT, YOU GUESSED IT!!!");


                //Ask to play again
                Console.WriteLine("Wanna play Again? [Y or N]");

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
        //Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            String appName = "Number Guesser";
            String appVersion = "1.0.0";
            String appAuthor = "Douglas";

            //Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out pp info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        //Ask users name and greet
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("Hi, What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Nice to meet you {0}. Lets play a game :) !", inputName);
        }

        //Print colour message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text colour
            Console.ForegroundColor = color;

            //Tell user they have't entered a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();

        }
    }


}
