using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * C# Basic Exercises.
 *
 * Write a C# program to get the absolute value of the difference between two
 * given numbers. Return double the absolute value of the difference if the
 * first number is greater than second number.
 */

public class CheckIntCondition2
{
    public static void Input(int a, int b)
    {
        int c;
        if ( a > b )
        {
            c = Math.Abs(a - b) * 2;
        } else
        {
            c = Math.Abs(a - b);
        }

        Console.WriteLine(c);  
    }
    public static void main(string[] args)
    {
        Console.WriteLine("Input 2 Numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Input(a, b);

    }
}