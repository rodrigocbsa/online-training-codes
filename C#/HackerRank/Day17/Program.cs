﻿using System;

//Write your code here
internal class Calculator
{
    internal int power(int n, int p)
    {
        if (n < 0 || p < 0)
            throw new Exception("n and p should be non-negative");

        if (p == 1)
            return n;
        if (p == 0)
            return 1;
        else
        {
            return n * power(n, p - 1);
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