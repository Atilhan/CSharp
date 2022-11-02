namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Enter a number to multiply with: ");
              int num_1 = Convert.ToInt32(Console.ReadLine());

              Console.Write("Enter a second number to multiply with: ");
              int num_2 = Convert.ToInt32(Console.ReadLine());

              Console.Write(num_1 * num_2);
            */

            //Je kan de operators veranderen van * naar - / + %

            Console.WriteLine("What is the price?");
            decimal price_tag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("In how much cash is the user paying ?"); //Readlines lezen alles in het begin met strings, daarom is het converted naar een decimal operator.
            decimal client_payment_amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"The item you're buying costs {price_tag} and the client pays in {client_payment_amount} euro's");
            decimal payback = client_payment_amount - price_tag;
            Console.WriteLine($"You have to return: {payback} euro's");


        }
    }
}
