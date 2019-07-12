using System;
using static System.Console;

namespace Doubly_Linked_List
{
    public class Node
    {
        public int data;

        public Node prev;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            prev = null;
            next = null;
        }
    }

    public class DoublyLinkedList
    {
        public Node head;
        public Node tail;


        public void setHead(Node _node)
        {            
            if(head == null)
            {
                Node node = new Node(_node.data);

                head = node;
                tail = node;
               // node.next = head;
                return;
            }

            // call insertBefore()
        }

        public void setTail(Node node)
        {
            if(tail == null)
            {
                setHead(node);
                return;
            }
            // insertAfter()
        }

        public void insertBefore(Node node, Node newNode)
        {

        }

        public void insertAfter(Node node, Node newNode)
        {

        }

        public void insertAtPosition(Node node, int position, Node newNode)
        {

        }

        public void removeNode(Node node)
        {

        }

        public void removeNodeAtPosition(Node node, int position)
        {

        }

        public void removeNodesWithValue(int value)
        {

        }

        public void containsNodewithValue(Node node)
        {

        }

        public void printList(Node head)
        {
            Node node = head;

            while(node != null)
            {
                Write($" {node.data} -> ");
                node = node.next;
            }
            Write("NULL");

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

            // setHead(), setTail(), insertBefore(), insertAfter()
            // O(1) time | O(1) space

            // insertAtPosition(), 
            // O(p) time -- Because we have to traverse all the way to the position |
            // O(1) space
            Node head = null;
           // head.next = new Node(200);
             
            DoublyLinkedList dllist = new DoublyLinkedList();

           dllist.setHead(new Node(500));
          // dllist.setTail(new Node(20));
           dllist.printList(head); 

            
        }
    }
}
