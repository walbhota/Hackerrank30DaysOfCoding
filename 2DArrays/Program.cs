//Objective
//Today, we are building on our knowledge of arrays by adding another dimension. 
//Context
//Given a 6 X 6 2D Array, :

//1 1 1 0 0 0
//0 1 0 0 0 0
//1 1 1 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0
//We define an hourglass in A to be a subset of values with indices falling in this pattern in A's graphical representation:
//a b c
//  d
//e f g
//There are 16 hourglasses in A, and an hourglass sum is the sum of an hourglass' values.
//Task
//Calculate the hourglass sum for every hourglass in A, then print the maximum hourglass sum.

//Example

//In the array shown above, the maximum hourglass sum is 7 for the hourglass in the top left corner.




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

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int[] sum = new int[16];
        int hourglass = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                sum[hourglass] = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                        + arr[i + 1][j + 1]
                        + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                hourglass++;
            }
        }
        Array.Sort(sum);
        Console.WriteLine(sum[15]);
    }
}
