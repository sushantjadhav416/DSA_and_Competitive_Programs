using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Heap_DS
{
    internal class Contiguous_Array
    {
        public int findMaxLength(int[] nums)
        {

            int ans = 0;
            int prefix = 0;

            Dictionary<int,int> IndexPrefix = new Dictionary<int, int>();
            IndexPrefix.Add(0, -1);

            for (int i = 0; i < nums.Length; ++i)
            {
                prefix += nums[i] == 1 ? 1 : -1;
                if (IndexPrefix.ContainsKey(prefix))
                {
                    ans = Math.Max(ans, i - IndexPrefix.TryGetValue(prefix,i));
                }
                else
                {
                    IndexPrefix.Add(prefix, i);
                }


            }
            return ans;
        }
    }
}
