using System;
using static System.Console;

namespace Create_Binary_Search_Tree___O_log_n_
{
    public class BST 
    {
        public int data;
        public BST left, right = null;

        public BST() {}

        public BST(int data)
        {
            this.data = data;
        }

        
        
        public BST Insert(BST root, int data)
        {

            if(root == null) root = new BST(data);
            else if(data <= root.data)
                    root.left = Insert(root.left, data);
            else if(data > root.data) 
                    root.right = Insert(root.right, data);
            
            return root;

        }


        // Recursive Traversal
        // https://en.wikipedia.org/wiki/Tree_traversal

        public void InOrderTraversal(BST root)
        {
            // Left, Root Node, Right
            if(root != null)
            { 
                InOrderTraversal(root.left);
                Write($" {root.data} ");
                InOrderTraversal(root.right);
            }
        }

        public void OutOrderTraversal(BST root)
        {
            // Right, Root Node, Left
            if(root != null)
            {
                OutOrderTraversal(root.right);
                Write($" { root.data} ");
                OutOrderTraversal(root.left);
            }
        }

        public void preOrderTraversal(BST root)
        {
            // Root Node, Left, Right
            if(root != null)
            {
                Write($" {root.data} ");
                preOrderTraversal(root.left);
                preOrderTraversal(root.right);
            }
        }

        public void postOrderTraversal(BST root)
        {
            // Left, Right , Root Node
            if(root != null)
            {
                postOrderTraversal(root.left);
                postOrderTraversal(root.right);
                Write($" {root.data} ");
            }
        }

        public int Height(BST root)
        {
            if(root != null)
            {
                int leftHalf = Height(root.left);
                int rightHalf = Height(root.right);

                return (leftHalf > rightHalf ? leftHalf : rightHalf)+1;
            }
            return -1;
        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Recursive BST Creation & Traversal");
            WriteLine();

            WriteLine("Space & Time Complexity:");
            WriteLine("Traversal Time: O(n) & Space: O(n)");

            BST root = null;

            BST bst = new BST();
            
            root = bst.Insert(root,20);
            root = bst.Insert(root,2);
            root = bst.Insert(root,10);
            root = bst.Insert(root,25);
            root = bst.Insert(root,60);
            root = bst.Insert(root, -1);
            root = bst.Insert(root,125);
            root = bst.Insert(root,160);
            root = bst.Insert(root, 11);

            // Given Nodes
            Write("Given Nodes: ");
            Write("20 2 10 25 60 -1");

            WriteLine();
            WriteLine();

            // Tree Traversal via In-Order
            Write("In-Order Traversal:   (L, RN, R) ");
            bst.InOrderTraversal(root);

            WriteLine();
            WriteLine();

           // Tree Traversal via Out-Order 
           Write("Out-Order Traversal:  (R, RN, L) ");
           bst.OutOrderTraversal(root);

           WriteLine();
           WriteLine();

           // Tree Traversal via Pre-Order
           Write("Pre-Order Traversal:  (RN, L, R) ");
           bst.preOrderTraversal(root);

           WriteLine();
           WriteLine();
           
           // Tree Traversal via Post-Order
           Write("Post-Order Traversal: (L, R, RN) ");
           bst.postOrderTraversal(root);

           WriteLine();
           WriteLine();

           WriteLine($"Height of Tree: {bst.Height(root)}");

           WriteLine();
           WriteLine();

        }
    }
}
