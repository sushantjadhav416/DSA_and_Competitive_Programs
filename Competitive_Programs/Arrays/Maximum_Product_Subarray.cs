using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
	internal class Maximum_Product_Subarray
	{
		long maxProduct(int[] arr, int n)
		{
			// code here
			long prod = 1;
			long ans = int.MinValue;
			for (int i = 0; i < n; i++)
			{
				prod = prod * arr[i];
				ans = Math.Max(ans, prod);
				if (arr[i] == 0)
					prod = 1;
			}

			prod = 1;

			for (int i = n - 1; i >= 0; i--)
			{
				prod = prod * arr[i];

				ans = Math.Max(ans, prod);
				if (arr[i] == 0)
					prod = 1;
			}

			return ans;
		}
	}
}
