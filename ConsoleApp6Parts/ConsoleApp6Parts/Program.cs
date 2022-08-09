using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6Parts
{
    class Program
    {
        static void Main()
        {
            //1. String

            //string[] array = { "We are: ", "You are: ", "I am: ", "Everyone is:" };
            //Console.WriteLine("Please describe yourself in one word: ");
            //string userInput = Console.ReadLine();
            //for (int i=0; i < array.Length; i++)
            //{
            // Console.WriteLine(array[i] + userInput);
            //}
            //Console.ReadLine();

            //2. Infinte loop

            //with the while loop
            //while (true)
            //{
            //    Console.WriteLine("Press the X on the top right to stop the Loop");
            //}

            //3. loop where the comparison is used to determine whether to continue iterating the loop

            // List<int> years = new List<int>() { 2002, 2009, 2010, 2020, 2015, 2021, 2022, 2024  };
            //foreach (int year in years)
            //{
            // if (year <= 2015)
            //  {
            //  Console.WriteLine(year);
            //}
            //}
            // Console.ReadLine();

            //List<int> Bars = new List<int>() { 2, 4, 6, 8 };
            //foreach (int CBar in Bars)
            //{
            //if (CBar < 4)
            //{
            //Console.WriteLine("I love would to get  " +  CBar + " Chocolate bars please.");
            //}
            //}
            //Console.ReadLine();


            //4. Create a list of unique strings and ask the user for input. Iterate through the loop to find the text matching the input.

            //List<string> SBall = new List<string>() { "Baseball", "Basketball", "Soccer", "Tennis",
            //"Golf", "Football", "Icehockey" };
            //Console.WriteLine("What sport would you like to play?");
            //string SballInput = Console.ReadLine();
            //bool match = false;
            //foreach (string Sport in SBall
            //)
            //{
            //if (SballInput == Sport)
            //{
            //Console.WriteLine("what postition do you play in: " + SBall.IndexOf(Sport)); // the index of the array that contains matching text
            //match = true;
            //break;
            //}
            //}
            //if (!match)
            //{
            //Console.WriteLine("I'm sorry! That sport is not in an category.");
            //}
            //Console.ReadLine();




            //5. A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.

            //List<string> shoes= new List<string>() { "Vans", "Adidas", "Fila", "Jordans", "Converse", "Puma", "Fila" };
            //Console.WriteLine("Pick one of the following shoes to determine the position number: Vans, Adidas, Fila, Jordans, Converse, Puma");
            //string shoeInput = Console.ReadLine();
            //bool match1 = false;
            
            //for (int i = 0; i < shoes.Count; i++)
            //{
                //if (shoes[i] == shoeInput)
                //{
                    //Console.WriteLine("That shoe is in index number: " + i);
                    //match1 = true;
                    //continue;
                //}
            //}
            //if (!match1)
            //{
                //Console.WriteLine("Your shoe is not on our list! Sorry :( ");
            //}

            //Console.ReadLine();


            //6.: Create a list that has at least two identical strings in the list

            List<string> Colors = new List<string>() { "Black", "Pink", "Green", "Blue", "Purple", "Brown", "Black", "White" };
            List<string> backupList = new List<string>();


            foreach (string Color in Colors)
            {
                Console.WriteLine(Color + " is in our list.");
                foreach (string Color2 in backupList)//add code to tell the user that the text isn't in the list
                {
                    if (Color == Color2)
                    {
                        Console.WriteLine("The color " + Color + " has occurred before in the list");
                    }
                }
                backupList.Add(Color);
            }

            Console.ReadLine();








        }
    }
}
