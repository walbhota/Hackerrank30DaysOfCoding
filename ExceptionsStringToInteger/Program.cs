// Task
//Read a string, S, and print its integer value; if S cannot be converted to an integer, print Bad String.

//Note: You must use the String-to-Integer and exception handling constructs built into your submission language.
//If you attempt to use loops/conditional statements, you will get a 0 score.




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
        string S = Console.ReadLine();

        try
        {
            Console.WriteLine(int.Parse(S));
        }
        catch (FormatException)
        {
            Console.WriteLine("Bad String");
        }
    }
}
