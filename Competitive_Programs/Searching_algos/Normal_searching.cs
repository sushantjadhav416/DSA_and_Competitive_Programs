using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Searching_algos
{
    internal class Normal_searching
    {
        public static void Searching_A(int[] a,int n)
        {
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
               
                if (a[i] == n)
                {
                    Console.WriteLine("The element is  at:{0}",i);
                    c++;
                    break;
                } 
            }
            if (c <= 0)
            {
                Console.WriteLine("The element is not present in this Array!!");
            }
        }
        public static void Searching_2d(int[,] a, int n)
        {
            int c = 0;
           
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (a[i,j] == n)
                    {
                        Console.WriteLine("The element is  at:({0},{1})", i,j);
                        c++;
                        
                        break;
                    }
                }
                if (c >=1)
                {
                    break;
                }
            }
            if (c <= 0)
            {
                Console.WriteLine("The element is not present in this Array!!");
            }
        }

        //Time Complexity: O(a.Length)
        //Space complexity: O(1)
        public static void sop_Main(string[] args)
        {
            int[] arr = {3,4,5,2,7,8};
            int[,] arr_2d = { {4,2,1}, {8,7,3 }, {6,8,9 } };
            Searching_2d(arr_2d, 3);
        }

    }
}
