using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class First_element_to_occur_k_times
    {
        public int firstElementKTime(int n, int k, int[] a)
        {
            HashMap<Integ, Integer> Hm = new HashMap<Integer, Integer>();

            for (int i = 0; i < n; i++)
            {

                if (Hm.containsKey(a[i]))
                {
                    Hm.put(a[i], Hm.get(a[i]) + 1);
                    if (Hm.get(a[i]) >= k)
                        return a[i];
                }
                else
                {
                    Hm.put(a[i], 1);
                }

            }

            return -1;
        }
    }
}
