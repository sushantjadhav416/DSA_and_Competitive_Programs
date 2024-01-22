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

	}
}
