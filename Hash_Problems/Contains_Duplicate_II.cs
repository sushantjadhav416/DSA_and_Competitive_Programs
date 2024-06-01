using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Recursion
{
	internal class Contains_Duplicate_II
	{
         public bool containsNearbyDuplicate(int[] nums, int k) 
        {

        // for(int i=0;i<nums.length;i++)
        // {
        //     for(int j=0;j<nums.length;j++)
        //     {
        //          if((nums[i] == nums[j]) && (Math.abs(i - j) <= k))
        //          {
        //             return true;
        //          } 
        //     }
        // }

        // return false;


                HashSet<int> HS = new HashSet<int>();

                for(int i=0; i<nums.Length; i++)
                {
                     if(!HS.Add(nums[i]))
                           return true;
                     if(i >= k)
                          HS.Remove(nums[i-k]);
                 }

                return false;  
        }

		

		public static void fibo_Main(string[] args)
		{
			
		}
	}
}
