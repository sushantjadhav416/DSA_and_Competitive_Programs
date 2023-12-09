using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
	internal class Subarray_with_0_sum
	{
		static bool findsum(int[] arr, int n)
		{
			//Your code here
			// for(int i=0;i<arr.length;i++)
			// {
			//     int sum = arr[i];
			//     if(sum==0)
			//       return true;
			//     for(int j=i+1;j<arr.length;j++)
			//     {
			//         sum=sum+arr[j];
			//         if(sum==0)
			//           return true;
			//     }
			// }
			HashSet<int> Is = new HashSet<int>();
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum = sum + arr[i];

				if (arr[i] == 0 || sum == 0 || Is.Contains(sum))
					return true;

				Is.Add(sum);
			}
			return false;
		}
	}
}
