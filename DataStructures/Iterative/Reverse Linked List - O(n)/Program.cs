using System;
using System.Collections.Generic;
using static System.Console;

namespace Reverse_Linked_List___O_n_
{
    

    public class LinkedList
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }

        public Node node;

        public LinkedList()
        {
            this.node = null;
        }

        private Stack<Node> rlist = new Stack<Node>();

        public void AddToEnd(int data)
        {
           
            if(node == null)
            {
                node = new Node(data);
                rlist.Push(node);
            }
            else    
            { 

                Node temp = node;

                while(temp.next != null)
                {
                    temp = temp.next;
                }

                // NOTE:
                // Once reached to the end of Linked List then create a new Node and point the exiting tempNode next sequence to the newNode

                Node newNode = new Node(data);
                rlist.Push(newNode);
                temp.next = newNode;
                
            } 
        }

        public void PrintNodes()
        {
            while(node != null)
            {
                Write($" [{node.data}] -> ");
                node = node.next;
            }
                Write(" NULL");
        } 

        public void PrintNodesInReverse()
        {
            while(rlist.Count > 0 )
            {
              node = rlist.Pop();
              Write($" [{node.data}] -> ");  
            }
              Write(" NULL");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Program to Reverse a Linked List");
            WriteLine();

            LinkedList list = new LinkedList(); 

            list.AddToEnd(10);
            list.AddToEnd(20);
            list.AddToEnd(30);
            list.AddToEnd(40);
            list.AddToEnd(50);

            WriteLine("Given Linked List:");
            WriteLine();

            list.PrintNodes();

            WriteLine();
            WriteLine();


            WriteLine("Reverse of Linked List:");
            WriteLine();

            list.PrintNodesInReverse();

            WriteLine();

        }
    }
}
