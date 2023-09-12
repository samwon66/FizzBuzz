namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej!");
            Console.Write("Välj en siffra: ");
            int x = Convert.ToInt32(Console.ReadLine());
            while (x < 1 || x >= 100)
            {
                Console.Write("Siffran ska vara större än 1 eller mindre än 100, var god och försök igen: ");
                x = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Välj en ny siffra: ");
            int y = Convert.ToInt32(Console.ReadLine());
            while (y < x || y > 100) 
            {
                Console.Write($"Den nya siffran ska vara större än {x} eller mindre än 100, var god och försök igen: ");
                y = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("Hur lång ska talföljden vara: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n < y || n > 100)
            {
                Console.Write($"Längden ska vara större än {y} eller mindre än 100, försök igen: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 1; i < n+1; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % x == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
        }
       
    }
}