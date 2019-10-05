using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            object o2 = null;
            try
            {
                int i2 = (int)o2;
                Console.WriteLine("i2 = {0}", i2);
            }
            catch
            {
                Console.WriteLine("Error, null object assignment.");
            }
        }
    }
}
