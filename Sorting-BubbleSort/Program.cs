//using System.Globalization;
//using System.Xml.Linq;
//using System;

//Task
//Given an array, a, of size n distinct elements, sort the array in ascending order using the Bubble Sort algorithm above. Once sorted, print the following  lines:

//Array is sorted in numSwaps swaps.
//where numSwaps is the number of swaps that took place.
//First Element: firstElement
//where firstElement is the first element in the sorted array.
//Last Element: lastElement
//where lastElement is the last element in the sorted array.
//Hint: To complete this challenge, you will need to add a variable that keeps a running tally of all swaps that occur during execution.



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
        int numberInput = Convert.ToInt32(Console.ReadLine());

        string[] arrayInput = Console.ReadLine().Split(' ');
        int[] numbersArray = Array.ConvertAll(arrayInput, Int32.Parse);

        // Write Your Code Here
        int numberOfSwaps = 0;

        for (int i = 0; i < numberInput; i++)
        {
            for (int j = 0; j < numberInput - 1; j++)
            {
                if (numbersArray[j] > numbersArray[j + 1])
                {
                    Array.Reverse(numbersArray, j, 2);
                    numberOfSwaps++;
                }
            }

            if (numberOfSwaps == 0)
            {
                break;
            }
        }

        int firstPosition = numbersArray[0];
        int lastPosition = numbersArray[numbersArray.Length - 1];

        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {firstPosition}");
        Console.WriteLine($"Last Element: {lastPosition}");
    }

}
