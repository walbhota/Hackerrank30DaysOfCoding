﻿//Task
//Your local library needs your help! Given the expected and actual return dates for a library book, create a program that calculates the fine (if any). The fee structure is as follows:

//1.If the book is returned on or before the expected return date, no fine will be charged (i.e.:fine = 0 .
//2.If the book is returned after the expected return day but still within the same calendar month and year as the expected return date,fine = 15 Hackos * (number Of days late) .
//3.If the book is returned after the expected return month but still within the same calendar year as the expected return date, the fine = 500 Hackos * (number of months late).
//4.If the book is returned after the calendar year in which it was expected, there is a fixed fine of 1000 Hackos.


using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        var actually = Console.ReadLine().Split(' ');
        var day_a = int.Parse(actually[0]);
        var month_a = int.Parse(actually[1]);
        var year_a = int.Parse(actually[2]);

        var expected = Console.ReadLine().Split(' ');
        var day_e = int.Parse(expected[0]);
        var month_e = int.Parse(expected[1]);
        var year_e = int.Parse(expected[2]);

        var fine = 0;

        if (year_a > year_e)
        {
            fine = 10000;
        }
        else if (year_a == year_e)
        {
            if (month_a > month_e)
            {
                fine = (month_a - month_e) * 500;
            }
            else if (month_a == month_e && day_a > day_e)
            {
                fine = (day_a - day_e) * 15;
            }
        }

        Console.WriteLine(fine);
    }
}