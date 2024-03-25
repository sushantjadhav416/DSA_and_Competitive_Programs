using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class Sum_of_Distances
    {
        public long[] distance(int[] nums)
        {

            long[] arr = new long[nums.Length];

            int dist = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i != j)
                    {
                        dist += Math.Abs(i - j);
                    }
                }
                arr[i] = dist;
                dist = 0;
            }

            return arr;

        }
    }
}
