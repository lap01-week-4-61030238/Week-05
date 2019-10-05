using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your grade (A, B, C, D or F) : ");
            string gradeString = Console.ReadLine();
            string message;
            switch (gradeString.ToUpper())
            {
                case "A":
                    message = "Excellent";
                    break;
                case "B":
                    message = "Good";
                    break;
                case "C":
                    message = "Cool";
                    break;
                case "D":
                    message = "Try";
                    break;
                case "F":
                    message = "Get out!!";
                    break;
                default:
                    message = "Incorrect grade";
                    break;
            }
            Console.WriteLine(message);
        }
    }
}
