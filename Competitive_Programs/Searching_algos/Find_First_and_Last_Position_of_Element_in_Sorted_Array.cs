using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        public int search(int[] nums, int target, bool findfirst)
        {
            int start = 0;
            int end = nums.Length - 1;
            int ans = -1; ;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    ans = mid;
                    if (findfirst)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }

            }
            return ans;

        }
        public int[] searchRange(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;


            int[] out_arr = new int[2];

            int first = search(nums, target, true);
            int last = search(nums, target, false);

            if (nums.Length == 1 && nums[0] == target)
            {
                out_arr[0] = 0;
                out_arr[0] = 0;
            }
            else if (first == -1 && last == -1)
            {
                out_arr[0] = -1;
                out_arr[1] = -1;
            }
            else
            {
                out_arr[0] = first;
                out_arr[1] = last;
            }

            return out_arr;
        }
    }
}
