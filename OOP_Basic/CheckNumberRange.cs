using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if an integer (from the two given integers) is
 * in the range -10 to 10.
 */

public class CheckNumberRange
{
    public static void Check(int a, int b)
    {
        if (Math.Abs(a) <= 10 || Math.Abs(b) <= 10)
        {
            Console.WriteLine("True");
        }else
        {
            Console.WriteLine("False");
        }
    }
    public static void main(string[] args)
    {
        Console.WriteLine("Input");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Check(a, b);
    }
}