using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

 
//-Amezone VVIMP
namespace Competitive_Programs_and_DSA_Qns.Dynamic_programing
{
    internal class Count_ways_to_N_th_Stair
    {
        long countWays(int n)
        {
            // your code here

            int[] total = new int[n + 1];

            Array.Fill(total, 0);

            total[0] = 1;

            for (int i = 1; i <= n; i++)
                total[i] += total[i - 1];
            for (int i = 2; i <= n; i++)
                total[i] += total[i - 2];


            return (long)total[n];
        }
    }
