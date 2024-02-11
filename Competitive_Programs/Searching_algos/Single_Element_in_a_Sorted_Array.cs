using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Single_Element_in_a_Sorted_Array
    {
        public int singleNonDuplicate(int[] nums)
        {


            int l = 0;
            int r = nums.Length - 1;

            while (l < r)
            {
                int mid = (l + r) / 2;

                if (mid % 2 == 1)
                    --mid;
                if (nums[mid] == nums[mid + 1])
                    l = mid + 2;
                else
                    r = mid;
            }
            return nums[l];
        }
    }
}
