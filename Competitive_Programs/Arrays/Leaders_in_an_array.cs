using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class Leaders_in_an_array
    {
        static List<int> leaders(int[] arr, int n)
        {
            // Your code here
            List<int> AL = new List<int>();
            AL.Add(arr[n - 1]);
            int max_right = arr[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                if (max_right <= arr[i])
                {
                    max_right = arr[i];
                    AL.Add(max_right);
                }
            }


            AL.Reverse();
            return AL;
        }
    }
}
