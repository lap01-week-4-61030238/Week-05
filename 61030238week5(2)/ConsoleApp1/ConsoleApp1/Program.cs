using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0, 2} x 2 = {1, 2}", i, i * 2);
            }
        }
    }
}
