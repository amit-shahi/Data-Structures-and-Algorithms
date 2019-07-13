using System;
using static System.Console;
using System.Text;

namespace Doubly_Linked_List
{
    
    public class DoublyLinkedList
    {
        // Internal node class to represent data
        private class Node
        {
            internal int data;

            internal Node prev, next;
            public Node(int data, Node prev, Node next)
            {
                this.data = data;
                this.prev = prev;
                this.next = next;
            }
        }

        private Node head;
        private Node tail;
 
        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }


        public void SetHead(int data)
        {            
            if(head == null)
            {
                Node newNode = new Node(data, null, null);
                //Point newly created node as head & tail if the list contain only 1 item
                head = tail = newNode;
            }
            else 
            {
                Node newHead = new Node(data,null, head);
                // Correcting prev pointer of head 
                head.prev = newHead;
                head = head.prev; 
            }
 
        }

        public void SetTail(int data)
        {
            if(tail == null)
            {
                SetHead(data);
            }
            else 
            {
                Node newTail = new Node(data, tail.prev, null);
                // Update next pointer of current Tail to point to this newTail
                tail.next = newTail;
                tail  = tail.next;
            }
            // insertAfter()
        }

        // Check the value of the First Node if it exists - O(1) time
        public int PeekHeadOrFirst()
        {
           if(head == null) throw new Exception("List is empty");

           return head.data; 
        }

        // Check the value of the Last Node if it exists - O(1) time
        public int PeekTailOrLast()
        {
           if(tail == null) throw new Exception("List is empty");

           return tail.data; 
        }

        // Remove the first value at the head of linked list - O(1) time
        public int RemoveHeadOrFirst()
        {
            if(head == null) throw new Exception("List is empty");
            
            int tempData = head.data;
            head = head.next;

            // Check to make sure if the list is empty after removing the current Head, set tail also as empty.
            if(head == null)
                tail = null;
            else
               // Clean memory of the previous node
                head.prev = null;

            return tempData;
        }

        // Remove the last value at the tail of linked list - O(1) time
        public int RemoveTailOrLast()
        {
            // if(tail == null) throw new Exception("List is empty");
            
            // int tempData = tail.data;
            // tail = tail.prev;

            // // Check to make sure if the list is empty after removing the current Tail, set head also as empty.
            // // if(head == null)
            // //    head = null;
            // // else
            // //    //Clean memory of the previous node
            // //    tail.next = null;

            // return tempData;

            if(head == null) throw new Exception("List is empty");
            if(head.next == null) throw new Exception("Next Node is empty");

            Node lastNode = tail;
            // Find the second last node 
            Node second_last = head;
            

            while (second_last.next.next != null)
            { 
                second_last = second_last.next; 
            }
  
             // Update the next pointer of second last to null
            second_last.next = null;
            tail =  second_last;
        
            return lastNode.data;
        }


        // public void insertBefore(Node node, Node newNode)
        // {

        // }

        // public void insertAfter(Node node, Node newNode)
        // {

        // }

        // public void insertAtPosition(Node node, int position, Node newNode)
        // {

        // }

        // public void removeNode(Node node)
        // {

        // }

        // public void removeNodeAtPosition(Node node, int position)
        // {

        // }

        // public void removeNodesWithValue(int value)
        // {

        // }

        // public void containsNodewithValue(Node node)
        // {

        // }

        public void PrintList()
        {
            Node node = head;

            while(node != null)
            {
                Write($" {node.data} <=> ");
                node = node.next;
            }

            this.HeadandTail();
        }

        public void HeadandTail()
        {
           WriteLine();
           WriteLine("-----------------------------------------");

           Write($"Current Head: {this.PeekHeadOrFirst()} & Current Tail: {this.PeekTailOrLast()}");
           
           WriteLine();
           WriteLine("-----------------------------------------");
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            WriteLine("Doubly Linked List Implentation");

            // Searching - 
            // O(n) time -  Just searching for a node by traversing the entire linked list | 
            // O(1) space - Not storing anything other than current Node, because pointer points to different Node

            // Removing One Item
            // O(1) time | O(1) space

            // Removing Two or More Item
            // O(n) time | O(1) time

            // SetHead(), SetTail(), insertBefore(), insertAfter()
            // O(1) time | O(1) space

            // insertAtPosition(), 
            // O(p) time -- Because we have to traverse all the way to the position |
            // O(1) space
           // head.next = new Node(200);
            
            WriteLine();

            DoublyLinkedList dllist = new DoublyLinkedList();

           dllist.SetHead(500);
           //
           dllist.SetHead(200);
           dllist.SetTail(700);
           dllist.SetTail(50);
           dllist.SetHead(600);

           dllist.PrintList(); 
           WriteLine();
 
           WriteLine($"Removing Head: {dllist.RemoveHeadOrFirst()}");
           WriteLine();

           dllist.PrintList(); 
           WriteLine();
 
           WriteLine($"Removing Tail: {dllist.RemoveTailOrLast()}");
           WriteLine();

           dllist.PrintList(); 
           WriteLine();

           WriteLine($"Removing Head: {dllist.RemoveHeadOrFirst()}");
           WriteLine();

           dllist.PrintList(); 
           WriteLine();
 
           WriteLine($"Removing Tail: {dllist.RemoveTailOrLast()}");
           WriteLine();

           dllist.PrintList(); 
           WriteLine();


           WriteLine();
 
        }
    }
}
