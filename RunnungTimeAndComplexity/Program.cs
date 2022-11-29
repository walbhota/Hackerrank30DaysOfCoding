//Task
//A prime is a natural number greater than 1 that has no positive divisors other than 1 and itself.
//Given a number, n, determine and print whether it is Prime or Not Prime.

//Explanation

//Test Case 0:n =12 .
//12 is divisible by numbers other than 1 and itself (i.e.: 2, 3, 4, 6), so we print Not Prime on a new line.

//Test Case 1:n = 5 .
//5 is only divisible 1and itself, so we print Prime on a new line.

//Test Case 2:n = 7 .
//7 is only divisible 1 and itself, so we print Prime on a new line.


using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int numberOfInputs = Convert.ToInt32(Console.ReadLine());
        int i, j, inputNumber;
        string output;

        for (i = 1; i <= numberOfInputs; i++)
        {
            inputNumber = Convert.ToInt32(Console.ReadLine());

            for (j = 2; j <= inputNumber / j; j++)
            {
                if (inputNumber % j == 0)
                {
                    inputNumber = 1;
                }
            }
            output = inputNumber == 1 ? "Not prime" : "Prime";
            Console.WriteLine(output);
        }

    }
}