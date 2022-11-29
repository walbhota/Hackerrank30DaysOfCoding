//Task
//Given set S = {1,2,3..,N} . Find two integers, A and B (where A < B ), from set S such that the value of A & B is the maximum possible and also less than a given integer,K . In this case, & represents the bitwise AND operator.

//Function Description
//Complete the bitwiseAnd function in the editor below.

//bitwiseAnd has the following paramter(s):
//-int N: the maximum integer to consider
//- int K: the limit of the result, inclusive

//Returns
//- int: the maximum value of A&B within the limit

//Sample Input

//STDIN   Function
//-----   --------
//3       T = 3
//5 2     N = 5, K = 2
//8 5     N = 8, K = 5
//2 2     N = 8, K = 5
//Sample Output

//1
//4
//0




using System;

class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);

            if (((k - 1) | k) > n && k % 2 == 0)
            {
                Console.WriteLine(k - 2);
            }
            else
            {
                Console.WriteLine(k - 1);
            }
        }
    }
}