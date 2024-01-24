using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class Maximum_Length_of_a_Concatenated_String_with_Unique_Characters
    {
        public int maxLength(List<string> arr)
        {
            if (arr.Count() == 0)
                return 0;
            if (arr.Count() == 1)
                return arr.Count();

            List<int> my_lst = new List<int>();

            for (int i = 0; i < arr.Count(); i++)
            {
                my_lst.Add(arr.ElementAt(i).Length);
            }

            int m = my_lst.Max();

            int c = 0;

            for (int i = 0; i < my_lst.Count(); i++)
            {
                if (m == my_lst.ElementAt(i))
                    c++;
                    my_lst.Insert(i,0);
            }

            if (c > 1)
            {
                return m + m;
            }
            else
            {
                int sm = my_lst.Max();
                return m + sm;
            }
        }
    }
}
