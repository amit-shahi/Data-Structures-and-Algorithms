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

        public bool Find(BST root, int data) // Contains
        {
            if(root == null)
                return false;

            if(root.data == data)
                return true;

            else if(data < root.data) // left sub tree traversal
            {
                if(root.left == null)
                    return false;
                else
                    return Find(root.left, data);
            }
            else if(data > root.data) // right sub tree traversal
            { 
                if(root.right == null)
                    return false;
                else
                    return Find(root.right, data);
            }
             
            
            return false;
        }

        // TODO
        // public BST Remove() 
        // {

        // }


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
            
            root = bst.Insert(root,5);
            root = bst.Insert(root,15);
            root = bst.Insert(root,22);
            root = bst.Insert(root,17);
            root = bst.Insert(root,34);
            root = bst.Insert(root, 7);
            root = bst.Insert(root,2);
            root = bst.Insert(root,5);
            root = bst.Insert(root, 1);
            root = bst.Insert(root, 35);
            root = bst.Insert(root, 27);
            root = bst.Insert(root, 16);
            root = bst.Insert(root, 30);
            root = bst.Insert(root, 22);
            root = bst.Insert(root, 17);

            // Given Nodes
            Write("Given Nodes: ");
            Write("5 15 22 17 34 7 2 5 1 35 27 16 30 22 17");

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

           
           // Find a Node by a value
           int findValue = 27;
           Write($"Does Node with value {findValue} exists? ");
           WriteLine($"{(bst.Find(root, findValue)==true?"Yes":"No")}");

           WriteLine();
           WriteLine();

           // Find Height of a Tree
           WriteLine($"Height of Tree: {bst.Height(root)}");

           WriteLine();
           WriteLine();

        }
    }
}
