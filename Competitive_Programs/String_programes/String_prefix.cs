using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// VVIMP

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class String_prefix
    {
        public String longestCommonPrefix(String[] strs)
        {
            if (strs.Length == 0 || strs == null)
                return "";

            Array.Sort(strs);
            String first = strs[0];
            String last = strs[strs.Length - 1];
            int c = 0;
            while (c < first.Length)
            {
                if (first[c] == last[c])
                    c++;
                else
                    break;

            }

            return first.Substring(0, c);


        }
    }
}
