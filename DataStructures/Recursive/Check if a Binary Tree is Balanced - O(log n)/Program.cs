using System;
using static System.Console;

namespace Check_if_a_Binary_Tree_is_Balanced___O_n_
{
    public class BST
    {
        public int data;
        public BST left, right;

        public BST() {}

        public BST(int data)
        {
            this.data = data;
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

         
        public int IsBalanced(BST root)
        {
            int leftNodeHeight=0;
            int righNodeHeight=0;
 
            if(root == null)
                return 0; 

            if(root.left != null)
                leftNodeHeight = IsBalanced(root.left);
                if(leftNodeHeight == -1)
                 return -1; 

            if(root.right != null)
                righNodeHeight = IsBalanced(root.right);
                if(righNodeHeight == -1)
                return -1; 

            if(Math.Abs(leftNodeHeight-righNodeHeight) > 1)
                return -1;
            
           // return Math.Abs(leftNodeHeight-righNodeHeight) <= 1 ? 1 : 0;
           return Math.Max(leftNodeHeight, righNodeHeight)+1;
        }

    }
    class Program
    {
         
        static void Main(string[] args)
        {
            WriteLine("Check if a Binary Tree is Balanced in O(n) time");
            WriteLine();

            BST root = null;

            BST bst = new BST();

            root = bst.Insert(root, 30);
            root = bst.Insert(root, 8);
            root = bst.Insert(root, 10);
            root = bst.Insert(root, 35);
            root = bst.Insert(root, 40);
            root = bst.Insert(root, 5);
            root = bst.Insert(root, 2);
            root = bst.Insert(root, 1);

            /*
                            30
                           /  \
        leftHeight = 4    8    35       rightHeight=2
                         /  \    \
                        5    10   40
                       /
                      2
                     /
                    1 

            (leftHeight-rightHeight) = 2 // difference should be either 0 or 1

                      DIFF = 2  Hence, ITS NOT A BALANCED TREE
            
            */

            /*
                            30
                           /  \
        leftHeight = 3    8    35       rightHeight=2
                         /  \    \
                        5    10   40
                       /
                      2
                     

            (leftHeight-rightHeight) = 1 // difference should be either 0 or 1

                      DIFF = 1 Hence, ITS A BALANCED TREE
            
            */
            
            
            
 
            WriteLine($"Given Binary Tree is Balanced? { (bst.IsBalanced(root) > -1 ? "Yes" : "No" )}");

            WriteLine();
        }
    }
}
