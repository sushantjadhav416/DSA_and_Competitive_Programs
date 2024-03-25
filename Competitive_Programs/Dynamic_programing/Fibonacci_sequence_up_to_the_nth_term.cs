using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Dynamic_programing
{
    internal class Fibonacci_sequence_up_to_the_nth_term
    {
        public static int solve(int n)
        {
            //Time com:2**n
            if(n<=1)
               return n;

            int x = solve(n - 1);

            int y = solve(n - 2);

            return x+y;
        }

        public static int fibo_helper(int n, int[] ans)
        {
            //Time Com:O(n) == Space Com

            // Base case
            if (n <= 1)
            {
                return n;
            }

            // To check if output already exists
            if (ans[n] != -1)
            {
                return ans[n];
            }

            // Calculate output
            int x = fibo_helper(n - 1, ans);
            int y = fibo_helper(n - 2, ans);

            // Saving the output for future use
            ans[n] = x + y;

            // Returning the final output
            return ans[n];
        }

        public static int fibo(int n)
        {
            int[] ans = new int[n + 1];

            // Initializing with -1
            for (int i = 0; i <= n; i++)
            {
                ans[i] = -1;
            }
            return fibo_helper(n, ans);
        }

        public static int Better_solve(int n)
        {
            int[] ans = new int[n+1];

            ans[0] = 0;
            ans[1] = 1;

            for(int i=2;i<=n;i++)
            {
                ans[i] = ans[i-1] + ans[i-2] % 1_000_000_007;
            }

            return ans[n];
        }
    }
}
