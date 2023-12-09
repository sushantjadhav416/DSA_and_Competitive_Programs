using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Matrix
{
	internal class Minimun_number_1s
	{
		public static int mini_num_1ns(int[,]A,int N,int M)
		{
			int count, maxcount = int.MaxValue, index = 0;
			for (int i = 0; i < N; i++)
			{
				count = 0;
				for (int j = 0; j < M; j++)
				{
					if (A[i,j] == 1)
						count++;
				}
				if (count < maxcount)
				{
					maxcount = count;
					index = i + 1;
				}
			}
			return index;

		}
		public static void mini_Main(string[] args)
		{

		}
	}
}
