using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    ///VVIMP 
    internal class Find_Missing_And_Repeating
    {
        int[] findTwoElement(int[] arr, int n)
        {
            // code here
            int[] main_arr = new int[2];
            int[] temp = new int[n];

            int repeating = -1;
            int missing = -1;

            for (int i = 0; i < n; i++)
            {
                temp[arr[i] - 1]++;
                if (temp[arr[i] - 1] > 1)
                {
                    repeating = arr[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (temp[i] == 0)
                    missing = i + 1;
            }

            main_arr[0] = repeating;
            main_arr[1] = missing;




            return main_arr;
        }
    }
}
