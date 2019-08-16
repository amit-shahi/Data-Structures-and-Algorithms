using System;
using static System.Console;
using System.Collections.Generic;

namespace BuildQueueWithTwoStacks
{

    class MyQueue<T>
    {
        // Always Enqueue() to stack1
        private  Stack<T> stack1 = new Stack<T>();

        // Always Perform Peek() and Dequeue() from stack2
        private Stack<T> stack2 = new Stack<T>();
 


        int position = -1;
        
        // Enqueue()
        public T Enqueue(T item)
        {
             stack1.Push(item);
             return item;
        }

        // Peek()
        public T Peek()
        {
            //TODO
            if(stack2.Count == 0)
            {
                WriteLine("Is Empty"); 
            }

            MoveStack1ToStack2();
            return stack2.Peek();
        }

        // Dequeue()
        public T Dequeue()
        {
            //TODO:
             if(stack2.Count == 0)
            {
                WriteLine("Is Empty"); 
            }

            MoveStack1ToStack2();
            return stack2.Pop();
        }


        // Move Items from Stack1 to Stack2
        private void MoveStack1ToStack2()
        {
            
            if(stack2.Count == 0)
            {
               
                while(stack1.Count > 0)
                { 
                    stack2.Push(stack1.Pop());
                }
            }
        }


        public T[] GetEnumerator()
        { 
            return stack1.ToArray();  
        }
       
      
 
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Generic Queue Implementation with Two Stacks");

            MyQueue<int> myQueue = new MyQueue<int>();

            WriteLine();

            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);

            WriteLine();
            WriteLine("Added Items to the Queue");

           foreach(var item in myQueue.GetEnumerator())
           {
               WriteLine($"[ {item.ToString()} ]");
           }

             
            WriteLine();
            WriteLine("Peek() Front of the Queue");

            WriteLine($"[ {myQueue.Peek()} ]");

            WriteLine();
            WriteLine("Dequqe() from Front of the Queue");

            WriteLine($"[ {myQueue.Dequeue()} ]");
            WriteLine($"[ {myQueue.Dequeue()} ]");

            WriteLine();
            WriteLine("Peek() Front of the Queue");
            WriteLine($"[ {myQueue.Peek()} ]");
           
            // WriteLine(myQueue.Dequeue() +" ");
          
        }
    }
}
