using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check the sum of the two given integers and return
 * true if one of the integer is 20 or if their sum is 20.
 */


public class CheckIntCondition3
{
    public static void Check(int a, int b)
    {
        string s = "true";
        if (a == 20 || b == 20)
        {
            Console.WriteLine(s);
        }
        int c = a + b;
        if (c == 20)
        {
            Console.WriteLine(s);
            Console.WriteLine(c);
        }else
        {
            Console.WriteLine(c);
        }
    }
    public static void main(string[] args)
    {
        Console.WriteLine("Input 1st number: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Check(a, b);

    }
}
