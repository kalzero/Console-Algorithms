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
    }
}
