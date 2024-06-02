using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Numbers_and_bit_manupaltion
{
	internal class Construct_list_using_given_q_XOR_queries
	{
		public static List<int> constructList(int q, int[][] queries) {
        // code here
        
        int xor = 0;
        
        List<int> ans = new List<int>();
        
        for(int i=queries.Length-1;i>=0;i--)
        {
            if(queries[i][0]==0)
            {
                ans.Add(queries[i][1] ^ xor);
            }
            else
            {
               xor ^= queries[i][1] ;
            }
        }
        
        ans.Add(xor);
        
        ans.Sort();
        
        return ans;
    }
	}

}
