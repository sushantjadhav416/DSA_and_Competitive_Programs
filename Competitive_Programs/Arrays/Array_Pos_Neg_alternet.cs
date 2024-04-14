using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class Array_Pos_Neg_alternet
    {
       void rearrange(int[] arr, int n)
        {

            LinkedList<int> Pos = new LinkedList<int>();
            LinkedList<int> Neg = new LinkedList<int>();

            int c = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= 0)
                    Pos.AddLast(arr[i]);
                else
                    Neg.AddLast(arr[i]);
            }

            while (!Pos.isEmpty() || !Neg.isEmpty())
            {
                if (!Pos.isEmpty())
                    arr[c++] = Pos.Pee();
                if (!Neg.isEmpty())
                    arr[c++] = Neg.poll();
            }
        }
    }
}
