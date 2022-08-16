using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check two given integers and return true if one is
 * negative and one is positive.
 *
 * Author: Unai de la O
 */
class CheckPosNegInt
{
    public static void Check(int a, int b)
    {
        if (a <0 && b >0)
        {
            Console.WriteLine("True");
        }else if (a > 0 && b < 0)
        {
            Console.WriteLine("True");
        }else
        {
            Console.WriteLine("False");
        }
    }
    public static void main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Check(a, b);
    }
}
