using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//VVIMP
namespace Competitive_Programs_and_DSA_Qns.Dynamic_programing
{
    internal class You_and_your_books
    {
        public long max_Books(int[] arr, int n, int k) 
     {
        // Your code here
        
        long maxi = 0, sum = 0;
        
        for(int i=0;i<n;i++)
        {
            if(arr[i]<=k)
            {
                sum += arr[i];
            }
            else
            {
                maxi = Math.Max(maxi,sum);
                sum = 0;
            }
        }
        
        maxi = Math.Max(maxi,sum);
        
        return maxi;
    }
    }
}