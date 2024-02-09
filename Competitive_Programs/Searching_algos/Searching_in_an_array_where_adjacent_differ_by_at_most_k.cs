using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Searching_in_an_array_where_adjacent_differ_by_at_most_k
    {
        static int search(int[] arr, int n,
                           int x, int k)
        {

            // Traverse the given array starting
            // from leftmost element
            int i = 0;

            while (i < n)
            {

                // If x is found at index i
                if (arr[i] == x)
                    return i;

                // Jump the difference between 
                // current array element and x
                // divided by k We use max here
                // to make sure that i moves 
                // at-least one step ahead.
                i = i + Math.Max(1, Math.Abs(arr[i]
                                          - x) / k);
            }


            return -1;
        }
    }
}
