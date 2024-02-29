using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class Check_if_a_number_is_divisible_by_8
    {

        int DivisibleByEight(String s)
        {
            //code here
            int n = s.Length;

            if (n == 0)
                return -1;

            if (n == 1)
                return (s[0] - '0') % 8 == 0 ? 1 : -1;

            if (n == 2)
                return ((s[n - 2] - '0') * 10 + (s[n - 1] - '0')) % 8 == 0 ? 1 : -1;

            int last = s[s.Length - 1] - '0';
            int secondl = s[s.Length- 2] - '0';
            int thirdl = s[s.Length - 3] - '0';

            return (((thirdl) * 100) + ((secondl) * 10) + (last)) % 8 == 0 ? 1 : -1;



        }
    }
}
