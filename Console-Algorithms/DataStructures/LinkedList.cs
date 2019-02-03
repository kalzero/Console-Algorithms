using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Algorithms.DataStructures
{
    public class LinkedList<T> where T : class
    {        
        private static Node<T> _head;

        public LinkedList()
        {
            _head = null;
        }

        public string PrintAll()
        {
            StringBuilder sb = new StringBuilder();
            Node<T> currentNode = _head;
            // Print all the nodes starting from most recent
            while (currentNode != null)
            {
                sb.Append(currentNode.Data);
                sb.Append("\n");
                currentNode = currentNode.Next;
            }

            return sb.ToString();
        }

        public void Append(T data)
        {                      
            Node<T> newNode = new Node<T>(data);               
            newNode.Next = _head;            
            _head = newNode;
        }

        public void Prepend(T data)
        {
            
            Node<T> newNode = new Node<T>(data);                        

            if (_head == null)
            {
                newNode.Next = _head;
                _head = newNode;
            }
            else
            {
                Node<T> currentNode = _head;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }            
        }

        public void DeletePosition(T data)
        {
            if (_head == null)
                return;

            if (_head.Data == data)
            {
                _head = _head.Next;
                return;
            }

            Node<T> current = _head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }


        }
    }    
}
