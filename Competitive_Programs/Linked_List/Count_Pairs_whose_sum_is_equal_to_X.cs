using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Linked_List
{
    internal class Count_Pairs_whose_sum_is_equal_to_X
    {
        public static int countPairs(LinkedList<int> head1, LinkedList<int> head2,
                          int x)
        {
            // add your code here
            HashSet<int> Hs = new HashSet<int>();

            int count = 0;

            
            foreach(var itm in head1)
            {
                Hs.Add(itm);
            }

           

            foreach(var itm in head2)
            {
                if (!(Hs.Add(x - itm)))
                    count++;
            }

            return count;
        }
    }
}
