using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;
            int c = add(a, b);
        }
        private static int add(int a, int b)
        {
            throw new NullReferenceException();
        }
    }
}
