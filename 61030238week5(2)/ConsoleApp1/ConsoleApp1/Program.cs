using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            if (a == 10)
            {
                if (b == 20)
                {
                    Console.WriteLine("a = 10 and b = 20");
                }
                if (b != 20)
                {
                    Console.WriteLine("a = 10 and b != 20");
                }
            }
        }
    }
}
