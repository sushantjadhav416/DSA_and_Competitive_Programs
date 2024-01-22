using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class Length_of_the_Last_word
    {
        public static int find_length_last(string s)
        {
            int c = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (c == 0 && s[i] != ' ')
                {
                    c++;
                }
                else if (c != 0 && s[i] == ' ')
                {
                    break;
                }
                else if (('a' <= s[i] && s[i] <= 'z') || ('A' <= s[i] && s[i] <= 'Z'))
                {
                    c++;
                }
            }

            return c;
        }
    }
}
