namespace Raad_Eens_Remake
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool game = true;
            int guess_ten_times = 0; //kans_1
            int points_earned = 0; //kans_2
            int game_round = 1; //rounds

            while (game)
            {
                int RandomNumber = rnd.Next(0, 1000);
                Console.WriteLine(RandomNumber.ToString());
                Console.WriteLine($"Current round is: {game_round}");
                Console.WriteLine($"Current points earned: {points_earned}");
                //game_round += 1;

                if (game_round == 20) //The game round is max at 20
                {
                    game = false; //once the rounds reach 20, the game will stop / will turn to false
                }

                else if(points_earned == 20){
                    game = false; // once your points reached 20 (which is the max you can get) the game will turn to false / stop
                }

                while (guess_ten_times < 10) //You only have 10 chances to guess.
                {
                    guess_ten_times += 1; //This is the starting round & will continue to loop with +1 for each time you have to re-guess
                    Console.WriteLine($"You have 10 chances to guess the correct answer. You have: {guess_ten_times} chances left up to 10.");
                    Console.WriteLine("Guess a number between 1 & 1000");
                    string guess = Console.ReadLine(); //guess | This is where you insert the number you think it might be.

                    if (guess == "Terminate")
                    {
                        Console.WriteLine("The game has been terminated & will exit.");
                        Console.Read();
                        game = false;
                        break;
                    }

                    int number_guess = Convert.ToInt32(guess);
                    if (number_guess == RandomNumber)
                    {
                        Console.WriteLine("You've guessed it correct !");
                        points_earned += 1;
                        game_round += 1;
                        guess_ten_times = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You've guessed incorrectly. Try again.");
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
                    if (guess_ten_times == 10)
                    {
                        Console.WriteLine("You've reached your maximum chances, try again ! ");
                    }
                }
            }
            Console.WriteLine($"Your total points are: {points_earned}");
            Console.WriteLine("Thanks for playing.");
        }
    }
}