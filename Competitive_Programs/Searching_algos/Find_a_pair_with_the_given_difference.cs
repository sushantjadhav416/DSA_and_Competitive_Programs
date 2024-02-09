using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Find_a_pair_with_the_given_difference
    {

        static bool findPair(int[] arr, int n)
        {
            int size = arr.Length;

            // Initialize positions of two elements
            int i = 0, j = 1;

            // Search for a pair
            while (i < size && j < size)
            {
                if (i != j && (arr[j] - arr[i] == n || arr[i] - arr[j] == n))
                {
                    Console.WriteLine("Pair Found: " +
                                     "( " + arr[i] + ", " + arr[j] + " )");
                    return true;
                }
                else if (arr[j] - arr[i] < n)
                    j++;
                else
                    i++;
            }

            return false;
        }

        
    }
}
