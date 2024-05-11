using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Stack_pr
{
    internal class next_greater_element
    {
        public static long[] nextLargerElement_BF(long[] arr, int n)
        {
            // Your code here

            long next;

            for (int i = 0; i < n; i++)
            {
                next = -1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        next = arr[j];
                        break;
                    }
                }
                arr[i] = next;
            }



            return arr;
        }

        public int[] nextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] target = new int[nums1.Length];
            Dictionary<int,int> nextNum = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            int k = 0;

            foreach(int num in nums2)
            {
                while (stack.Count()!=0 && stack.Peek() < num)
                    nextNum.Add(stack.Pop(), num);
                stack.Push(num);
            }

            foreach(int num in nums1)
            {
                if (nextNum.ContainsKey(num)){
                   // target[k++] = nextNum.;
                }
                else{
                    target[k++] = -1;
                }
            }

            return target;

        }
    }
}
