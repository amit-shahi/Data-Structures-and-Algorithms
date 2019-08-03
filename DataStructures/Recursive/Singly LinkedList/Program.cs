using System;
using static System.Console;

namespace SinglyLinkedList
{

    public class Node
    {
        public int data;
        public Node next;


        public Node(int _data)
        {
            data = _data;
            next = null;
        }

        public void Print()
        {

            Write("[" + data + "]  ->  ");
            if (next != null)
                next.Print();
            if(next == null)
                WriteLine("NULL");
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }

        }


    }
    public class SinglyLinkedList
    {
        public Node headNode;
        public SinglyLinkedList()
        {
            headNode = null;
        }

        public void Print()
        {

            if (headNode != null)
                headNode.Print();
        }

        public void AddToEnd(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
            
        }

        public void AddToBegining(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

       public Node deleteNode(int _data)
       {
           Node node = headNode;

            if(headNode.data == _data)
            {    
                headNode = headNode.next;
                return headNode.next; /* Moved head */
            }

        //    if(node.data == _data)
        //     return headNode.next; /* Moved head */

            while(node.next != null)
            {
                if(node.next.data == _data)
                {
                    node.next = node.next.next;
                    return headNode; /* Head didn't change */
                }
                node = node.next;
            }
         return headNode;
       } 
    }


    class Program
    {
        static void Main(string[] args)
        {
            WriteLine();
            WriteLine("Recursive Singly Linked List");
            WriteLine();
            WriteLine("Time & Space Complexity - Worst Case");
            WriteLine();
            WriteLine("Time Complexity");
            WriteLine();
            WriteLine("Search - O(n)");
            WriteLine();
            WriteLine("Insert");
            WriteLine("At Begining/ Head - O(1)");
            WriteLine("At End/ Tail - O(1)");
            WriteLine();
            WriteLine("Remove");
            WriteLine("At Begining/ Head - O(1)");
            WriteLine("At End/ Tail - O(n)");
            WriteLine("At A Position/ in between - O(n)");

            WriteLine();

            WriteLine("Space Complexity - O(n) : for using a call stack for recursive calls.");

            

            SinglyLinkedList node = new SinglyLinkedList();

            node.AddToEnd(10);
            node.AddToEnd(20);
            node.AddToEnd(30);

            node.AddToBegining(1);
            node.AddToBegining(2);

            node.AddToEnd(40);

            node.Print();

            int deleteNode = 2;
            node.deleteNode(deleteNode);

            WriteLine();
            WriteLine($"After deleting Node {deleteNode}, LinkedList will be -");
            WriteLine();

            node.Print();
        }

    }
}
