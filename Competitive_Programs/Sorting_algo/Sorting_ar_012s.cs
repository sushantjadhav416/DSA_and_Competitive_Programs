using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Sorting_algo
{
    internal class Sorting_ar_012s
    {
        public static void sort_012s(int[] arr,int size)
        {
            int lo = 0;
            int hi = arr.Length - 1;
            int mid = 0;
            int temp = 0;

            while (mid<=hi)
            {
                switch(mid)
                {
                    case 0:
                        {
                            temp = arr[lo];
                            arr[lo] = arr[hi];
                            arr[hi] = temp;
                            lo++;
                            mid++;
                            break;
                        }
                    case 1:
                        mid++;
                        break;
                       
                    case 2:
                        {
                            temp = arr[mid];
                            arr[mid] = arr[hi];
                            arr[hi] = temp;
                            hi--;
                            break;

                        }  
                }
                
            }

        }

        public static void ra_Main(string[] args)
        {
            int[] ars = { 1,2,0,2,0,1,2,0};

            sort_012s(ars,ars.Length);

            for(int i = 0; i < ars.Length; i++)
            {
                Console.Write(ars[i]+" ");
            }


        }
    }
}
