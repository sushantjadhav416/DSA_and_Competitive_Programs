using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Find_Smallest_Letter_Greater_Than_Target
    {

        public char nextGreatestLetter(char[] letters, char target)
        {
            int start = 0;
            int end = letters.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (letters[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

            }
            // if(target == 'z' || target == letters[letters.length-1])
            //    return letters[0];

            // if(letters[start] <= target)
            //    start++;

            return letters[start % letters.Length];
        }
    }

}
