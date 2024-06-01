using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Recursion
{
	internal class Happy_Number
	{
		public  int NumSqureSum(int n)
        {
        int num = 0;

        while(n != 0)
        {
            int dig = n % 10;
            num +=  dig * dig;
            n /= 10;
        }

        return num;

       }

       public boolean isHappy(int n) 
       {
        HashSet<Integer> HS = new HashSet<Integer>();

        while(true)
        {
           n = NumSqureSum(n);
          if(n == 1)
             return true;
          if(HS.contains(n))
             return false;
          HS.add(n);
        } 
       }

		public static void fibo_Main(string[] args)
		{
			
		}
	}
}
