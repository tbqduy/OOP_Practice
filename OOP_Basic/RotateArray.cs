using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to rotate an array (length 3) of integers in left
 * direction.
 */

public class RotateArray
{
    public static void main(string[] args)
    {
        int[] arr = new int[100];
        int[] newarr = new int[100];
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Rotate Array");
        for (int i = 0; i < x; i++)
        {
            newarr[i] = Convert.ToInt32((int)arr[x-1-i]);
        }
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine(newarr[i]);
        }
    }
}