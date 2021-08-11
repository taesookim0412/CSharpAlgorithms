using System.Collections.Generic;
using CSharpAlgorithms.Global;

namespace CSharpAlgorithms.Difficulties.Easy
{
    public class IterativeInorder
    {
        public IList<int> InorderTraversal(TreeNode root) {
            Stack<TreeNode> nodes = new Stack<TreeNode>();
            List<int> nums = new List<int>();
            if (root == null) return nums;
            TreeNode curr = root;
            while (nodes.Count > 0 || curr != null){
                while (curr != null){
                    nodes.Push(curr);
                    curr = curr.left;
                }
                curr = nodes.Pop();
                nums.Add(curr.val);
                curr = curr.right;
            }
            return nums;
        }
    }
}