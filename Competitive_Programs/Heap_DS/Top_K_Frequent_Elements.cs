

namespace Competitive_Programs.Heap_DS{

class T {
  public int num;
  public int freq;
  public T(int num, int freq) {
    this.num = num;
    this.freq = freq;
  }
}

class Solution {
    public int[] topKFrequent(int[] nums, int k) {

    //     HashMap<Integer,Integer> HM = new HashMap<Integer,Integer>();
       int[] ans = new int[k];
    //     Queue<T> minHeap = new PriorityQueue<>((a, b) -> a.freq - b.freq);

    //     for(int i=0;i<nums.length;i++)
    //     {
    //         if(HM.containsKey(nums[i]))
    //         {
    //             HM.put(nums[i],HM.get(nums[i])+1);
    //         }
    //         else
    //         {
    //            HM.put(nums[i],1);
    //         }
    //     }
    //     int e = 0;
    //     for (Map.Entry<Integer,Integer> entry : HM.entrySet()) 
    //     {
    //          final int num = entry.getKey();
    //          final int freq = entry.getValue();
    //          minHeap.offer(new T(num, freq));
    //          if (minHeap.size() > k)
    //              minHeap.poll();
    //     }

    //    for (int i = 0; i < k; ++i)
    //         ans[i] = minHeap.poll().num;

         return ans;

        }   
    }
}
