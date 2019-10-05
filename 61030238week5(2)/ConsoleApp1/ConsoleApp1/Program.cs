using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial string array with month names.
            string[] monthName = new string[] { "January","February",
            "March","April","May","June","July","August",
            "September","October","November","December"};

            Console.WriteLine("-------- foreach,in loop");
            foreach (string month in monthName)
            {
                System.Console.WriteLine(month);
            }
            System.Console.WriteLine();

            // Compare the previous loop to a similar for loop.
            Console.WriteLine("-------- for loop");
            for (int i = 0; i < monthName.Length; i++)
            {
                System.Console.WriteLine(monthName[i]);
            }
            System.Console.WriteLine();


            // You can maintain a count of the elements in the collection.
            int count = 0;
            foreach (string month in monthName)
            {
                count += 1;
                System.Console.WriteLine("Element #{0}: {1}", count, month);
            }
            System.Console.WriteLine("Number of elements in the array: {0}", count);

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
