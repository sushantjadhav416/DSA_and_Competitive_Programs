﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Sorting_algo
{
    internal class Heap_sort
    {
        int parent(int i)
        {
            return (i - 2) / 2;
        }

        int left(int i)
        {
            return 2 * i + 1;
        }

        int right(int i)
        {
            return 2 * i + 2;
        }

        //Function to build a Heap from array.
        void buildHeap(int[] arr, int n)
        {
            // Your code here
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
        }

        //Heapify function to maintain heap property.
        void heapify(int[] arr, int n, int i)
        {
            // Your code here
            int l = left(i);
            int r = right(i);

            int largest = i;

            if (l < n && arr[l] > arr[largest])
                largest = l;
            if (r < n && arr[r] > arr[largest])
                largest = r;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                heapify(arr, n, largest);
            }
        }

        //Function to sort an array using Heap Sort.
        public void heapSort(int[] arr, int n)
        {
            //code here

            buildHeap(arr, n);


            for (int i = n - 1; i > 0; i--)
            {

                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                heapify(arr, i, 0);
            }
        }
    }
}
