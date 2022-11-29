using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.
        string userInput;
        int x;
        float y;
        string z;
        // Read and save an integer, double, and String to your variables.
        userInput = Console.ReadLine();
        x = Convert.ToInt32(userInput);
        userInput = Console.ReadLine();
        y = float.Parse(userInput);
        userInput = Console.ReadLine();
        z = userInput;
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(x + i);
        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:F1}", y + d);

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + z);

    }
}
