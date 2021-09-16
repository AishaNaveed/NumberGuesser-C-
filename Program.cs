using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();                               //initialize variables getting basic info
            GreetUser();                                //Greeting the user 

            while (true)
            {

                Random rand = new Random();             //create a new random object
                int correctNumb = rand.Next(1, 10);     //set a random number
                int guess = 0;                          //set a guess number

                Console.WriteLine("Guess a number between 1 - 10 please.");

                while (guess != correctNumb)
                {
                    string input = Console.ReadLine();          //get user input

                    if (!int.TryParse(input, out guess))         //make sure its a number input not letter
                    {
                        PrintColorMsg(ConsoleColor.Red, "Please enter the digit only. Try again....");
                        continue;                               //to keep on going
                    }
                    guess = Int32.Parse(input);                 //translate string into int

                    if (guess != correctNumb)
                        PrintColorMsg(ConsoleColor.Red, "Wrong number. Try again...");
                }

                //output success msg
                PrintColorMsg(ConsoleColor.Yellow, "You are correct :)");
                
                //ask to play again
                Console.WriteLine("Play again? [reply with 'Y' or 'N']...");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                    continue;
                else if(answer == "N")
                    return;
                else
                    return;
            }
        }

        //Functions
        static void GetAppInfo()
        {
            //setting up variables
            string appName = "Number guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Aisha Naveed";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //app info
            Console.WriteLine("{0} game : Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();
        }
        static void GreetUser()
        {
            //ask user's name
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello {0}, Let's play a game.", inputName);
            Console.ResetColor();

        }        
        static void PrintColorMsg(ConsoleColor color, string msg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();

        }

    }
}
