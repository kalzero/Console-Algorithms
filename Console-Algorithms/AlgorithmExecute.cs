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
    }
}
