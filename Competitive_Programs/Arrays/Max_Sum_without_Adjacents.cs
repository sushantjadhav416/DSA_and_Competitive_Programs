using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class Max_Sum_without_Adjacents
    {
        int Rec(int[] arr, int idx)
        {
            if (idx >= arr.Length)
                return 0;

            return Math.Max(arr[idx] + Rec(arr, idx + 2), Rec(arr, idx + 1));
        }

        int findMaxSum(int[] arr, int n)
        {
            // code here
            return Rec(arr, 0);
        }
    }
}
