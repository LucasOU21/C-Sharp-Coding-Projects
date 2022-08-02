using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type a number from 0 - 8, to display your number in string:");
            string[] sArray = new string[] { "Zero", "one", "two", "three", "four", "Five", "Six", "Seven", "Eight" };
            int FromUser = Convert.ToInt32(Console.ReadLine());
            if (FromUser <= 8)
            {
                Console.WriteLine(sArray[FromUser]);

            }
            else
            {
                Console.WriteLine("Error, you typed more than Expected");
            }

            Console.ReadLine();

            
            Console.WriteLine("Type a number from 0 - 5, For a chance to win 1 Million Dollars, only get one try:");
            int[] winArray = new int[] { 0, 50, 60000, 1, 1000000, 100};
            int User = Convert.ToInt32(Console.ReadLine());
            if (User < 6)
            {
                Console.WriteLine("You win $" + winArray[User] + " dollars");
            }
            else
            {
                Console.WriteLine("Error, you typed more than Expected!");
            }

            Console.ReadLine();

            
            Console.WriteLine("Type a number from 0-3");
            List<string> optionList = new List<string> { "Chocolate", "New Audi", "Trip to Europe", "Iphone 13 Max" };
            int keyFromUser = Convert.ToInt32(Console.ReadLine());
            if (keyFromUser <= 3)
            {
                Console.WriteLine("You Won a " + optionList[keyFromUser] + "!!!");
            }
            else
            {
                Console.WriteLine("You have typed the wrong number, No Winnings!!!, PLease try again!");
            }

            Console.ReadLine();

        }
    }
}
