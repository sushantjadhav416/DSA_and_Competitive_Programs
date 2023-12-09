//very very  IMP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//******************IMP*************************
namespace Competitive_Programs.Arrays
{
    internal class maximum_subarray
    {
        public static int max_subsum(int[] arr )
        {
            int size  = arr.Length;
            
            
            int max_so_far = int.MinValue;

            int max_ending = 0;

            for( int i=0;i<size; i++ )
            {
                max_ending = max_ending + arr[i];

                if( max_ending > max_so_far )
                    max_so_far = max_ending;

                if (max_ending < 0)
                    max_ending = 0;

            }
            return max_so_far;
        }

        public static int sum_sub(int[] arr )
        {
            for(int i=1;i<arr.Length;i++ )
            {
                if (arr[i-1] > 0)
                {
                    arr[i] += arr[i-1];
                }
            }

            Array.Sort(arr);
            return arr[arr.Length - 1];
        }

        public static void sub_Main(string[] args) {

            int[] arr = { -2, -3, 4, -1, -2, 1, 5, -3 };

            Console.WriteLine(max_subsum(arr));
            Console.WriteLine(sum_sub(arr));
        }
      

    }
}
