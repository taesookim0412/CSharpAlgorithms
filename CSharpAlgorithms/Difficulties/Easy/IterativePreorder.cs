using System.Collections.Generic;
using CSharpAlgorithms.Global;

namespace CSharpAlgorithms.Difficulties.Easy
{
    public class IterativePreorder
    {
        public IList<int> PreorderTraversal(TreeNode root) {
            Stack<TreeNode> res = new Stack<TreeNode>();
            List<int> nums = new List<int>();
            if (root == null) return nums;
            res.Push(root);
            while (res.Count > 0){
                TreeNode curr = res.Pop();
                nums.Add(curr.val);
                if (curr.right != null){
                    res.Push(curr.right);
                }
                if (curr.left != null){
                    res.Push(curr.left);
                }
            }
            return nums;
        
        }
    }
}