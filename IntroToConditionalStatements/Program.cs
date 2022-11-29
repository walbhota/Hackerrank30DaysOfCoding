//using System.Security.Cryptography;

//Objective
//In this challenge, we learn about conditional statements. Check out the Tutorial tab for learning materials and an instructional video.

//Task
//Given an integer,N , perform the following conditional actions:

//If N is odd, print Weird
//If N is even and in the inclusive range of 2 to 5, print Not Weird
//If N is even and in the inclusive range of 6 to 20, print Weird
//If N is even and greater than 20, print Not Weird
//Complete the stub code provided in your editor to print whether or not N is weird.

//Input Format

//A single line containing a positive integer,N .

//Constraints
//1<=N<=100

//Output Format

//Print Weird if the number is weird; otherwise, print Not Weird.

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());


        if (N % 2 == 1)
        {
            Console.WriteLine("Weird");
        }
        else if (N % 2 == 0 && N > 2 && N < 5)
        {
            Console.WriteLine("Not Weird");
        }
        else if (N % 2 == 0 && N > 6 && N <= 20)
        {
            Console.WriteLine("Weird");
        }
        else if (N % 2 == 0 && N > 20)
        {
            Console.WriteLine("Not Weird");
        }
    }
}
