using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Heap_DS
{
    internal class Heap_Height
    {
        static int height(int N)
        {
            return (int) Math.Ceiling(Math.Log(N + 1) / Math.Log(2)) - 1;
        }
    }
}
