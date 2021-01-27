using System;

namespace CSharpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int.TryParse(Console.ReadLine(),out x);
            Console.WriteLine($"Your number is {x}");
           
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"number {i}");
            }

            Console.ReadKey();
        }
    }
}
