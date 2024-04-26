using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class Max_Consecutive_Ones
    {
        public int findMaxConsecutiveOnes(int[] nums)
        {
            int c = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    c++;
                }
                else
                {
                    c = 0;
                }

                max = Math.Max(max, c);
            }

            return max;

        }
    }
}
