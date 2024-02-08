using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class find_first_repeating_char
    {
        String firstRepChar(String s)
        {
            // code here
            bool[] seen = new bool[26];
            foreach(char c in s.ToCharArray())
            {
                if (seen[c - 'a'])
                {
                    return "" + c;
                }
                seen[c - 'a'] = true;
            }
            return "-1";
        }
    }
}
