﻿using System.Collections.Generic;
using System.ComponentModel;

//Task

//A palindrome is a word, phrase, number, or other sequence of characters which reads the same backwards and forwards.
//Can you determine if a given string, s, is a palindrome?

//To solve this challenge, we must first take each character in s, enqueue it in a queue, and also push that same
//character onto a stack. Once that's done, we must dequeue the first character from the queue and pop the top
//character off the stack, then compare the two characters to see if they are the same; as long as the characters
//match, we continue dequeueing, popping, and comparing each character until
//our containers are empty (a non-match means s isn't a palindrome).

//Write the following declarations and implementations:

//Two instance variables: one for your stack, and one for your queue.
//A void pushCharacter(char ch) method that pushes a character onto a stack.
//A void enqueueCharacter(char ch) method that enqueues a character in the queue instance variable.
//A char popCharacter() method that pops and returns the character at the top of the stack instance variable.
//A char dequeueCharacter() method that dequeues and returns the first character in the queue instance variable.



using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    //Write your code here
    public Stack<char> charS = new Stack<char>();
    public Queue<char> charQ = new Queue<char>();

    void pushCharacter(char c)
    {
        charS.Push(c);
    }

    char popCharacter()
    {
        return charS.Pop();
    }
    void enqueueCharacter(char c)
    {
        charQ.Enqueue(c);
    }

    char dequeueCharacter()
    {
        return charQ.Dequeue();
    }


    static void Main(String[] args)
    {
        // read the string s.
        string s = Console.ReadLine();

        // create the Solution class object p.
        Solution obj = new Solution();

        // push/enqueue all the characters of string s to stack.
        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }

        bool isPalindrome = true;

        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;

                break;
            }
        }

        // finally print whether string s is palindrome or not.
        if (isPalindrome)
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        }
        else
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}