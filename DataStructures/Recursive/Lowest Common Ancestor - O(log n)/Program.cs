using System;
using static System.Console;

namespace Lowest_Common_Ancestor___O_log_n_
{
    public class Node {

        public int data;
        public Node left;
        public Node right;

        public Node() {}
        public Node(int data)
        {
            this.data = data;
            this.left = this.right = null;
        }

        

        public Node Insert(Node root, int data)
        {
            if(root == null) return root = new Node(data);

            else if(data <= root.data) 
                root.left = Insert(root.left, data);
            else if(data > root.data)
                root.right = Insert(root.right, data);
            
            return root;
        }
    }
     public class Program
     {
         public static Node LCA(Node root, int v1, int v2)
         {
             if(v1 < root.data && v2 < root.data)
                return LCA(root.left, v1, v2);
            
             if(v1 > root.data && v2 > root.data)
                return LCA(root.right, v1, v2);

             return root;
         }
         public static void Main(string[] args)
         {
             WriteLine();

             WriteLine("Lowest Common Ancestor in O(log n) time");
             WriteLine();

             WriteLine("You are given pointer to the root of the binary search tree and two values  v1 and v2 . You need to return the lowest common ancestor (LCA) of v1 and v2  in the binary search tree.");

             /*

             Complete the function lca in the editor below. It should return a pointer to the lowest common ancestor node of the two values given.

                lca has the following parameters: 
                - root: a pointer to the root node of a binary search tree 
                - v1: a node.data value 
                - v2: a node.data value 
             
            */

             WriteLine();
 

             Node root = null;
             Node node = new Node();

             root = node.Insert(root, 4);
             root = node.Insert(root, 2);
             root = node.Insert(root, 3);
             root = node.Insert(root, 1);
             root = node.Insert(root, 7);
             root = node.Insert(root, 6);
             root = node.Insert(root, 10);
             root = node.Insert(root, 8);
             root = node.Insert(root, 9);
             root = node.Insert(root, 20);
             
             /*
                         4
                       /   \
                      2      7
                     /  \   / \
                    1    3  6  10
                               / \
                              8   9
                                   \
                                    20                      
             
              */

            int v1 = 8;
            int v2 = 20;

            Node lca = LCA(root, v1, v2);

            WriteLine($"Lowest Common Ancestor is: {lca.data}");
            WriteLine();

         }
     }
}
