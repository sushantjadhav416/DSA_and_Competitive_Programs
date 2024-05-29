using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Numbers_and_bit_manupaltion
{
	internal class Reverse_Bits
	{
	   public int reverseBits(int n) 
      {
        int ans = 0;
        for(int i=0;i<32;i++)
        {
           if((n >> i & 1) == 1)
           {
              ans = ans | 1 << 31 - i; 
           }
        }

        return ans;
       }
	}
}
