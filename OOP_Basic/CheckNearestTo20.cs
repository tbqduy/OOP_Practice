using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * C# Basic Exercises.
 *
 * Write a C# program to check the nearest value of 20 of two given integers
 * and return 0 if two numbers are same.
 */

public class CheckNearestTo20
{
    public static void Check(int a, int b)
    {
        int val = 20;
        if (a == b)
        {
            Console.WriteLine("0");
        } else
        {
            if (Math.Abs(a - val) < Math.Abs(b - val))
            {
                Console.WriteLine(a);
            }else if (Math.Abs(b-val) < Math.Abs(a - val))
            {
                Console.WriteLine(b);
            }
        }
    }
    public static void main(string[] args)
    {
        Console.WriteLine("Input: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Check(a, b);
    }
}
