using System;
using System.Collections.Generic;

class PalindromeChecker
{
    public static bool IsPalindrome(string text)
    {
        // Clean the string by removing punctuation, whitespace, and converting to lowercase
        string cleanedText = CleanString(text);

        // Initialize a stack and a queue
        Stack<char> stack = new Stack<char>();
        Queue<char> queue = new Queue<char>();

        // Add each character of the cleaned string to the stack and the queue
        foreach (char c in cleanedText)
        {
            stack.Push(c);
            queue.Enqueue(c);
        }

        // Check if the characters removed from the stack and the queue are equal
        while (stack.Count > 0)
        {
            if (stack.Pop() != queue.Dequeue())
            {
                return false;
            }
        }

        return true;
    }

    private static string CleanString(string text)
    {
        // Remove punctuation and whitespace, and convert to lowercase
        string cleanedText = "";
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                cleanedText += char.ToLower(c);
            }
        }
        return cleanedText;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word or phrase to check if it's a palindrome:");
        string input = Console.ReadLine();

        bool isPalindrome = PalindromeChecker.IsPalindrome(input);

        if (isPalindrome)
        {
            Console.WriteLine("Yes, it's a palindrome!");
        }
        else
        {
            Console.WriteLine("No, it's not a palindrome.");
        }
    }
}