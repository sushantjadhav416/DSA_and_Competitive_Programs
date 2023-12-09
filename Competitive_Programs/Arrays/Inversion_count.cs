using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
	internal class Inversion_count
	{
		public static int inv_cot(int[] arr)
		{
			int c = 0;
			for(int i = 0; i < arr.Length; i++)
			{
				for(int j = 0; j < arr.Length; j++)
				{
					if (arr[i]>arr[j] && i<j )
					{
						c++;
					}
				}
			}

			return c;
		}

		public static void inv_Main(string[] args)
		{
			int[] arr = { 8, 4, 2, 1 };

			Console.WriteLine(inv_cot(arr));

		}
	}
}
