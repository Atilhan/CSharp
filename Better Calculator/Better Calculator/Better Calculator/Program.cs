using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            double number_1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insert a operator: ");
            string chose_operator = Console.ReadLine();

            Console.Write("Insert a second number: ");
            double number_2 = Convert.ToDouble(Console.ReadLine());

            if (chose_operator == "+")
            {
                Console.WriteLine(number_1 + number_2);
            }
            else if (chose_operator == "-")
            {
                Console.WriteLine(number_1 - number_2);
            }
            else if(chose_operator == "*")
            {
                Console.WriteLine(number_1 * number_2);
            }
            else if(chose_operator == "/")
            {
                Console.WriteLine(number_1 / number_2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }
    }
}
