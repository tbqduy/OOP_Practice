using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program to swap two numbers.
 */

public class SwapTwoNumbers
{
    public static void Swap(int a, int b)
    {
        int temp;

        temp = a;
        a = b;
        b = temp;
        Console.WriteLine(a);
        Console.WriteLine(b);
        
    }
    public static void main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Swap(a, b);

    }

}