using System;
using static System.Console;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Program");

            Stack stack = new Stack(5);
        

            bool wip = true;
            while(wip)
            {
                WriteLine("What do you want to do? Press " +
                    "\n 1. Push item to Stack " +
                    "\n 2. Pop an item" +
                    "\n 3. Peek an item" +
                    "\n 4. Display stack items"+
                    "\n 5. Exit.");
                try
                {
                    int option = Convert.ToInt16(ReadLine());
                    string item = String.Empty;

                    switch(option)
                    {
                        case 1:
                            WriteLine("Enter an item to push");
                            item = Console.ReadLine();
                            stack.Push(item);
                            break;
                        case 2:
                            WriteLine($"Popping an item {stack.Pop()} from stack" );
                            break;
                        case 3:
                            WriteLine($"Top item on Stack is { stack.Peek()}");
                            break;
                        case 4:
                            WriteLine("Following are stack items");
                            stack.DisplayItems();
                            break;
                        case 5:
                            WriteLine("Press any key to exit out");
                            wip = false;
                            break;
                            
                    }
                    WriteLine();
                }
                catch(Exception ex)
                {
                    throw new InvalidOperationException(ex.Message);
                }
                
            }
        }
    }

    class Stack
    {
        private int maxSize;
        private string[] StackArray;
        private int top;

        public Stack(int size)
        {
            this.maxSize = size;
            this.StackArray = new string[size];
            this.top = -1;
        }

        public void Push(string item)
        {
            if(IsFull())
            {
                WriteLine("Stack is full");
            }
            else
            {
                top++;
                StackArray[top] = item;
            }
        }

        public string Pop()
        {
            if(isEmpty())
            {
                WriteLine("Stack is empty");
                return "Empty";
            }
            else
            {
                int old_top = top;
                top--;
                return StackArray[old_top];
            }
        }

        public string Peek()
        {
            if(!isEmpty())
            {
                return StackArray[top];
            }
            else
            {
                WriteLine("Stack is empty");
                return "Empty";
            }
        }

        public void DisplayItems()
        {
            if(!isEmpty())
            {
                
                  
                for (int i = StackArray.Length-1; i >=0 ; i--)
                { 
                    if(StackArray[i] != null)
                     WriteLine($"[{i}] - {StackArray[i]}");
                     
                }
            }
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            return (maxSize -1 == top);
        }


    } 
}
