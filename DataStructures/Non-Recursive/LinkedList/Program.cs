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
        public static Node insertAtBeginning(Node head, int data)
        {
            //NOTE:
            // Check if head pointer is null

            if(head == null)
            {
                //NOTE:
                // If head points to null, then create a new Node with passed in data

                head = new Node(data);
            }
            else
            {
                // NOTE:
                // If head doesn't point to null, then do following-
                // 1. Create a temp node with passed in data
                // 2. Point temp node's next pointer to head, Because old head node should then be next node of temp node
                // 3. Make sure to assign newly created temp node to head node, so it's at the Beginning of the list

                Node tempNode = new Node(data);
                tempNode.next = head;
                head = tempNode;
            }

            return head;
        }

        public static Node insertAtEnd(Node head, int data)
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


            head = insertAtBeginning(head, 1);

            // Insert new Node "2" at the end of List
            head = insertAtEnd(head, 2);
 
            //// Insert new Node "3" at the end of List
            head = insertAtEnd(head, 3);

            //// Insert new Node "4" at the end of List
            head = insertAtEnd(head, 4);

            //// Insert new Node "1" at the end of List
            head = insertAtEnd(head, 5);

            // Display All Nodes

            display(head);

            WriteLine();


        }
    }
}
