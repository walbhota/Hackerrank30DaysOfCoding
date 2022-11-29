//Objective
//In this challenge, we will use loops to do some math. 

//Task
//Given an integer, n, print its first 10 multiples. Each multiple  (where  1<=i<=10 )
//should be printed on a new line in the form: n x i = result.

//The printout should look like this:

//3 x 1 = 3
//3 x 2 = 6
//3 x 3 = 9
//3 x 4 = 12
//3 x 5 = 15
//3 x 6 = 18
//3 x 7 = 21
//3 x 8 = 24
//3 x 9 = 27
//3 x 10 = 30

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
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }
}
