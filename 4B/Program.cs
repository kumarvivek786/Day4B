using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B
{
   
namespace Day4B
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //Create an array with some duplicate elements
                int[] numbers = { 1, 2, 3, 4, 1, 2, 5, 6, 7, 3 };

                // Initialize a variable to keep track of the number of duplicates
                int totalDuplicates = 0;

                // Loop through each element in the array
                for (int i = 0; i < numbers.Length; i++)
                {
                    // Loop through all the following elements in the array
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        // If we find a duplicate element, increment the totalDuplicates variable
                        if (numbers[i] == numbers[j])
                        {
                            totalDuplicates++;
                            break;
                        }
                    }
                }

                // Print the total number of duplicate elements
                Console.WriteLine("The total number of duplicate elements is: " + totalDuplicates);
            }
        }
    }
}

