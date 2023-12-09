using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
	internal class Array_reverse
	{
		static void rvereseArray(int[] arr, int start,int end)
		{
			int temp;
			if (start >= end)
				return;

			temp = arr[start];
			arr[start] = arr[end];
			arr[end] = temp;

			rvereseArray(arr, start + 1, end - 1);
		}

		/* Utility that prints out an  
		array on a line */
		static void printArray(int[] arr, int size)
		{
			for (int i = 0; i < size; i++)
				Console.Write(arr[i] + " ");

			Console.WriteLine("");
		}

		// Driver Code 
		public static void ar_Main()
		{
			int[] arr = { 1, 2, 3, 4, 5, 6 };

			printArray(arr, arr.Length);
			rvereseArray(arr, 0, arr.Length-1);

			Console.WriteLine("Reversed array is ");
			printArray(arr,arr.Length);
		}
	}
}
