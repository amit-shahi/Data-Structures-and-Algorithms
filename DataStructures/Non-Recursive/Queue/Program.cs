using System;
using static System.Console;
namespace Queue
{
    public class Queue
    {
        private int []element;
        private int front; // Dequeue
        private int rear; // Enqueue
        private int max;

        public Queue(int size)
        {
            element = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void Enqueue(int item)
        {
            if(rear == max-1)
            {
                WriteLine("Can't Enqueue because, Queue is full");
            }
            else
            {
                element[++rear] = item;
            }
        }

        public int Dequeue()
        {
            if( front == rear + 1 )
            {
                WriteLine("Can't Dequeue because, Queue is Empty.");
                return -1;
            }
            else
            {
                WriteLine();
                WriteLine("DEQUEUED");
                WriteLine($"{element[front]} has dequeued from Queue");
                WriteLine();
                int temp = element[front++];
                WriteLine($"Front item of Queue is {element[front]}");
                WriteLine($"Rear/Back item of Queue is {element[rear]}");
                return temp;
            }
        }

        public void Print()
        {
            if(front == rear +1)
            {
                WriteLine("Queue is Empty");
            }
            else
            {
                WriteLine("Enqueued items to Queue Are.");
                WriteLine();

                for(int i=front; i<= rear; i++)
                {
                    Write($"{element[i]}  ");
                }

                WriteLine();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Queue Program");
            WriteLine("-------------");

            Queue queue = new Queue(4);
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            queue.Enqueue(400);
            queue.Enqueue(500);

            WriteLine();
            queue.Print();

            WriteLine();
            queue.Dequeue();

            WriteLine();
            queue.Print();

        }
    }
}
