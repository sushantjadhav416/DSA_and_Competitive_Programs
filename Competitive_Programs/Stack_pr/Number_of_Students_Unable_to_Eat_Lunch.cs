using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Stack_pr
{
    internal class Number_of_Students_Unable_to_Eat_Lunch
    {
        public int countStudents(int[] students, int[] sandwiches)
        {
            int[] count = new int[2];

            for (int i = 0; i < students.Length; i++)
                  ++count[students[i]];

            for (int i = 0; i < sandwiches.Length; i++)
            {
                if (count[sandwiches[i]] == 0)
                    return sandwiches.Length - i;

                 --count[sandwiches[i]];
            }

            return 0;
        }
    }
}
