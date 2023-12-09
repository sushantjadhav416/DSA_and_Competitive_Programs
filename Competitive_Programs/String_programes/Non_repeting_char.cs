using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class Non_repeting_char
    {
        public static char non_r_e(string S)
        {
            List<char> CL1 = new List<char>();
            List<char> CL2 = new List<char>();


            char c = '0';
            int co = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (CL1.Contains(S[i]))
                {
                    CL2.Add(S[i]);
                }
                else
                {
                    CL1.Add(S[i]);
                }
            }

            for (int i = 0; i < S.Length; i++)
            {
                if (CL2.Contains(S[i]))
                {
                    co++;
                }
                else
                {
                    c = S[i];
                    break;
                }
            }

            if (c == '0')
            {
                return '0';
            }
            else if (CL2.Count() == 0)
            {
                return S[0];
            }
            else
                return c;

            return ' ';

        }

        
    }
}
