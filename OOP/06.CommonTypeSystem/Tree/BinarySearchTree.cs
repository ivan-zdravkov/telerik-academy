using System;
using System.Collections;
using System.Collections.Generic;

namespace Tree
{
    struct BinarySearchTree : ICloneable
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return root;  }
        }

        private static int count = 0;
        public static int Count
        {
            get { return count; }
        }

        public TreeNode CreateNode(int data)
        {
            TreeNode newNode = new TreeNode(data);

            if (this.root == null)
            {
                root = newNode;
            }
            count++;
            return newNode;
        }

        public void InsertNode(TreeNode root, TreeNode newNode)
        {
            TreeNode temp = root;

            if (newNode.Data < temp.Data)
            {
                if (temp.Left == null)
                {
                    temp.Left = newNode;
                }
                else
                {
                    temp = temp.Left;
                    InsertNode(temp, newNode);
                }
            }
            else if (newNode.Data > temp.Data)
            {
                if (temp.Right == null)
                {
                    temp.Right = newNode;
                }
                else
                {
                    temp = temp.Right;
                    InsertNode(temp, newNode);
                }
            }
        }

        public TreeNode Search(int key)
        {
            if (this.Root == null)
            { 
                return null;
            }

            TreeNode temp = this.Root;

            while (temp != null && temp.Data != key)
            {
                if (temp.Data < key)
                    temp = temp.Right;
                else
                    temp = temp.Left;
            }

            return temp;
        }



        public override string ToString()
        {
            string result = "";
            DisplayTree(this.root, ref result);
            return result;
        }
        
        public void DisplayTree(TreeNode root, ref string result)
        {
            TreeNode temp;
            temp = root;

            if (temp == null)
            {
                return;
            }
            DisplayTree(temp.Left, ref result);
            result += (temp.Data + " ");
            DisplayTree(temp.Right, ref result);
        }

        public override bool Equals(object obj)
        {
            if (this.Root == null || obj == null)
            {
                return false;
            }
            BinarySearchTree node = (BinarySearchTree)obj;
            if (this.Root.Data == node.Root.Data)
            {
                if (this.Root.Left!= null && node.Root.Left != null)
                {
                    bool equalLeft = this.Root.Left.Data.Equals(node.Root.Left.Data);
                    if (!equalLeft)
                    {
                        return false;
                    }
                }
                if (this.Root.Right != null && node.Root.Right != null)
                {
                    bool equalRight = this.Root.Right.Data.Equals(node.Root.Right.Data);
                    if (!equalRight)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(BinarySearchTree first, BinarySearchTree second)
        {
            return (Equals(first, second));
        }

        public static bool operator !=(BinarySearchTree first, BinarySearchTree second)
        {
            return (!(Equals(first, second)));
        }

        public override int GetHashCode()
        {
            return this.Root.GetHashCode();
        }

        public BinarySearchTree Clone()
        {
            BinarySearchTree newTree = new BinarySearchTree();
            newTree.root = this.Root.Clone();

            return newTree;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}
