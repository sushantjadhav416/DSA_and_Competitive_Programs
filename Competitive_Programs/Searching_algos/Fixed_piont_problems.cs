using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Searching_algos
{
    internal class Fixed_piont_problems
    {

        public static void fixed_point(int[] arr)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i)
                {
                    Console.WriteLine("Fixed point found:{0}",arr[i]);
                    c++;
                    break;
                }
            }
            if (c <= 0)
            {
                Console.WriteLine("No Fixed point!!");
            }

        }
      
        public static void Fi_Main(string[] args)
        {
            int[] arr = { 3, 1, 5, 2, 7, 8 };
            
            fixed_point(arr);

        }
    }
}
