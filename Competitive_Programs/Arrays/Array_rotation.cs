using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IMP for array operation
namespace Competitive_Programs.Arrays
{
    internal class Array_rotation
    {
        public static void rotate(int[] arr,int k)
        {

            for (int i = 0; i < k; i++)
            {
                int last = arr[arr.Length - 1];

                for (int j = arr.Length-1; j> 0; j--)
                {
                    arr[j] = arr[j - 1];
                }

                arr[0] = last;
            }
        }
        public static void rotate_bTC(int[] arr,int n,int k)
        {
            int i=n, j=k;
            while (i<j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
        public static void rotate_bTC(int[] arr, int k)
        {
            if(arr == null)
                return;

            k = k % arr.Length;

            if (arr.Length < 2 || k == 0)
            {
                return;
            }
  
            rotate_bTC(arr,0,arr.Length-1);
            rotate_bTC(arr, 0, k - 1);
            rotate_bTC(arr,k,arr.Length-1);
        }


        public static void R_Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            rotate_bTC(arr,3);

            Console.WriteLine("The rotated :");
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
        }
    }
}
