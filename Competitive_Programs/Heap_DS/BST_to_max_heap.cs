using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Heap_DS
{
    internal class BST_to_max_heap
    {
        static int i;
        public static void inorder(Node root, List<int> arr)
        {
            if (root == null)
                return;

            inorder(root.left, arr);
            arr.Add(root.data);
            inorder(root.right, arr);
        }

        public static void BSTToMaxHeap(Node root, List<int> arr)
        {
            if (root == null)
                return;

            BSTToMaxHeap(root.left, arr);

            BSTToMaxHeap(root.right, arr);

            root.data = arr.ElementAt(i++);

        }

        public static void convertToMaxHeapUtil(Node root)
        {
            //code here
            if (root == null)
                return;


            List<int> arr = new List<int>();
            int i = -1;

            inorder(root, arr);

            BSTToMaxHeap(root, arr);

        }
    }
}
