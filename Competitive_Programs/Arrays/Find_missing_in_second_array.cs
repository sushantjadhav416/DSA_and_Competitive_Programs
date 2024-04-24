using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class Find_missing_in_second_array
    {
        List<int> findMissing(int[] a, int[] b, int n, int m)
        {
            HashSet<int> AL1 = new HashSet<int>();
            List<int> AL2 = new List<int>();

            for (int i = 0; i < b.Length; i++)
            {
                AL1.Add(b[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (!AL1.Contains(a[i]))
                {
                    AL2.Add(a[i]);
                }
            }

            return AL2;

        }

    }
}
