using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The partition algorithm

namespace Competitive_Programs.Sorting_algo
{
    internal class Quick_sort
    {
        public static void Swap(int[] arr,int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public static int  partition(int[] arr,int low,int high)
        {
            int pivot = arr[high];

            int i =(low-1);

            for (int j = low; j <=(high-1); j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr,i,j);
                }
            }
            Swap(arr,(i+1),high);
            return (i + 1);

        }
        public static void Q_sort(int[] arr,int high,int low)
        {
            if(low<high)
            {
                int pi = partition(arr,low,high);

                Q_sort(arr,low,(pi-1));
                Q_sort(arr, (pi + 1), high);
            }
        }
        public static void Qs_Main(string[] args){

            int[] arr = { 32, 31, 34, 45, 65, 78, 98, 23 };

            Q_sort(arr,0,arr.Length-1);

            Console.WriteLine("Sorted array:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");


        }
    }
}
