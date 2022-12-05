// See https://aka.ms/new-console-template for more information


namespace Raad_Eens
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int game_rounds = 1;
            int game_chances = 0;
            bool the_game = true;

            while(the_game) 
            {
                int RandomNumber = rnd.Next(0, 1000);
                Console.Write(RandomNumber.ToString());

                game_chances = 0;
                game_rounds+= 1;

                if(game_rounds == 20)
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
                    Console.WriteLine($"You have 10 chances to guess. You start at 1 chance and it goes up. You now have {game_chances} remaining.");
                    Console.WriteLine("Guess a number between 1 & 1000");
                    int number_guess = Convert.ToInt32(Console.ReadLine());

                    if (number_guess == "Terminate")
                    {

                    }
                }
            }
        }
    }
}

