using System;

namespace BinarySearchTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int _data)
        {
            data = _data;
            left = null;
            right = null;
        }
    }

    public class BSTree
    {
 
        public Node root;
  
        public BSTree()
        {
            root = null;
        }

        public BSTree(int _data)
        {
            root = new Node(_data);
        }

        public void Insert(int _data)
        {
            // non-recurive

            // recursive

            Node newNode = new Node(_data);
            newNode.data = _data;

            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if( _data < current.left)
                    {

                    }
                    else
                    {
                        current = current.right;
                    }
                }
            }

        }

        

        public void Remove()
        {

        }

        //public void Traverse()
        //{
        //    if(left != null)
        //    {
        //        left.Traverse();
        //    }
        //    Console.WriteLine(data);

        //    if(right != null)
        //    {
        //        right.Traverse();
        //    }
        //    Console.WriteLine(data);
        //}




    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
