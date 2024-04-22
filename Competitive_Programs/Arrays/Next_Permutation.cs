using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class Next_Permutation
    {
        public void nextPermutation(int[] nums)
        {
             int n = nums.Length;

            int i;
            for (i = n - 2; i >= 0; --i)
                if (nums[i] < nums[i + 1])
                    break;


            if (i >= 0)
                for (int j = n - 1; j > i; --j)
                    if (nums[j] > nums[i])
                    {
                        Swap(nums, i, j);
                        break;
                    }



            Reverse(nums, i + 1, n - 1);
        }

        public void Reverse(int[] nums, int l, int r)
        {
            while (l < r)
                Swap(nums, l++, r--);
        }

        public void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
