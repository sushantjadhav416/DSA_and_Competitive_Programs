using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Sorting_algo
{
	internal class FindRepeting_missing
	{

		public FindRepeting_missing(int[] arr)
		{ 

		    List<int> in_list = new List<int>();
			int repeating_elemnt = 0;
			for(int i = 0; i < arr.Length; i++)
			{
				if (in_list.Contains(arr[i]))
				{
					repeating_elemnt = arr[i];
				}
				else
				{
					in_list.Add(arr[i]);
				}
			}
			int sum1 = 0;
			int sum2 = 0;
			for(int i = 0;i <arr.Length; i++)
			{
				sum1 = sum1 + (i+1);
				sum2 = sum2 + arr[i];
			}

			sum2 = sum2 - repeating_elemnt;
			Console.WriteLine("The repeating Element:{0}",repeating_elemnt);
			Console.WriteLine("The missing Element:{0} -{1}:{2}",sum1,sum2,sum1-sum2);

		}

		public static void Findrp_Main(string[] args)
		{
			int[] arr = { 7, 3, 4, 5, 5, 6, 2 };
			FindRepeting_missing frp = new FindRepeting_missing(arr);
	    }
	}
}
