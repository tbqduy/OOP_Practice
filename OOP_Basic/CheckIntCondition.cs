using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * C# Basic Exercises.
 *
 * Write a C# program to compute the sum of two given integers. If two values
 * are equal, then return the triple of their sum.
 */


public class CheckIntCondition
{
    public static void Input(int a, int b)
    {
        int c;
        if(a == b)
        {
            c = (a + b) * 3;
        }
        else
        {
            c = a + b;
        }

        Console.WriteLine(c);
    }
    public static void main(string[] args)
    {
        Console.WriteLine("Input 2 Integer Number: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Input(a, b);

    }
}
