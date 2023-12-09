using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
	internal class Array_mearge_witoutAuxspace
	{
		public static void  marge_arr_sort(int[] arr1, int[] arr2,int n, int m)
		{
			int start = 0;
			int end = n - 1;
			while (start < m && end >= 0)
			{
				if (arr1[end] < arr2[start])
				{
					break;
				}
				else
				{
					int  temp = arr1[end];
					arr1[end] = arr2[start];
					arr2[start] = temp;
					start++;
					end--;
				}
			}
			Array.Sort(arr1);
			Array.Sort(arr2);
		}

		public static void mar_Main(string[] args )
		{
			int[] arr1 = { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 };
			int[] arr2 = { 23, 43, 45, 2, 11, 34, 54 };

			marge_arr_sort(arr1 , arr2,arr1.Length,arr2.Length);

			for(int i = 0; i < arr1.Length; i++)
			{
				Console.WriteLine(arr1[i]);
			}

		}

	}
}
