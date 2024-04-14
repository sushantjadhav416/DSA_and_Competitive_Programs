using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class Left_view_of_a_tree
    {
        int Max_level = 0;

        void LeftViewOp(List<int> AL, Node root, int level)
        {
            if (root == null)
                return;

            if (Max_level < level)
            {
                AL.Add(root.data);
                Max_level = level;
            }

            LeftViewOp(AL, root.left, level + 1);
            LeftViewOp(AL, root.right, level + 1);
        }

        List<int> leftView(Node root)
        {
            // Your code here

            List<int> AL = new List<int>();
            Max_level = 0;

            LeftViewOp(AL, root, 1);
            return AL;

        }
    }
}
