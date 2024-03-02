using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Dynamic_programing
{
    internal class Trapping_Rain_Water
    {
        static long trappingWater(int[] arr, int n)
        {
            // Your code here
            long[] left= new long[n];

            long[] right = new long[n];

            long water = 0;

            left[0] = arr[0];
            for (int i = 1; i < n; i++)
                left[i] = Math.Max(left[i - 1], arr[i]);

            right[n - 1] = arr[n - 1];
            for (int i = n - 2; i >= 0; i--)
                right[i] = Math.Max(right[i + 1], arr[i]);


            for (int i = 0; i < n; i++)
                water += Math.Min(left[i], right[i]) - arr[i];

            return water;

        }
    }
}
