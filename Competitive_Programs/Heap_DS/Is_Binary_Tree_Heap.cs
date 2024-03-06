using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Heap_DS
{
    class Node
    {
       internal  int data;
       internal  Node left, right;
        Node(int d)
        {
            data = d;
            left = right = null;
        }
    }
    internal class Is_Binary_Tree_Heap
    {
        int countNodes(Node root)
        {
            if (root == null)
                return 0;

            return 1 + countNodes(root.left) + countNodes(root.right);

        }

        bool completeBh(Node root, int index, int countNode)
        {
            if (root == null)
                return true;

            if (index >= countNode)
                return false;

            return completeBh(root.left, 2 * index + 1, countNode) && completeBh(root.right, 2 * index + 2, countNode);
        }

        bool IsBHeap(Node tree)
        {
            if (tree.left == null && tree.right == null)
                return true;

            if (tree.right == null)
            {
                return tree.data >= tree.left.data;
            }
            else
            {
                if (tree.data >= tree.left.data && tree.data >= tree.right.data)
                    return IsBHeap(tree.left) && IsBHeap(tree.right);
                else
                    return false;
            }

        }


        bool isHeap(Node tree)
        {
            // code here
            if (tree == null)
                return true;

            if ((completeBh(tree, 0, countNodes(tree)) == true) && (IsBHeap(tree) == true))
                return true;


            return false;
        }
    }
}
