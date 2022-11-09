// See https://aka.ms/new-console-template for more information

namespace ProjectKaas
{
    class Program
    {

        static Boolean vraag(string prompt)
        {
            Console.WriteLine(prompt);
            string antwoord = Console.ReadLine().ToLower();
            return antwoord == "ja" || antwoord == "yes";
        }
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

            Boolean isGeel = vraag("Is de kaas geel ?");


            if (isGeel) // #1 hier word de if statement toegepast met een condition.
            { 
                Boolean heeftGaatjes = vraag("Zitten er gaatjes in? ");
                

                if (heeftGaatjes) //#1 Hier word de 2e if statement binnen in een if statement toegepast, je moet er in zijn om verder een if statement te maken.
                {
                    Console.WriteLine("Is de kaas belachelijk duur ?");
                    string vraag_3 = Console.ReadLine();

                    if (vraag_3 == "Ja") //#2 Hier word de 3e if statement binnen in een ifstatement gegeven.
                    {
                        Console.WriteLine("Emmenthaler");
                    }
                    else //#2 De else statement is in de zelfde tab line gegeven, als het ergens anders zou zijn dan zou het niet werken.
                    {
                        Console.WriteLine("Leerdammer");
                    }
                }

                else //#3 hier word nog een else if statement geopent. Daar onder gaat weer een if statement verder in een nieuwe tab line.
                {
                    Console.WriteLine("Is de kaas hard als steen ?");
                    string vraag_4 = Console.ReadLine();

                    if (vraag_4 == "Ja")// #3 het word hier weer geopend en daar onder word het met een else afgerond. alles hoort binnen in de zelfde lijn te werken , tenminsten als het bijelkaar hoort.
                    {
                        Console.WriteLine("Pamnigiano Reggiano");
                    }
                    else
                    {
                        Console.WriteLine("Goudse Kaas");
                    }
                }
            }
            
            else if(!isGeel) //#1 Dit is de else if statement die in de zelfde tab line word toegepast om een else statement te zetten voor de if statement in de zelfde lijn
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
