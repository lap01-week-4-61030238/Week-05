using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            if (a == 2)
            {
                Console.WriteLine("execute this line");
            }
            if (a < 2)
            {
                Console.WriteLine("execute this line too");
            }
            Console.WriteLine("execute next line");
        }
    }
}
