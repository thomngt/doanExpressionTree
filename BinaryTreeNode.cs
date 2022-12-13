using System;
using System.Collections.Generic;
using System.Text;

namespace doancuoiki
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode LeftChild;
        public BinaryTreeNode RightChild;
        public string Value;

        public bool IsLeaf
        {
            get { return this.LeftChild == null && this.RightChild == null; }
        }

        public BinaryTreeNode(string value)
        {
            Value = value;
        }

    }
}


