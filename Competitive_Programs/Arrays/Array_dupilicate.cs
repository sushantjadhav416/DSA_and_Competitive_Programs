using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class Array_dupilicate
    {

        public static void Dupli(int[] arr)
        {
            Array.Sort(arr);
            for(int i=0;i<(arr.Length-1); i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    Console.WriteLine(arr[i]);
                }

            }
        }

        public static void d_Main(string[] args)
        {
            int[] arr = { 1, 2, 3,4,5,1,7,8,9,2,4};  
            
            Dupli(arr);

        }
    }
}
