using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Numbers_and_bit_manupaltion
{
    internal class max_revenue
    {
        public static int revanue(int[] arr, int N, int m)
        {

            List<int> max_heap = new List<int>();

            int max_profit = 0;

            max_heap = arr.ToList();

            max_heap.Sort();
            max_heap.Reverse();

            while (m > 0)
            {

                m--;

                int x = max_heap[0];

                max_heap.RemoveAt(0);

                max_profit += x;

                max_heap.Add(x - 1);

                max_heap.Sort();
                max_heap.Reverse();

            }

            return max_profit;
        }

        public static void r_Main(string[] args)
        {

            int n = 3;
            int m = 4;
            int[] arr ={1,2,4};
            Console.WriteLine(revanue(arr,n,m));

        }
    }
}
