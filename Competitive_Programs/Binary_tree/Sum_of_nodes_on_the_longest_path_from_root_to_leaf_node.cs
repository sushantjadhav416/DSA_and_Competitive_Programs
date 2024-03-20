using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class Sum_of_nodes_on_the_longest_path_from_root_to_leaf_node
    {
        //VVIMP

        static int MaxSum;
        static int MaxLen;

        public void MaxLeafSum(Node root, int sum, int len)
        {

            if (root == null)
            {
                if (MaxLen < len)
                {
                    MaxLen = len;
                    MaxSum = sum;
                }
                else if (MaxLen == len && MaxSum < sum)
                {
                    MaxSum = sum;
                }
                return;
            }

            MaxLeafSum(root.left, sum + root.data, len + 1);

            MaxLeafSum(root.right, sum + root.data, len + 1);



        }

        public int sumOfLongRootToLeafPath(Node root)
        {
            //code here
            if (root == null)
                return 0;

            MaxSum = int.MinValue;

            MaxLen = 0;

            MaxLeafSum(root, 0, 0);

            return MaxSum;
        }
    }
}
