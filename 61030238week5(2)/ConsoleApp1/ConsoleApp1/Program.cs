using System;

namespace ConsoleApp2
{
    class BreakTest
    {
        static void Main()
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    break;
                }
            }
            Console.WriteLine(i);
            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}