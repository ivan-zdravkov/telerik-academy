using System;
using System.Threading;

namespace Tree
{
    class Program
    {
        static Random random = new Random();

        static void Main()
        {
            Console.Write("Creating a new Binary Tree...");
            BinarySearchTree tree = new BinarySearchTree();

            int rootData = random.Next(-100, 101);
            Console.WriteLine("(Root = {0})", rootData);
            TreeNode root = tree.CreateNode(rootData);

            int numberOfNodes = random.Next(16, 21);
            Console.WriteLine("Randomly generating {0} tree nodes...", numberOfNodes);
            for (int i = 0; i < numberOfNodes; i++)
            {
                int data = random.Next(-100, 101);
                tree.InsertNode(root, tree.CreateNode(data));
            }
            Console.WriteLine(tree.ToString());
            Console.Write("\nThe tree's hash code is ");
            Console.WriteLine(tree.GetHashCode());

            Console.WriteLine("\nClonning the tree...");
            BinarySearchTree newTree = tree.Clone();
            Console.WriteLine(newTree.ToString());

            CheckTreesForEquality(ref tree, ref newTree);

            Console.WriteLine();
            int numberToSearch = -100;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write("Searching for {0,4} -> ", numberToSearch);
                TreeNode node = tree.Search(numberToSearch);
                Console.WriteLine((node == null) ? "NOT FOUND" : "    FOUND");
                numberToSearch += 10;
            }

            Console.WriteLine("\nUsing foreach to print out the tree...");
            foreach (TreeNode node in tree.Root)
            {
                Console.Write(node.Data + " ");
            }
            Console.WriteLine();
        }

        private static void CheckTreesForEquality(ref BinarySearchTree tree, ref BinarySearchTree newTree)
        {
            Console.Write("\ntree.Equals(newTree) ->  ");
            Console.WriteLine(tree.Equals(newTree));
            Console.Write("(tree == newTree) -> ");
            Console.WriteLine(tree == newTree);
            Console.Write("(tree != newTree) -> ");
            Console.WriteLine(tree != newTree);
        }
    }
}
