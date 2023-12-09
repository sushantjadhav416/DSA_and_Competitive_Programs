using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class Find_max_min
    {
        public static void  mymax(int[] arr)
        {
            Array.Sort(arr);
            
        }
        public static int NTh_max(int[] arr, int n)
        {
            Array.Sort(arr);
            return arr[arr.Length-n];
        }
        public static int Nth_min(int[] arr, int n)
        {
            Array.Sort(arr);
            return arr[n];
        }
        public static void max_Main(string[] args)
        {

            int[] arr = { 34, 2, 3, 4, 2, 33, 45 };
            Console.WriteLine(NTh_max(arr,2));

        }
    }
}
