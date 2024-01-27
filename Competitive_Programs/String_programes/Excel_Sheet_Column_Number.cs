using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class Excel_Sheet_Column_Number
    {
        public int titleToNumber(String columnTitle)
        {
            int ans = 0;

            foreach(char c in columnTitle.ToCharArray())
            {
                ans = ans * 26 + c - '@';
            }

            return ans;

        }
    }
}
