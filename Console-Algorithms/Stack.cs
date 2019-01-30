using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Algorithms
{
    public class Stack
    {
        private int stackCount;
        private object[] localStack;

        public Stack()
        {
            this.stackCount = 0;
            this.localStack = new object[1000];
        }

        public void Push(string data)
        {            
            this.localStack[stackCount] = data;
            stackCount++;
        }

        public void Pop()
        {
            this.localStack[stackCount - 1] = null;
            stackCount--;
        }

        public string Peek()
        {
            return $"StackCount: {stackCount}, Latest Object: {this.localStack[stackCount - 1]}";
        }
    }
}
