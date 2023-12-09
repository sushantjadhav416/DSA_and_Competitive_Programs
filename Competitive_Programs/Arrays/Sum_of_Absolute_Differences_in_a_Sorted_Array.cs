using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class Sum_of_Absolute_Differences_in_a_Sorted_Array
    {
        public int[] getSumAbsoluteDifferences(int[] nums)
        {
            int[] result = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    sum = sum + Math.Abs(nums[i] - nums[j]);
                }
                result[i] = sum;
                sum = 0;
            }

            return result;
        }

        public static void sum_Main(string[] args)
        {


        }
    }
}
