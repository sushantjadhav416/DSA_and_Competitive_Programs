using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Numbers_and_bit_manupaltion
{
	internal class Number_1_bits
	{
     public int hammingWeight(int n) 
    { 

         string str =""; // int.ToBinaryString(n);
        int c = 0;
        for(int i=0;i<str.Length;i++)
        {
           if(str[i]=='1')
          {
            c++;  
          }
        }
        return c;
        //return Integer.bitCount(n); 
    }
	}
}
