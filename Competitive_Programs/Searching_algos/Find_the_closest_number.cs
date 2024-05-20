using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Find_the_closest_number
    {

        public static int findClosest(int n, int k, int[] arr) 
       {
        // code here
        
        if(k<=arr[0])
            return arr[0];
            
        if(k>=arr[n-1])
            return arr[n-1];
            
        int i=0;
        int j=n;
        int mid=0;
        
        while(i<j)
        {
            mid = (i+j)/2;
            
            if(arr[mid] == k)
                 return arr[mid];
                 
            if(arr[mid] > k)
            {
               
               
               if(mid>0 && k>arr[mid-1])
                   return Getclosest(arr[mid-1],arr[mid],k);
                j=mid;
            }
            else
            {
               
               if(mid<n-1 && k<arr[mid+1])
                  return Getclosest(arr[mid],arr[mid+1],k);
                  
                i = mid+1;
            }
        }
        
        return arr[mid];
       }
    
        public static int Getclosest(int val1,int val2,int target)
       {
            if(target - val1 >= val2 - target)
              return val2;
            else
              return val1;
       }

    }
}
