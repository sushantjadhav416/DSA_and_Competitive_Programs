using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class Array_intesection
    {
        public static void inter(int[] arr1, int[] arr2)
        {
            Console.WriteLine("The intersection is:");
            int c = 0;
            for(int i = 0; i < arr1.Length; i++)
            {
                for (int j=0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    { 
                            c++;
                    }
                    
                }
                if (c > 0)
                {
                    Console.WriteLine(arr1[i]);
                    c = 0;
                }
            }
        }

        public static void inter_tc(int[] arr1,int[] arr2)
        {
            HashSet<int> num_set = new HashSet<int>();  

            for(int i=0;i < arr1.Length; i++)
            {
                num_set.Add(arr1[i]);
            }

            for(int i=0;i<arr2.Length;i++)
            {
                if (num_set.Contains(arr2[i])) 
                {
                    Console.WriteLine(arr2[i]);
                }
            }
        }

        public static void intr_Main(string[] arg)
        {
            int[] arr1 = {2,3,4,1,5,6,7,8,9};
            int[] arr2 = {2, 3, 78, 76, 6 };

            inter_tc(arr1,arr2);
        }
    }
}
