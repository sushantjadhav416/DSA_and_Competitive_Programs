using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class Maximum_Width_of_Tree
    {
        //Calculating Width at each level
        int getWidth(Node root, int level)
        {
            if (root == null)
                return 0;

            if (level == 1)
            {
                return 1;
            }
            if (level > 1)
            {
                return getWidth(root.left, level - 1) + getWidth(root.right, level - 1);
            }

            return 0;
        }


        //calculate Total hight of a tree
        int getHight(Node root)
        {
            if (root == null)
                return 0;
            else
            {

                int L = getHight(root.left);
                int R = getHight(root.right);


                return (L > R) ? L + 1 : R + 1;

            }
        }

        //calculate maximum width by calculating width at each level of hight
        int getMaxWidth(Node root)
        {
            // Your code here

            int maxWidth = 0;

            int width = 0;

            int h = getHight(root);

            for (int i = 0; i <= h; i++)
            {
                width = getWidth(root, i);
                if (width > maxWidth)
                {
                    maxWidth = width;
                }
            }

            return maxWidth;

        }
    }
}
