using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Dynamic_programing
{
    internal class total_number_of_ways_we_can_form_a_number_N
    {
        public static int Solve(int n)
        {
            if (n < 0)
                return 0;
            if(n == 0)
                return 1;

            return Solve(n - 1) + Solve(n - 2) + Solve(n - 3);
        }

    }
}
