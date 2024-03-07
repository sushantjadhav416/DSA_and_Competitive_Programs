using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Heap_DS
{
    internal class Convert_Min_Heap_to_Max_Heap
    {
        static void Heapify(int[] arr, int i, int N)
        {
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            int largest = i;

            if (l < N && arr[l] > arr[i])
                largest = l;
            if (r < N && arr[r] > arr[largest])
                largest = r;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                Heapify(arr, largest, N);
            }

        }

        static void convertMinToMaxHeap(int N, int[] arr)
        {
            // code here
            for (int i = (N - 2) / 2; i >= 0; --i)
                Heapify(arr, i, N);
        }
    }
}
