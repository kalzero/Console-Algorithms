using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Algorithms.DataStructures
{
    public class BinaryTree
    {
        private BinaryNode _topNode;

        public BinaryTree()
        {
            this._topNode = null;
        }

        public BinaryTree(int initialValue)
        {
            this._topNode = new BinaryNode(initialValue);
        }

        public void Add(int value)
        {        
            if (_topNode == null)
            {
                BinaryNode newNode = new BinaryNode(value);
                _topNode = newNode;
                return;
            }

            BinaryNode currentNode = _topNode;
            bool added = false;
            do
            {
                if (value < currentNode.Value)
                {
                    if (currentNode.Left == null)
                    {
                        BinaryNode newNode = new BinaryNode(value);
                        currentNode.Left = newNode;
                        added = true;
                    }
                    else
                        currentNode = currentNode.Left;
                }
                if (value >= currentNode.Value)
                {
                    if (currentNode.Right == null)
                    {
                        BinaryNode newNode = new BinaryNode(value);
                        currentNode.Right = newNode;
                        added = true;
                    }
                    else
                        currentNode = currentNode.Right;
                }

            } while (!added);
        }

        public void AddRecursive(int value)
        { 
            AddRecursive(ref _topNode, value);
        }

        private void AddRecursive(ref BinaryNode node, int value)
        {
            if (node == null)
            {
                BinaryNode newNode = new BinaryNode(value);
                node = newNode;
                return;
            }
            if (value < node.Value)
            {
                AddRecursive(ref node.Left, value);
                return;
            }
            if (value >= node.Value)
            {
                AddRecursive(ref node.Right, value);
                return;
            }
        }

        public void Print(BinaryNode node, ref string str)
        {
            if (node == null)
            {
                node = _topNode;
            }
            if (node.Left != null)
            {
                Print(node.Left, ref str);
                str = str + node.Value.ToString().PadLeft(3);
            }
            else
                str = str + node.Value.ToString().PadLeft(3);
            
            if (node.Right != null)
            {
                Print(node.Right, ref str);
            }
        }
    }

    public class BinaryNode
    {
        public int Value;
        public BinaryNode Left;
        public BinaryNode Right;

        public BinaryNode(int initialValue)
        {
            this.Value = initialValue;
            this.Left = null;
            this.Right = null;
        }
    }
}
