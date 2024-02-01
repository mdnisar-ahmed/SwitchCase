using System;
using System.Threading;

namespace ConsoleApp1_New
{
    internal class Program
    {
        static void Main()
        {
            int TotalCost = 0;
            Console.WriteLine("Welcome to Coffee Shop!!");
            Start:
            Console.WriteLine("Enter the Size of the Coffee-1:Small,2-Medium,3-Large");
             int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    TotalCost +=  1;
                    break;
                case 2:
                    TotalCost += 2;
                    break;
                case 3:
                    TotalCost += 3;
                    break;
                default:
                    Console.WriteLine("your input {0} is invalid", userInput);
                    break;

            }
        Decide:
            Console.WriteLine("Do you want to buy more coffee-Yes or No?");
            String UserDecision = Console.ReadLine();
            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your input {0} is invalid", UserDecision);
                    goto Decide;
            }
            Console.WriteLine("Thanks for buying the coffee-Your Total is {0}", TotalCost);
        }
    }
}
