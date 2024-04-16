using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class Search_in_a_Binary_Search_Tree
    {
        public Node searchBST(Node root, int val)
        {
            if (root == null)
                return null;

            if (root.data == val)
                return root;

            if (root.data > val)
                return searchBST(root.left, val);

            return searchBST(root.right, val);


        }
    }
}
