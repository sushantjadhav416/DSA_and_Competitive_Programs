using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Dynamic_programing
{
    internal class N_th_Tribonacci_Number
    {
        public int tribonacci(int n)
        {

            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (n == 2)
                return 1;

            int[] Arr = new int[n + 2];

            Arr[0] = 0;
            Arr[1] = 1;
            Arr[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                Arr[i] = Arr[i - 1] + Arr[i - 2] + Arr[i - 3];
            }

            return Arr[n];

        }
    }
}
