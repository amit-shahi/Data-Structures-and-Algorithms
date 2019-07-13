using System;

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

            Console.Write("[" + data + "]  ->  ");
            if (next != null)
                next.Print();
            if(next == null)
                Console.WriteLine("NULL");
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
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursive Singly Linked List");
            Console.WriteLine();

            SinglyLinkedList node = new SinglyLinkedList();

            node.AddToEnd(10);
            node.AddToEnd(20);
            node.AddToEnd(30);

            node.AddToBegining(1);
            node.AddToBegining(2);

            node.AddToEnd(40);

            node.Print();
        }

    }
}
