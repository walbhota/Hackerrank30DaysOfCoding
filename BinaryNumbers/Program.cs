//Given a base-10 integer, n , convert it to binary (base-2).
//Then find and print the base-10 integer denoting the maximum number of consecutive 1's in n's binary representation.
//When working with different bases, it is common to show the base as a subscript.



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

        var sum = 0;
        var max = 0;

        while (n > 0)
        {
            if (n % 2 == 1)
            {
                sum++;
                if (sum > max)
                {
                    max = sum;
                }
            }
            else
            {
                sum = 0;
            }
            n = n / 2;
        }
        Console.WriteLine(max);
    }
}
