using System;
using static System.Console;

namespace NonRecursive_LinkedList
{
   internal class Node
    {
        public int data;
        public Node next;
        public Node(int _data)
        {
            data = _data;
            next = null;
        }
    }


    class Program
    {
        public static Node insert(Node head, int data)
        {
            // NOTE:
            //If Head Node is NULL, Means there is no added item in the list.

            if(head == null)
            {
                head = new Node(data);
            }
            else
            {
                // NOTE:
                // If Head Node is not NULL, Then we need to interate through the List and insert new Node at the end of Linked List

                // Assign Current head Instance to temp Instance
                Node temp = head;

                // NOTE:
                // Iterate through Linked List via temp.next pointer

                // When temp.next pointer is not null, continue to Iterate the list
                // While going from one pointer to next, assign temp.next to temp

                while (temp.next != null)
                {
                    // NOTE:
                    // Assign next Node pointer to current temp Node
                    temp = temp.next; 
                }

                // NOTE:
                //  When reached at the end of Linked List, add a new Node via temp.next pointer

                temp.next = new Node(data);
            }

            // NOTE:
            // Return the head pointer which points to newly added Node.

            return head;
        }

        public static void display(Node head)
        {
            // NOTE:
            // Start of a Node should point to head Node

            Node node = head;

            while(node != null)
            {
                Write($"[{node.data}] -> ");
                node = node.next;
            }
            Write("NULL");
        }

        static void Main(string[] args)
        {
            WriteLine("Implementation of Linked List without Recursion");
            WriteLine("-----------------------------------------------");

            // Initially, Head Node Should Point to NULL 
            Node head = null;
            
            
            // Insert new Node "2" at the end of List
            head = insert(head, 2);
 
            //// Insert new Node "3" at the end of List
            head = insert(head, 3);

            //// Insert new Node "4" at the end of List
            head = insert(head, 4);

            //// Insert new Node "1" at the end of List
            head = insert(head, 1);

            // Display All Nodes

            display(head);

            WriteLine();


        }
    }
}
