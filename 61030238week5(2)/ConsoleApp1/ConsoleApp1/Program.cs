using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Begin of While statement.");
            int n = 1;
            while (n < 1)
            {
                Console.WriteLine(" Current value of n is {0}", n);
                n++;
            }
            Console.WriteLine("---- End of While statement.");

            Console.WriteLine("---- Begin of Do..While statement.");
            n = 1;
            do
            {
                Console.WriteLine(" Current value of n is {0}", n);
                n++;
            }
            while (n < 1);
            Console.WriteLine("---- End of Do..While statement.");
        }
    }
}
