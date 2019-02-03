using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Algorithms.DataStructures
{
    public class Node<T> where T : class
    {
        public Node<T> Next;
        public T Data;
        public Node(T data)
        {
            this.Data = data;
        }
    }
}
