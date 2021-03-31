using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models
{
    public class ModelHelper
    {
        private int Length = 0;
        public TreeNode GetTreeNode()
        {
            Random rd = new Random();
            int val = rd.Next(0, 10);
            TreeNode node = new TreeNode(val);

            if (Length > 5)
                return node;

            node.left = GetTreeNode();
            node.right = GetTreeNode();
            Length++;
            return node;
        }
    }
}
