using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Numbers_and_bit_manupaltion
{
    internal class Find_the_Difference
    {
        public char findTheDifference(String s, String t)
        {
            char Sxor = ' ';
            char Txor = ' ';

            for (int i = 0; i < s.Length; i++)
            {
                Sxor ^= s[i];
            }

            for (int j = 0; j < t.Length; j++)
            {
                Txor ^= t[j];
            }

            char o = (char)(Sxor ^ Txor);

            return o;

        }
    }
}
