
namespace Algorithms
{
    public class AnyTwoNodesSumsToTarget
    {
        public bool TwoSumBSTs(TreeNode root1, TreeNode root2, int target)
        {

            var found = false;
            if (root1.val + root2.val == target)
            {
                return true;
            }
            else if (root1.val + root2.val > target)
            {
                // look in the left of one tree
                if (root1.left != null)
                {
                    found = TwoSumBSTs(root1.left, root2, target);
                }
                if (!found && root2.left != null)
                {
                    found = TwoSumBSTs(root1, root2.left, target);
                }
            }
            else
            {
                // loook in the right of one tree
                if (root1.right != null)
                {
                    found = TwoSumBSTs(root1.right, root2, target);
                }
                if (!found && root2.right != null)
                {
                    found = TwoSumBSTs(root1, root2.right, target);
                }
            }
            if (found)
            {
                return true;
            }
            return false;
        }
    }
}