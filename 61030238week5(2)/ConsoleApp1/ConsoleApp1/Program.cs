using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your grade (sun, mon, tue, wed ,thu ,fri or sat) : ");
            string dayString = Console.ReadLine();
            string message;
            switch (dayString.ToUpper())
            {
                case "sun":
                    message = "sun is Sunday, color Red";
                    break;
                case "mon":
                    message = "mon is Monday, color Yellow";
                    break;
                case "tue":
                    message = "tur is Tuesday, color Pink";
                    break;
                case "wed":
                    message = "wed is Wednesday	, color Green";
                    break;
                case "thu":
                    message = "thu is Thursday, color Orange";
                    break;
                case "fri":
                    message = "fri is Friday, color Blue";
                    break;
                default:
                    message = "sat is , color Blue";
                    break;
            }
            Console.WriteLine(message);
        }
    }
}
