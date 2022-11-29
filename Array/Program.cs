//Objective
//Today, we will learn about the Array data structure. 

//Task
//Given an array, A, of N integers, print A's elements in reverse order as a single line of space-separated numbers.




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

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int[] w = arr.ToArray();


        var k = 0;
        
        for (var i = w.Length-1; i >= 0; i--)
        {
            k = w[i];
            
            Console.Write(k+ " " + " ");
        }
        
    }

}
