public class IsSubTree
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        var result = true;
        if (!IsSameTree(root,subRoot))
        {
            result = root.left !=null ? IsSubtree(root.left, subRoot): false;
            if (result == false)
            {
                result = root.right != null ? IsSubtree(root.right, subRoot): false;
            }
        }

        return result;
    }

    private bool IsSameTree(TreeNode tree1, TreeNode tree2)
    {
        var result = false;
        if (tree1.val == tree2.val)
        {
            result = tree1.left != null && tree2.left != null ? IsSameTree(tree1.left, tree2.left) : false;
            if (!result)
            {
                if (!(tree1.left == null && tree2.left == null))
                {
                    return false;
                }
            }
            result = tree1.right != null && tree2.right != null ? IsSameTree(tree1.right, tree2.right) : false;
            if (!result)
            {
                if (!(tree1.right == null && tree2.right == null))
                {
                    return false;
                }
            }
            return true;
        }
        return result;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
