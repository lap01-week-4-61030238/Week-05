﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int b = 10;
                b /= a;
                Console.WriteLine(a);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
