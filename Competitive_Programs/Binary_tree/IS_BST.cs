namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class IS_BST
    {
       public bool isValidBST(Node root ,long minval,long maxval)
    {
         if(root == null)
            return true;

         if(root.data >= maxval || root.data <= minval)
           return false;
        
        return isValidBST(root.left,minval,root.data) && isValidBST(root.right,root.data,maxval);

        
    }
    public bool isValidBST(Node root) {

        // if(root == null)
        //     return true;

        // if(root.left == null && root.right == null)
        //    return true;

        // if(root.left == null || root.right == null)
        //    return false;

        // return ((root.left.val < root.val) && (root.right.val > root.val)) && isValidBST(root.left) && isValidBST(root.right);

        
        return isValidBST(root,long.MinValue,long.MaxValue) ;
        
    }
    }
}
