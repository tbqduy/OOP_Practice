using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if an array contains an odd number.
 */

public class CheckOddNumberInArray
{
    public static bool Check(int a)
    {
        if (a % 2 != 0)
        {
            return true;
        }
        return false;
    }

    public static void main(string[] args)
    {
        int[] b = new int[100];
        Console.WriteLine("Input Length of Array: ");
        int a = int.Parse(Console.ReadLine());
        for (int i = 0; i < a; i++)
        {
            b[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < a; i++)
        {
            if (Check(b[i]))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}