using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class find_non_repeting
    {
        public static void non_rp(int[] arr)
        {

            int res = 0;
           
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        res++;
                    }
                }
               
                if (res == 1)
                    Console.WriteLine("The non repeting element is:{0}", arr[i]);

                res = 0;
            }
        }

        public static int non_rp_(int[] arr)
        {
            Array.Sort(arr);
            int temp = int.MinValue;
            int count=0;

            for(int i = 0;i < arr.Length;i++) 
            {
                if (arr[i] == temp)
                {
                    count++;
                }
                else
                {
                    if(count == 1)
                    {
                        return temp;
                    }
                    temp = arr[i];
                    count = 1;
                }
              
            }

            return arr[arr.Length-1];
        }
        public static void nor_Main(string[] args)
        {
            int[] ar = { 4, 3, 4, 3,6 ,5, 2, 5, 6 };
            non_rp(ar);

        }
    }
}
