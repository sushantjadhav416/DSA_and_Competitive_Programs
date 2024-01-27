using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class String_all_recursion
    {
        public void remove_char(string p ,string q, char c)
        {

            if (q.Length != 0)
                return;

            char ch = p[0];

            if (ch == c)
            {
                remove_char(p, q.Substring(1), c);
            }
            else
            {
                remove_char(p+ch,q.Substring(1), c);
            }
               
        }
    }
}
