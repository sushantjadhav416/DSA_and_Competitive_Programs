using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Sliding_window
{
    internal class Minimum_Common_Value
    {
        public int getCommon(int[] nums1, int[] nums2)
        {
            int ptr1 = 0; 
            int ptr2 = 0; 

            while (ptr1 < nums1.Length && ptr2 < nums1.Length)
            {
                if (nums1[ptr1] == nums2[ptr2])
                    return nums1[i];
                if (nums1[ptr2] < nums2[ptr2])
                    ++ptr1;
                else
                    ++ptr2;
            }

            return -1;
        }
    }
}
