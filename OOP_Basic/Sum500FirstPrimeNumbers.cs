using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to compute the sum of the first 500 prime numbers.
 * per line.
 */

public class Sum500FirstPrimeNumbers
{
    public static bool Check(int s)
    {
        int count = 0;
        if (s < 2)
        {
            return false;
        }else
        {
            for(int i = 2; i <= Math.Sqrt(s); i++)
            {
                if(s%i == 0)
                {
                    count++;
                }
            }
        }
        if (count == 0)
        {
            return true;
        }else
        {
            return false;
        }
    }
    public static void main(string[] args)
    {
        int sum = 0;
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            if(Check(i))
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
}
