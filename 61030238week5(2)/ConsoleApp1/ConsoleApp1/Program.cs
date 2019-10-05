using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line 1");
            Console.WriteLine("Line 2");
            Console.WriteLine("Line 3");
        line4:
            Console.WriteLine("Line 4");
            Console.WriteLine("Line 5");
            Console.WriteLine("Line 6");
            goto line10;
            Console.WriteLine("Line 7");
            Console.WriteLine("Line 8");
            Console.WriteLine("Line 9");
        line10:
            Console.WriteLine("Line 10");
        }
    }
}
