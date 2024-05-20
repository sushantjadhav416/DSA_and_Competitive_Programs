using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Modular_Exponentiation_for_large_numbers
    {
       public long PowMod(long x, long n, long m)
    {
        // Code here
        // long res = 1;
        // while(n>0)
        // {
            
        //     if((n & 1) != 0 )
        //         res = res * x;
                
        //     n = n >> 1;
        //     x = x * x;
        // }
        
        // return res % m;
        
        
        long res = 1; // Initialize result
 
        x = x % m; // Update x if it is more than or
    // equal to p
 
        if (x == 0)
           return 0; // In case x is divisible by p;
 
        while (n > 0)
        {
 
      // If y is odd, multiply x with result
           if ((n & 1) != 0)
              res = (res * x) % m;
 
      // y must be even now
           n = n >> 1; // y = y/2
           x = (x * x) % m;
        }
        
        return res;
    }
    }
}
