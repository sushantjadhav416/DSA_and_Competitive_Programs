using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class Path_Sum
    {
        public bool hasPathSum(Node root, int targetSum)
        {

            if (root == null)
                return false;

            if (root.data == targetSum && root.left == null && root.right == null)
                return true;
            return hasPathSum(root.left, targetSum - root.data) || hasPathSum(root.right, targetSum - root.data);

        }
    }
}
