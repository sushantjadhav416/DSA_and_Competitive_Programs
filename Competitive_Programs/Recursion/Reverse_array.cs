using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Recursion
{
    internal class Reverse_array
    {

        public static void Reverse(int[] arr,int start,int end)
        {

            if (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

            }
            else
                return;

            Reverse(arr, start+1, end-1);
          
        }

        public static void Rc_Main(string[] args)
        {
            int[] array = {1, 4, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};

            Reverse(array,0,array.Length-1);

            for(int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
