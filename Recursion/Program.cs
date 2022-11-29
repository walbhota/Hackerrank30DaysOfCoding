//Objective
//Today, we are learning about an algorithmic concept called recursion.


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

    /*
    * Complete the 'factorial' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts INTEGER n as parameter.
    */


    public static int factorial(int n)
    {
        if (n == 0) return 0;
        else if (n == 1) return 1;
        return factorial(n - 1) * n;
    }
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = factorial(n);

        Console.WriteLine(result);


        //use long so as to be able to get the factorial of larger numbers

        //public static long factorial(long n)
        //{
        //    if (n == 0) return 0;
        //    else if (n == 1) return 1;
        //    return factorial(n - 1) * n;
        //}
        //public static void Main(string[] args)
        //{

        //    long n = Convert.ToInt64(Console.ReadLine().Trim());

        //    long result = factorial(n);

        //    Console.WriteLine(result);


        //}
    }
}
