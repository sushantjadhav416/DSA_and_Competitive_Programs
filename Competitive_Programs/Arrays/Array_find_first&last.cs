using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class Array_find_first_last
    {
        public static void first_last_ocu(int[] arr,int x)
        {
            int first = -1,last = -1;
            for(int i=0;i<arr.Length;i++)
            {
                if (x != arr[i])
                    continue;
                if(first==-1)
                    first = i;
                last = i;

            }
            if (first != -1)
            {
                Console.WriteLine("Fisrt: {0}" +"Last: {1}",first,last);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

		public static int first_last_ocu_tc(int[] arr, int x)
		{
			HashSet<int> IS = new HashSet<int>();
			int first = -1;
			for (int i = arr.Length - 1; i >= 0; i--)
			{
				if (IS.Contains(arr[i]))
					first = i + 1;
				else
					IS.Add(arr[i]);
			}

			return first;

		}


		public static void fl_Main(string[] args)
        {
            int[] a = { 34, 21, 4, 33, 37, 67,4, 89 };
            first_last_ocu(a, 4); 

        }
    }
}
