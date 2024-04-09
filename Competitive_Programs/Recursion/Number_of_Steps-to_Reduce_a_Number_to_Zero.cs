using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Recursion
{
    internal class Number_of_Steps_to_Reduce_a_Number_to_Zero
    {
        public int numberOfSteps(int num)
        {
            if (num == 0)
                return 0;

            int steps = 0;
            while (true)
            {

                if (num % 2 == 0)
                {
                    num /= 2;
                    steps += 1;
                }
                else
                {
                    num = num - 1;
                    steps += 1;
                    if (num == 0)
                        return steps;
                    num /= 2;
                    steps += 1;
                }

                if (num == 0)
                    return steps;
            }



        }
    }
}
