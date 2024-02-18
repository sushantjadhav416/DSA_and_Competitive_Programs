using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class Balanced_Binary_Tree
    {
        public int Depth(Node root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Max(Depth(root.left), Depth(root.right));
        }

        public bool isBalanced(Node root)
        {
            if (root == null)
                  return true;

            return Math.Abs(Depth(root.left) - Depth(root.right)) <= 1 && isBalanced(root.left) && isBalanced(root.right);
        }
    }
}
