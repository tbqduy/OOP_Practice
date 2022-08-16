using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to compute the sum of all the elements of an array of
 * integers.
 */
public class SumArrayElements
{
    public static void main(string[] args)
    {
        int s = int.Parse(Console.ReadLine());
        int[] arr = new int[100];
        int sum = 0;
        for(int i = 0; i < s; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < s; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum);
    }
}