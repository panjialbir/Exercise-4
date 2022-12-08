using System;

namespace StackUsing
{
    class Stack
    {
        private int[] panji;
        private int top;
        private int max;
        public Stack(int size)
        {
            panji = new int[26];
            top = -1;
            max = 26;
        }

        public void push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                panji[++top] = item;
            }
        }
        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + panji[top]);
                return panji[top--];
            }
        }
        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + panji[i]);
                }
            }
        }
    }

