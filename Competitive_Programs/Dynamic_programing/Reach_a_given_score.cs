using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Dynamic_programing
{
    internal class Reach_a_given_score
    {
        public long count(int n)
        {
            // Add your code here.

            int[] total = new int[n + 1];

            Array.Fill(total, 0);

            total[0] = 1;

            for (int i = 3; i <= n; i++)
                total[i] += total[i - 3];
            for (int i = 5; i <= n; i++)
                total[i] += total[i - 5];
            for (int i = 10; i <= n; i++)
                total[i] += total[i - 10];

            return total[n];
        }
    }
}
