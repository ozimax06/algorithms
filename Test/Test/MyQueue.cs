using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /*
     Queue created with two stacks
     */
    public class MyQueue
    {
        Stack<char> entryStack;
        Stack<char> backUpStack;
        public MyQueue()
        {
            entryStack = new Stack<char>();
            backUpStack = new Stack<char>();
        }

        public void enqueue(char c)
        {
            //add it to entry stack
            entryStack.Push(c);
        }

        public char dequeue()
        {
            char result = ' ';
            //if entry stack is not empty
            //pop each stack and push it to backupstack
            //pop and return top first stack
            //pop each item from back up stack and push it entry stack
            if(entryStack.Count() != 0)
            {
                while(entryStack.Count() != 0)
                {
                    backUpStack.Push(entryStack.Pop());
                }
                result = backUpStack.Pop();

                while (backUpStack.Count() != 0)
                {
                    entryStack.Push(backUpStack.Pop());
                }
            }
            return result;
        }
    }
}
