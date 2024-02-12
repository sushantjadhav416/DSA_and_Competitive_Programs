using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
	internal class Majority_elements
	{
		public int majorityElement(int[] nums)
		{
			int res = 0, cnt = 0;
			foreach (int num in nums)
			{
				if (cnt == 0)
				{
					res = num;
					++cnt;
				}
				else if (num == res)
				{
					++cnt;
				}
				else 
					--cnt;
			}
			return res;
		}
        public List<int> majorityElement_(int[] nums)
        {
            List<int> cnt = new List<int>();
            Dictionary<int,int> s1 = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (s1.ContainsKey(nums[i]))
                {
                    s1[nums[i]] += 1;
                }
                else
                {
                    s1[nums[i]] += 1;
                }
            }

            foreach(KeyValuePair<int, int> entry in s1)
            {
                if (entry.Value > (nums.Length / 3))
                    cnt.Add(entry.Key);
            }

            return cnt;
        }

    }
}
