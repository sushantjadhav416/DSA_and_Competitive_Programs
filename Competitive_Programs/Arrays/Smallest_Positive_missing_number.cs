using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class Smallest_Positive_missing_number
    {

        static int missingNumber(int arr[], int size)
    {
        // Your code here
       
      int n = arr.length;
       
    //   if(n==1 && arr[0]!=1)
    //       return 1;
          
    //   int[] new_Arr = new int[n+1];
       
    //   for(int i=0;i<n;i++)
    //   {
    //       if(arr[i]>0 && arr[i]<=n)
    //             new_Arr[arr[i]]++;
    //   }
       
    //   for(int i=1;i<n;i++)
    //   {
    //       if(new_Arr[i]==0)
    //           return i;
    //   }
    int N = 1000010;
    
    boolean new_arr[] = new boolean[N];
     
    int max_el = Integer.MIN_VALUE;
    
    for(int i=0;i<n;i++)
    {
        if(arr[i]>0 && arr[i]<=n)
        {
            new_arr[arr[i]]=true;
        }
        
        max_el = Math.max(max_el,arr[i]);
        
    }
    
    for(int i=1;i<N;i++)
    {
      if(!new_arr[i])
         return i;
    }
    
    
       return max_el+1;
    }

        public static void d_Main(string[] args)
        {
            int[] arr = { 1, 2, 3,4,5,1,7,8,9,2,4};  
            
            Dupli(arr);
        }
    }
}
