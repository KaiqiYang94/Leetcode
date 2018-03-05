/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode ConstructMaximumBinaryTree(int[] nums) 
    {
        var stack = new Stack<TreeNode>();
        
    	for(int i =0 ; i < nums.Count(); i++)
    	{
            var add = new TreeNode(nums[i]);
            if(stack.Count() == 0)
            {
                stack.Push(add);
            }
            else
            {
                while(stack.Count() != 0 && stack.Peek().val< nums[i])
                {
                    add.left = stack.Peek();
                    stack.Pop();
                }   
                if(stack.Count() != 0)
                {
                    stack.Peek().right = add;
                }
                stack.Push(add);
            }
    	}
        TreeNode temp = stack.Pop();
        while(stack.Count()!=0)
        {
            temp = stack.Pop();
        }
        return temp; 
    }
}
    
    