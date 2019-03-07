using Console_Algorithms.Algorithms;
using Console_Algorithms.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Algorithms
{
    public class AlgorithmExecute
    {
        public static void RunStack()
        {
            Stack stack = new Stack();

            stack.Push("First");
            stack.Push("Second");
            Console.WriteLine(stack.Peek());
            stack.Push("Third");
            stack.Push("Fourth");
            stack.Push("Fifth");
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Push("Six");
        }

        public static void RunPalindrome()
        {
            string word = "racecar";
            string consoleOutput;

            Palindrome p = new Palindrome();
            p.ReverseString(word, out consoleOutput);

            Console.WriteLine(consoleOutput);
        }

        public static void RunAnalgram()
        {
            string word1, word2;
            Console.WriteLine("Enter the first word and press enter");
            word1 = Console.ReadLine();
            Console.WriteLine("Enter the second word and press enter");
            word2 = Console.ReadLine();

            Anagram ag = new Anagram();
            bool isAnagram = ag.AreWordsAnagram(word1, word2);
            string outputText = string.Empty;
            if (isAnagram)
                outputText = "Both words are analgram";
            else
                outputText = "Both words are not analgram";

            Console.WriteLine(outputText);
        }

        public static void RunLinkedList()
        {
            DataStructures.LinkedList<string> lf = new DataStructures.LinkedList<string>();

            lf.Append("First");
            lf.Append("Second");
            lf.DeletePosition("Second");
            lf.Append("Third");
            lf.Append("Fourth");
            lf.Append("Fifth");
            lf.DeletePosition("First");
            Console.WriteLine(lf.PrintAll());

            DataStructures.LinkedList<string> ll = new DataStructures.LinkedList<string>();

            ll.Prepend("First");            
            ll.Prepend("Second");
            ll.Prepend("Third");
            ll.Prepend("Last");
            ll.DeletePosition("Third");

            Console.WriteLine(ll.PrintAll());
        }

        public static void RunSortExchange()
        {
            Sort s = new Sort();
            int arraySize = 2;
            int[] data = new int[] { 2, 4 };
            int[] data2 = new int[arraySize];

            data2 = s.Exchange<int>(data, 0, 1);

            for (int i = 0; i < data2.Length; i++)
                Console.WriteLine(data2[i]);
        }

        public static void RunBubbleSort()
        {
            Sort s = new Sort();

            int[] data = new int[] { 10, 30, 20, 50, 40, 60, 90, 100, 0, 80 };

            int[] newData = s.BubbleSort(data);

            foreach (int i in newData)
                Console.WriteLine(i);

        }

        public static void RunBinaryTree()
        {         
            string printTree = string.Empty;
            BinaryTree tree = new BinaryTree();
            for (int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                tree.AddRecursive(rand.Next(0, 100));
            }
            printTree = string.Empty;
            tree.Print(null, ref printTree);
            Console.WriteLine(printTree);
        }
    }
}
