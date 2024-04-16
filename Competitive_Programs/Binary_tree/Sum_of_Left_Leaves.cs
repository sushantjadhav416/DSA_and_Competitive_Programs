using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class Sum_of_Left_Leaves
    {
        public int sumOfLeftLeaves(Node root)
        {
            if (root == null)
                return 0;

            int sum = 0;

            if (root.left != null)
            {

                if (root.left.left == null && root.left.right == null)
                {
                    sum += root.left.data;
                }
                else
                {
                    sum += sumOfLeftLeaves(root.left);
                }

            }

            sum += sumOfLeftLeaves(root.right);

            return sum;
        }
    }
}
