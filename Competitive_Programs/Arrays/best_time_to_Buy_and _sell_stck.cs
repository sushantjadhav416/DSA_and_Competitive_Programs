using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
	internal class best_time_to_Buy_and__sell_stck
	{
		//intput=7, 1, 5, 3, 6, 4
		public static int best_time_1(int[] arr,int n)
		{
			int buy = arr[0];
			int max_profit = 0;
			for(int i = 1; i < n; i++)
			{
				if (buy > arr[i])
				{
					buy= arr[i];
				}
				else if (arr[i] - buy > max_profit)
				{
					max_profit = arr[i];
				}

			}
			return max_profit;
		}

		public static int best_time_2(int[] arr, int n)
		{
			int[]  AUA = new int[n];
			
			int max_e = arr[arr.Length-1];

			for (int i = arr.Length-1;i >=0; i--)
			{
				if (arr[i] > max_e)
				{
					max_e = arr[i];
					AUA[i] = max_e;
				}
				else
				{
					AUA[i] = max_e;
				}    
			}

			int max_profit = 0;

			for(int i = 0; i < arr.Length; i++)
			{
				if (AUA[i] - arr[i] > max_profit)
					  max_profit=AUA[i] - arr[i];
			}
			return max_profit;

		}

		public static void btbs_Main(string[] args)
		{

			int[] arr = { 7, 1, 5, 3, 6, 4 };

			Console.WriteLine(best_time_1(arr,arr.Length));
			Console.WriteLine(best_time_2(arr, arr.Length));


		}
	}
}
