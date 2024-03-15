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

        static long MergeAndCount(long[] arr, int l, int m, int r)
        {
            int i = 0, j = 0, k = l;
            long swap = 0;

            long[] left = new long[r - m];// range of (l,M+1)
            long[] right = new long[r - m];// range of (M+1,r+1)

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                    swap += (m + 1) - (l + i);
                }
            }

            while (i < left.Length)
                arr[k++] = left[i++];

            while (j < right.Length)
                arr[k++] = right[j++];

            return swap;

        }

        static long mergeSortAndCount(long[] arr, int l, int r)
        {
            long count = 0;

            if (l < r)
            {
                int m = (l + r) / 2;

                // Total inversion count = left subarray count
                // + right subarray count + merge count

                // Left subarray count
                count += mergeSortAndCount(arr, l, m);

                // Right subarray count
                count += mergeSortAndCount(arr, m + 1, r);

                // Merge count
                count += MergeAndCount(arr, l, m, r);
            }

            return count;
        }


        public static void inv_Main(string[] args)
		{
			int[] arr = { 8, 4, 2, 1 };

			Console.WriteLine(inv_cot(arr));

		}
	}
}
