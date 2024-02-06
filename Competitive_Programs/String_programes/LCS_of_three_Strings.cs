using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//VVVIMP
namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class LCS_of_three_Strings
    {
        int LCSof3(String A, String B, String C, int n1, int n2, int n3)
        {
            // code here

            int[,,] str_arr = new int[n1 +1,n2 + 1,n3 + 1];


            for (int i = 0; i <= n1; i++)
            {
                for (int j = 0; j <= n2; j++)
                {
                    for (int k = 0; k <= n3; k++)
                    {
                        if (i == 0 || j == 0 || k == 0)
                        {
                            str_arr[i,j,k] = 0;
                        }
                        else if (A.[i - 1] == B[j - 1] && A[i - 1] == C[k - 1])
                        {
                            str_arr[i,j,k] = str_arr[i - 1,j - 1,k - 1] + 1;
                        }
                        else
                            str_arr[i,j,k] = Math.Max(Math.Max(str_arr[i - 1,j,k], str_arr[i,j - 1,k]), str_arr[i,j,k - 1]);
                    }
                }
            }

            return str_arr[n1,n2,n3];
        }
    }
}
