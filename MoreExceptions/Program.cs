//Task
//Write a Calculator class with a single method: int power(int, int).
//The power method takes two integers,n and p, as parameters and returns the integer result of nP.
//If either n or p is negative, then the method must throw an exception with the message: n and p should be non-negative.



using System;

//Write your code here
class Calculator
{
    public int power(int n, int p)
    {
        if (n < 0 || p < 0)
        {
            throw new Exception("n and p should be non-negative");
        }
        else
        {
            return Convert.ToInt32(Math.Pow(n, p));
        }
    }
}
class Solution
{
    static void Main(String[] args)
    {
        Calculator myCalculator = new Calculator();
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }



    }
}