// See https://aka.ms/new-console-template for more information


namespace Raad_Eens
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int game_rounds = 0;
            int game_chances = 0;
            bool the_game = true;
            string game_terminate = Console.ReadLine();
            
            Console.WriteLine("Terminate the game by typing : \"Terminate\"");

            while (the_game) 
            {
                int RandomNumber = rnd.Next(0, 1000);
                Console.WriteLine(RandomNumber.ToString());

                game_chances = 0;

                if(game_rounds <= 20)
                {
                    the_game = false;
                }

                else if(game_chances == 20)
                {
                    the_game = false;
                }

                while (game_chances < 10)
                {
                    game_chances += 1;
                    game_rounds += 1;
                    Console.WriteLine($"You have 10 chances to guess. You start at 1 chance and it goes up. You now have {game_chances} remaining.");
                    Console.WriteLine($"Current round is:{game_rounds}");
                    Console.WriteLine("Guess a number between 1 & 1000");
                    int number_guess = Convert.ToInt32(Console.ReadLine());

                    if (game_terminate == "Terminate")
                    {
                        Console.WriteLine("You have terminated the game.");
                        the_game = false;
                        game_chances = 10;
                        break;
                    }
                    if (number_guess == RandomNumber)
                    {
                        Console.WriteLine("You've guessed it right !");
                        game_chances += 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You've guessed it wrong ! try again.");
                    }
                    if (number_guess > RandomNumber && number_guess < RandomNumber + 20)
                    {
                        Console.WriteLine($"You're close! only 20 difference lower between {number_guess}");
                    }
                    else if (number_guess < RandomNumber && number_guess > RandomNumber - 20)
                    {
                        Console.WriteLine($"You're close! only 20 difference higher between {number_guess}");
                    }
                    else if (number_guess > RandomNumber && number_guess < RandomNumber + 50)
                    {
                        Console.WriteLine($"You're close! only 50 difference lower between {number_guess}");
                    }
                    else if (number_guess < RandomNumber && number_guess > RandomNumber - 50)
                    {
                        Console.WriteLine($"You're close! only 50 difference higher between {number_guess}");
                    }
                    else if (number_guess > RandomNumber)
                    {
                        Console.WriteLine($"You're way off, guess lower than {number_guess}");
                    }
                    else if (number_guess < RandomNumber)
                    {
                        Console.WriteLine($"You're way off, guess higher than {number_guess}");
                    }
                    if(game_chances == 10)
                    {
                        Console.WriteLine("You've reached your maximum chances, try again ! ");
                    }
            Console.WriteLine($"Your total points are: {game_rounds}");

                }
            }
        }
    }
}

