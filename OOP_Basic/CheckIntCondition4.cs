using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a given integer is between 20 and 40.
 */
public class CheckIntCondition4
{
    public static void Check(int a)
    {
        if (20 <= a && a <= 40)
        {
            Console.WriteLine("true");
        }else
        {
            Console.WriteLine("false");
        }
    }
    public static void main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        Check(a);
    }
}
