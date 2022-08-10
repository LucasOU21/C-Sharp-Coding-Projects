using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExpectionAssignment
{
    class Program
    {
        static void Main()
        {
            do
            {
                try
                {
                    List<int> numbers = new List<int> { 3, 1, 2, 5, 7, 4, };
                    Console.WriteLine("Choose a whole number on the list: 3,1,2,5,7,4");
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    foreach (int number in numbers)
                    {
                        Console.WriteLine(number / userInput);
                    }

                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("don't divide by zero.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Try Again: You did not enter a whole number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }

            } while (true);

        }
    }  
}
