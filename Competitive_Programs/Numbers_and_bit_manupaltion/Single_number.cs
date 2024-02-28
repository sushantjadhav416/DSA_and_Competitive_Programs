using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Numbers_and_bit_manupaltion
{
    internal class Single_number
    {
        public int singleNumber_in_2rp(int[] nums)
        {
            int a = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                a = a ^ nums[i];
            }
            return a;
        }
        public int singleNumber_in_3rp(int[] nums)
        {
            // int a = 0;
            // int ou = 0;
            // for (int i = 0; i < nums.length; i++)
            // {
            //  	 for(int j = 0;j < nums.length; j++)
            //      {
            //         if(nums[i]==nums[j])
            //            a++;

            //      }
            //      if(a==1)
            //         ou = nums[i];
            //     a=0;
            // }
            // return ou;

            int ones = 0;
            int twos = 0;

            foreach(int num in nums)
            {
                ones ^= (num & ~twos);
                twos ^= (num & ~ones);
            }

            return ones;
        }


    }
}
