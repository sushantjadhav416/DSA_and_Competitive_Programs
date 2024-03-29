using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Sliding_window
{
    internal class Count_Subarrays_Where_Max_Element_Appears_at_Least_K_Times
    {
        public long maxNum(int[] ar)
        {
            int m = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > m)
                    m = ar[i];
            }

            return m;
        }
        public long countSubarrays(int[] nums, int k)
        {
            int count = 0;
            long ans = 0;

            long maxN = maxNum(nums);

            for (int l = 0, i = 0; i < nums.Length; i++)
            {
                if (nums[i] == maxN)
                    count++;

                while (count == k)
                    if (nums[l++] == maxN)
                        --count;

                ans += l;
            }

            return ans;
        }
    }
}
