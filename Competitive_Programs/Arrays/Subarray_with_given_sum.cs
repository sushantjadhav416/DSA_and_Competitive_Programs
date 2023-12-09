using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class Subarray_with_given_sum
    {
        public static List<int> sub_w_sum(int[] arr, int n,int s)
        {
            List<int> IL = new List<int>();
            bool flag  = false;
            for (int i = 0; i < n; i++)
            {
                int sum = arr[i];

                if (sum == s)
                {
                    IL.Add(i + 1);
                    IL.Add(i + 1);
                    flag = true;
                }
                else
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        sum = sum + arr[j];
                        if (sum == s && IL.Count() == 0)
                        {
                            //System.out.println((i+1)+" "+(j+1));
                            IL.Add(i + 1);
                            IL.Add(j + 1);
                            flag = true;
                        }
                    }
                }
            }

            if( flag == false )
                IL.Add(-1);

            return IL;

        }
    }
}
