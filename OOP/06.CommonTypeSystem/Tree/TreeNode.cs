using System;
using System.Collections;
using System.Collections.Generic;

namespace Tree
{
    class TreeNode : IEnumerable<TreeNode>
    {
        private int data;
        public int Data 
        {
            get { return this.data; }
            set { this.data = value;  }
        }

        public TreeNode Left;
        public TreeNode Right;
        
        public TreeNode(int data)
        {
            this.data = data;
            Left = null;
            Right = null;
        }

        public TreeNode Clone()
        {
            TreeNode clone = (TreeNode)MemberwiseClone();
            if (Left != null)
                clone.Left = (TreeNode)Left.Clone();
            if (Right != null)
                clone.Right = (TreeNode)Right.Clone();
            return clone;
        }

        public IEnumerator<TreeNode> GetEnumerator()
        {
            yield return this;

            if (this.Left != null)
            {
                foreach (var child in this.Left)
                    yield return child;
            }
            if (this.Right != null)
            {
                foreach (var child in this.Right)
                    yield return child;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
