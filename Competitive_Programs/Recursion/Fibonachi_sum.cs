using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Recursion
{
	internal class Fibonachi_sum
	{
		public static  int Fibo(int n)
		{
			if (n == 0) 
			{
				return 0;
			}
			else if(n == 1)
			{
				return 1;
			}
			else
			{
				return Fibo(n-2)+Fibo(n-1);
			}
		}

		public static void fibo_Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				Console.Write(Fibo(i) + " ");
			}
		}
	}
}
