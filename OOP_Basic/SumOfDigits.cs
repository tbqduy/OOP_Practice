using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program and compute the sum of the digits of an integer.
 */

public class SumOfDigits
{
    public static void Check(int s)
    {
        string length_str = s.ToString();
        int length = length_str.Length;
        int sum = 0;
        int result;
        for (int i = 0; i < length; i++)
        {
            result = s % 10;
            sum += result;
            s /= 10;
        }
        Console.WriteLine(sum);
    }
    public static void main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        Check(input);
    }
}