using CSharpAlgorithms.Global;

namespace CSharpAlgorithms.Difficulties.Easy
{
    public class Solution {
        int res = 0;
        public int GoodNodes(TreeNode root) {
            res = 0;
            Traverse(root, int.MinValue);
            return res;
        }
        public void Traverse(TreeNode root, int max){
            if (root == null) return;
            if (root.val >= max){
                res += 1;
                max = root.val;
            }
            Traverse(root.left, max);
            Traverse(root.right, max);
        }
    
    }
}