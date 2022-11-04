// See https://aka.ms/new-console-template for more information

namespace ProjectKaas
{
    class Program
    {
        static void Main(string[] args)
        {

            //-------------Test Project-------------
            /*
            Console.WriteLine("Insert your name down bellow.");
            string user_name = Console.ReadLine();

            if (user_name == "Atilhan")
                Console.WriteLine("Hello Atilhan");

            else
            {
                Console.WriteLine($"Sorry, the user {user_name} is unknown"); //Bij else statements gebruiken we {} inplaatsvan () omdat je bij de if een condition aangeeft. De conditie kan ook gegeven worden bij een if else statement.        
            } */



            //Project Kaas//

            Console.WriteLine("Is de kaas geel ?");
            string vraag_1 = Console.ReadLine();
            string lower_case = vraag_1.ToLower();

            if (vraag_1 == "Ja")
            { 
                Console.WriteLine("Zitten er gaatjes in? ");
                string vraag_2 = Console.ReadLine();

                if (vraag_2 == "Ja")
                {
                    Console.WriteLine("Is de kaas belachelijk duur ?");
                    string vraag_3 = Console.ReadLine();

                    if(vraag_3 == "Ja")
                    {
                        Console.WriteLine("Emmenthaler");
                    }
                    else
                    {
                        Console.WriteLine("Leerdammer");
                    }
                }

                else if(vraag_2 == "Nee")
                {
                    Console.WriteLine("Is de kaas hard als steen ?");
                    string vraag_4 = Console.ReadLine();

                    if (vraag_4 == "Ja")
                    {
                        Console.WriteLine("Pamnigiano Reggiano");
                    }
                    else
                    {
                        Console.WriteLine("Goudse Kaas");
                    }
                }
            }
            
            else if(vraag_1 == "Nee")
            {
                Console.WriteLine("Heeft de kaas blauwe schimmels ?");
                string vraag_5 = Console.ReadLine();

                if (vraag_5 == "Ja")
                {
                    Console.WriteLine("Heeft de kaas een korst? ");
                    string vraag_6 = Console.ReadLine();

                    if (vraag_6 == "Ja")
                    {
                        Console.WriteLine("Bleu de RochBaron");
                    }

                    else
                    {
                        Console.WriteLine("Foume D Ambert");
                    }
                }

                else if (vraag_5 == "Nee")
                {
                    Console.WriteLine("Heeft de kaas korst ?");
                    string vraag_6 = Console.ReadLine();

                    if (vraag_6 == "Ja")
                    {
                        Console.WriteLine("Camembert");
                    }

                    else
                    {
                        Console.WriteLine("Mozzarella");
                    }
                }
            }
        }
    }
}
