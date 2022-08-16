using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if the first element or the last element of
 * the two arrays ( length 1 or more) are equal.
 */
public class NumberIsFirstOrLastInTwoArrays
{

    public static void main(string[] args)
    {
        int[] arr1 = new int[100];
        int[] arr2 = new int[100];
        Console.WriteLine("Length of First Array: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Length of Second Array: ");
        int y = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < y; i++)
        {
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }
        if ((arr1[0] == arr2[0]) && (arr1[x] == arr2[y]))
        {
            Console.WriteLine("True");
        }else
        {
            Console.WriteLine("False");
        }
    }
}