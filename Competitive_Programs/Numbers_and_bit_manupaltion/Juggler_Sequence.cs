using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Numbers_and_bit_manupaltion
{
    internal class Juggler_Sequence
    {
       static List<long> jugglerSequence(long n)
      {
        // code here
        
        List<long> Ls = new List<long>();
        Ls.Add(n);
        while(n!=1)
        {
            long b=0;
            if(n%2==0)
            {
                b  = (long) Math.Floor(Math.Sqrt(n));
            }
            else
            {
                b = (long) Math.Floor(Math.Sqrt(n)*Math.Sqrt(n)*Math.Sqrt(n));
            }
            
            n = b;
            Ls.Add(n);
        }
        
        
        return Ls;
        
      } 
    }
}
