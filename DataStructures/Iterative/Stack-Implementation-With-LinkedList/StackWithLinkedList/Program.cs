using System;
using static System.Console;

namespace StackWithLinkedList
{

   

    public class Stack
    {

        public class Node
        {
            public Node next;
            public int data;

            public Node(int data)
            {
                this.data = data;
            }
        }


        private Node top;

        // IsEmpty()
        public bool IsEmpty()
        {
            return top == null;         
        }

        // Peek()
        public int Peek()
        {
            if(!IsEmpty())
            {
                WriteLine($"Top Item is : {top.data}");
                return top.data;
            }
            return -1;
        }

        // Push()
        public void Push(int data)
        {
            Node node = new Node(data);
            node.next = top; // We are doing this so Node.next can point to old top
            top = node; // top points to newly added node

            WriteLine($"Added: {data}");
        }

        // Pop()

        public int Pop()
        {
            if(!IsEmpty())
            {
                int data = top.data;

                top = top.next;
                WriteLine($"Removed: {data}");
                
                return data;
            }
            WriteLine("There is nothing to Pop.");
            return -1;
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Implementation of Stack with Linked List");

            WriteLine();
            WriteLine();

            Stack stack = new Stack();
             
            WriteLine("Push an item to Stack");


            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            WriteLine();
            WriteLine();


            WriteLine("Pop an item from Stack");
            stack.Pop();

            WriteLine();
            WriteLine();

            WriteLine("Peek an item from Stack");
            stack.Peek();

            WriteLine();
            
            ReadKey();
        }
    }
}
