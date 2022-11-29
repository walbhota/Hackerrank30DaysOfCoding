//Task
//Consider a database table, Emails, which has the attributes First Name and Email ID.
//Given N rows of data simulating the Emails table,
//print an alphabetically-ordered list of people whose email address ends in @gmail.com.

//Input(stdin)

//6
//riya riya@gmail.com
//julia julia@julia.me
//julia sjulia@gmail.com
//julia julia@gmail.com
//samantha samantha@gmail.com
//tanya tanya@gmail.com
//Expected Output

//julia
//julia
//riya
//samantha
//tanya


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var list = new List<string>();

        for (int i = 0; i < n; i++)
        {
            var tmp = Console.ReadLine().Split(' ');
            var name = tmp[0];
            var email = tmp[1];

            if (Regex.IsMatch(email, @".+@gmail\.com$"))
            {
                list.Add(name);
            }
        }

        list.Sort();

        foreach (var name in list)
        {
            Console.WriteLine(name);
        }
    }
}