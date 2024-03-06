using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class pair
    {
        long first, second;
        public pair(long first, long second)
        {
            this.first = first; 
            this.second = second;
        }

    }

    internal class Type_of_array
    {
        static pair maxNtype(long[] arr, long n)
        {

            long max = 0;
            long min = 0;

            long type = 0;

            for (int i = 0; i < n; i++)
            {
                if (max < arr[i])
                    max = arr[i];

                if (min > arr[i])
                    min = arr[i];
            }

            if (arr[0] == min && arr[arr.Length - 1] == max)
                type = 1;
            else if (arr[0] == max && arr[arr.Length - 1] == min)
                type = 2;
            else if (arr[0] < arr[arr.Length - 1])
                type = 3;
            else
                type = 4;


            return new pair(type, max);
        }
    }
}
