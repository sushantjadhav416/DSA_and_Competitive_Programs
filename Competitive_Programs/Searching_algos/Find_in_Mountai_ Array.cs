using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    //VVVIMP
    internal class Find_in_Mountai__Array
    {
        public int Find_a_Peak(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] > arr[mid + 1])
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }
        public int left_Binary_search(int[] A, int l, int r, int target)
        {
            int start = l;
            int end = r;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (A[mid] == target)
                    return mid;

                if (A[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

            }
            return -1;
        }


        public int right_Binary_search(int[] A, int l, int r, int target)
        {
            int start = l;
            int end = r;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (A[mid] == target)
                    return mid;

                if (A[mid] > target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;

        }

        public int findInMountainArray(int target, int[] mountainArr)
        {

            int peak = Find_a_Peak(mountainArr);

            int index = left_Binary_search(mountainArr, 0, peak, target);

            if (index == -1)
            {
                index = right_Binary_search(mountainArr, peak + 1, mountainArr.Length - 1, target);
            }

            return index;
        }
    }
}
