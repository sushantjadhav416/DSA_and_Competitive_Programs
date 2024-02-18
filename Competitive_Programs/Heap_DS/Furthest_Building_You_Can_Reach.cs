using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Heap_DS
{
    internal class Furthest_Building_You_Can_Reach
    {
        public int furthestBuilding(int[] heights, int bricks, int ladders)
        {
            // int cont=0;
            // for(int i=0;i<heights.length-1;i++)
            // {
            //      if(heights[i]<heights[i+1])
            //      {
            //          if((heights[i+1]-heights[i])<bricks)
            //          {
            //              bricks = bricks - (heights[i+1]-heights[i]);
            //          }
            //          else
            //          {
            //              ladders = ladders  - 1;
            //          }
            //      }

            //      if(bricks >= 0 && ladders <=0)
            //      {
            //          cont++;
            //      }
            // }

            // return cont;

            Queue<int> minHeap = new Queue<int>();

            for (int i = 1; i < heights.Length; ++i)
            {
                int diff = heights[i] - heights[i - 1];
                if (diff <= 0)
                    continue;
                minHeap.Enqueue(diff);
                // If we run out of ladders, greedily use as less bricks as possible.
                if (minHeap.Count() > ladders)
                    bricks -= minHeap.Peek();
                if (bricks < 0)
                    return i - 1;
            }

            return heights.Length - 1;
        }
    }
}
