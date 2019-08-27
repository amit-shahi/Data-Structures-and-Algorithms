using System;
using static System.Console;

namespace Singly_Linked_List
{
    public class SinglyLinkedList
    {
           public SinglyLinkedList() {}
        
            public int data;
            public SinglyLinkedList next;
            public SinglyLinkedList(int _data)
            {
                data = _data;
                next = null;
            }
        

        public  SinglyLinkedList InsertAtBeginning(SinglyLinkedList head, int data)
        {
            //NOTE:
            // Check if head pointer is null

            if(head == null)
            {
                //NOTE:
                // If head points to null, then create a new Node with passed in data

                head = new SinglyLinkedList(data);
            }
            else
            {
                // NOTE:
                // If head doesn't point to null, then do following-
                // 1. Create a temp node with passed in data
                // 2. Point temp node's next pointer to head, Because old head node should then be next node of temp node
                // 3. Make sure to assign newly created temp node to head node, so it's at the Beginning of the list

                SinglyLinkedList tempNode = new SinglyLinkedList(data);
                tempNode.next = head;
                head = tempNode;
            }

            return head;
        }

        public  SinglyLinkedList InsertAtEnd(SinglyLinkedList head, int data)
        {
            // NOTE:
            //If Head Node is NULL, Means there is no added item in the list.

            if(head == null)
            {
                head = new SinglyLinkedList(data);
            }
            else
            {
                // NOTE:
                // If Head Node is not NULL, Then we need to interate through the List and insert new Node at the end of Linked List

                // Assign Current head Instance to temp Instance
                SinglyLinkedList temp = head;

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

                temp.next = new SinglyLinkedList(data);
            }

            // NOTE:
            // Return the head pointer which points to newly added Node.

            return head;
        }

        public SinglyLinkedList InsertAtPosition(SinglyLinkedList head, int position, int data)
        {
            SinglyLinkedList newNode = new SinglyLinkedList(data);
            SinglyLinkedList currentNode = head;

            int index = 0;

            while(index < position-1)
            {
                currentNode = currentNode.next;
                index++;
            }

            
            newNode.next = currentNode.next;
            currentNode.next = newNode;

            return head;
        }

        public void DisplayAllNodes(SinglyLinkedList head)
        {
            // NOTE:
            // Start of a Node should point to head Node

            SinglyLinkedList node = head;

            while(node != null)
            {
                Write($"[{node.data}] -> ");
                node = node.next;
            }
            Write("NULL");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Singly Linked List");

            WriteLine("Implementation of Linked List without Recursion");
            WriteLine("-----------------------------------------------");

            //// Initially, Head Node Should Point to NULL 
            SinglyLinkedList head = null;

            SinglyLinkedList list = new SinglyLinkedList();

            //// Insert new Node "1" at the beginning of List

            head = list.InsertAtBeginning(head, 1);

            //// Insert new Node "2" at the end of List
            head = list.InsertAtEnd(head, 2);
 
            //// Insert new Node "3" at the end of List
            head = list.InsertAtEnd(head, 3);

            //// Insert new Node "4" at the end of List
            head = list.InsertAtEnd(head, 4);

            //// Insert new Node "6" at the end of List
            head = list.InsertAtEnd(head, 6);

            //// Insert new Node "5" at the position 4
            head = list.InsertAtPosition(head, 4, 5);

            //// Display All Nodes

            list.DisplayAllNodes(head);

            WriteLine();

        }
    }
}
