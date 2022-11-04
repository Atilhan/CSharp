using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



public class Program
{

private static int addUp (int a ,int b)
    {
        
        return a+b;

    }
    private static void Main(string[] args)
    {
        
        /*string my_name = "Atilhan";
        int my_age = 27;
        
        Console.WriteLine("Hello, my name is " + my_name);
        Console.WriteLine($"I'm currently {my_age} years old");
        Console.WriteLine("And I've just started my first C# Tutorial.");
        Console.WriteLine("My favorite number is " + my_age);

        string phrase = "Beginners Luck !";
        char grade = 'B';
        double KMP = 30.5;
        bool is_apple = true;

        Console.WriteLine("Ik wil graag een \"Banaan\"");
        Console.Write(phrase.ToUpper()); //Hiermee word de variable allemaal met de hoofdletters gebruikt.

        Console.WriteLine("I want to know your name now !, tell me your name !");
        string get_name = Console.ReadLine();
        Console.WriteLine($"So your name is {get_name}");

        Console.WriteLine(phrase[2]); //Hiermee word de index element van de variable phrase bepaald. Je kiest de index 2 dus is het de letter g van [Beginners Luck !]//
        //Om meer te leren over string modules : FreeCodeCamp Youtube Tutorial or google CSharp String Method//

        Console.WriteLine(5 % 2); //5 / 2 = 4, 1 blijft over dus die 1 word weergeven.
        Console.WriteLine(14 % 4); // Je kan ook zeggen, hoe vaak past 4 in 14 ? 4 past 4 + 4 = 8 + 4 = 12. dus 4 past 3x in 14. 2 blijft over.//

        int nummer = 5;
        nummer++; //de ++ zorgt ervoor dat er een 1 bij word opgetelt.Dus ipv 5 krijg je dan 6. Dit geld het zelfde voor als je -- doet dus ipv 5 word het dan 4
        Console.WriteLine(Math.Max(4, 90)); // Met de Math methode kan je verschillende methods gebruik. Een voorbeeld is max. met max krijg je de hoogste waarde terug in een nummer.
        //Je kan "Math." intypen en dan zie je verschillende Math methodes om te gebruiken.

        Console.Write("Enter your name: "); // Je merkt hier dat er geen WriteLine staat. dit is omdat ik de terminale text dat je gaat invoeren met een input NAAST de string gaat staan (Test maar uit)
        string your_name = Console.ReadLine();
        Console.WriteLine("Your name is : " + your_name);

        int num1 = Convert.ToInt32("32"); // met de Convert. kan je van een string een int maken.

        Console.WriteLine("Enter a number");
        int basic_calculator = Convert.ToInt32(Console.ReadLine()); //Dea Readline is een input & het verwacht een string als antwoord. Omdat we een int gebruiken krijg je normaal een error. Om dit te veranderen gebruiken we een convert zodat het een int kan lezen.
        Console.WriteLine("Enter a second number");
        int basic_calculator_2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(basic_calculator + basic_calculator_2); // Mocht het zo zijn dat je decimale getallen wilt gebruiken, dan zou je de int naar een decimal of double moeten veranderen. Ook de convert.

        //Mad Libs Maken//

        string food, coding_language, drink;

        Console.WriteLine("Enter your favorite food: ");
        food = Console.ReadLine();

        Console.WriteLine("Enter your favorite coding language: ");
        coding_language = Console.ReadLine();

        Console.WriteLine("Enter your favorite drink:");
        drink = Console.ReadLine();


        Console.WriteLine($"My favourite food is {food}");
        Console.WriteLine($"{coding_language} is my favourite coding language");
        Console.WriteLine($"I love to drink {drink}"); 

        int[] my_list = { 1, 2, 3, 4, 5 }; //Dit is een array oftewel een list. Je geeft een array aan met blokhaken []
        string[] my_shopping_list = { "Apple", "Energie", "Water","Milk" };

        Console.WriteLine(my_shopping_list[3]);
        int uitkomst = addUp(3, 5);
        Console.WriteLine(uitkomst);*/

        Console.WriteLine("Wat is uw naam ?");
        string naam = Console.ReadLine();
        string opleiding = "onbekend";
        string beroep = "onbekend";

        if (naam == "Atilhan")
        {
            Console.WriteLine("Wat is je opleiding ?: ");
            opleiding = Console.ReadLine();
            Console.WriteLine($"Uw huidige opleiding is: {opleiding} en uw naam is {naam}");
        }

        else if(naam == "Slemmer")
        {
            Console.WriteLine("Wat is uw beroep? ");
            beroep = Console.ReadLine();
            Console.WriteLine($"Uw huidige beroep is: {beroep} en uw naam is {naam}");
        }

        Console.WriteLine($"Uw naam is {naam}. Uw opleiding is {opleiding} en uw beroep is {beroep}");






    }   


}


