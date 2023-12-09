using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
	internal class Longest_consecutive_subsequenc
	{
		static int findLongestConseqSubseq(int[] arr, int N)
		{
			Array.Sort(arr);
			// add your code here
			List<int> IL = new List<int>();
			IL.Add(arr[0]);
			int count = 0;
			int ans = 0;

			for (int i = 1; i < N; i++)
			{
				if (arr[i] != arr[i - 1])
				{
					IL.Add(arr[i]);
				}
			}

			for (int i = 0; i < IL.Count(); i++)
			{
				if (i > 0 && IL.ElementAt(i) == IL.ElementAt(i - 1) + 1)
					count++;
				else
					count = 1;
				ans = Math.Max(ans, count);
			}

			return ans;
		}
	}
}
