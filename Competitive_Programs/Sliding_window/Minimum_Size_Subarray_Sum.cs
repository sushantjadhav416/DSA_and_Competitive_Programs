using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Sliding_window
{
    internal class Minimum_Size_Subarray_Sum
    {
        public int minSubArrayLen(int target, int[] nums)
        {
            int ans = int.MaxValue;
            int sum = 0;

            for (int l = 0, r = 0; r < nums.Length; r++)
            {
                sum += nums[r];

                while (sum >= target)
                {
                    ans = Math.Min(ans, r - l + 1);
                    sum -= nums[l++];
                }
            }

            return ans != int.MaxValue ? ans : 0;

        }
    }
}
