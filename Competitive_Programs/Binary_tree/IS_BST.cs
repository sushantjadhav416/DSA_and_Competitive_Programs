namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class IS_BST
    {
       public boolean isValidBST(TreeNode root ,long minval,long maxval)
    {
         if(root == null)
            return true;

         if(root.val >= maxval || root.val <= minval)
           return false;
        
        return isValidBST(root.left,minval,root.val) && isValidBST(root.right,root.val,maxval);

        
    }
    public boolean isValidBST(TreeNode root) {

        // if(root == null)
        //     return true;

        // if(root.left == null && root.right == null)
        //    return true;

        // if(root.left == null || root.right == null)
        //    return false;

        // return ((root.left.val < root.val) && (root.right.val > root.val)) && isValidBST(root.left) && isValidBST(root.right);

        
        return isValidBST(root,Long.MIN_VALUE,Long.MAX_VALUE) ;
        
    }
    }
}
