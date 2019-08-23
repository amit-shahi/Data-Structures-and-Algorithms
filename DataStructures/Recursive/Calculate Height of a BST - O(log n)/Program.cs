using System;
using static System.Console;

namespace Calculate_Height_of_a_BST___O_log_n_
{
    public class BST
    {
        public int data;
        public BST left, right;

        public BST() {}
        public BST(int _data)
        {
            this.data = _data;
            this.left = this.right = null;
        }

        public BST Insert(BST root, int data)
        {
            if(root == null) root = new BST(data);
            else if(data <= root.data)
            {
                root.left = Insert(root.left, data);
            }
            else if(data > root.data)
            {
                root.right = Insert(root.right, data);
            }

            return root; 
        }

        public int Height(BST node)
        {
            if(node == null)
             return 0;

            int height = Math.Max(Height(node.left), Height(node.right));

            return height+1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Calculate Height of a Tree in O(logn) time");
            WriteLine();

            WriteLine("Inserted Nodes: 20, 30, 10, 40, 60, 5");

            BST root = null;

            BST bst = new BST();

            root = bst.Insert(root, 20);
            root = bst.Insert(root, 30);
            root = bst.Insert(root, 10);
            root = bst.Insert(root, 40);
            root = bst.Insert(root, 60);
            root = bst.Insert(root, 5);

            WriteLine();
            WriteLine();

            WriteLine($"Height of a Tree is: {bst.Height(root)}");
            WriteLine();
        }
    }
}
