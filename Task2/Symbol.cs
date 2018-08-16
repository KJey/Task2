using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Task2
{
    class Symbol
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input string:");
            string inputString = Console.ReadLine();
                
            if (string.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine(@"Error. Invalid input data.");
            }
            else
            {
                foreach (char c in inputString)
                {
                    if (char.IsWhiteSpace(c))
                        continue;
                    else
                        Console.WriteLine("Your very first symbol is " + c);
                    break;
                }
            }

            Console.WriteLine("Input number to convert:");
            string inputStringToInt = Console.ReadLine();

            try
            {
                int i = ConvertFromString.ToInt(inputStringToInt);
                Console.WriteLine("Your number = " + i);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Error: {0}", e.Message); ;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: {0}", e.Message); ;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Error: {0}", e.Message); ;
            }


        }
    }
}
