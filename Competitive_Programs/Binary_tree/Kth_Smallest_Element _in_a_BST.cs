using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class Kth_Smallest_Element__in_a_BST
    {
        public void Inorder(List<int> AL, Node root)
        {
            if (root == null)
                return;

            Inorder(AL, root.left);
            AL.Add(root.data);
            Inorder(AL, root.right);
        }

        public int kthSmallest(Node root, int k)
        {

            List<int> AL = new List<int>();

            Inorder(AL, root);

            //   Collections.sort(AL);

            return AL.ElementAt(k - 1);

        }
    }
}
