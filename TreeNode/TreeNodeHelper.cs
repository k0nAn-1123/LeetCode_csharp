using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class TreeNodeTest
    {
        #region 递归遍历
        public void Preorder(TreeNode node)
        {
            if (node == null)
                return;
            Console.Write(node.val + " ");
            Preorder(node.left);
            Preorder(node.right);
        }
        public void Inorder(TreeNode node)
        {
            if (node == null)
                return;
            Inorder(node.left);
            Console.Write(node.val + " ");
            Inorder(node.right);
        }
        public void Postorder(TreeNode node)
        {
            if (node == null)
                return;
            Postorder(node.left);
            Postorder(node.right);
            Console.Write(node.val + " ");
        }
        #endregion
        #region 非递归遍历
        public void Preorder2(TreeNode node)
        {
            if (node == null)
                return;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(node);
            TreeNode cur = null;
            while (stack.Count != 0)
            {
                cur = stack.Pop();
                if (cur != null)
                {
                    Console.Write(cur.val + " ");
                    stack.Push(cur.left);
                    stack.Push(cur.right);
                }
            }
        }
        public void Inorder2(TreeNode node)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode p = node;
            do
            {
                while (p != null)
                {
                    s.Push(p);
                    p = p.left;
                }
                p = s.Pop();
                Console.Write(p.val + " ");
                if (p.right != null)
                {
                    p = p.right;
                }
                else
                    p = null;
            } while (p != null || s.Count != 0);
        }
        public void Postorder2(TreeNode node)
        {

            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode p = node;
            while (p != null || s.Count != 0)
            {
                while (p != null)
                {
                    s.Push(p);
                    p = p.left;
                }
                p = s.Pop();
                Console.Write(p.val + " ");
                //这里需要判断一下，当前p是否为栈顶的左子树，如果是的话那么还需要先访问右子树才能访问根节点
                //如果已经是不是左子树的话，那么说明左右子书都已经访问完毕，可以访问根节点了，所以讲p复制为NULL
                //取根节点
                if (s.Count != 0 && p == s.Peek().left)
                {
                    p = s.Peek().right;
                }
                else
                    p = null;
            }
        }
        #endregion
    }
}
