using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a given positive number is a multiple of 3 or
 * a multiple of 7.
 */


public class CheckMultiple3or7
{
    public static void Check(int a)
    {
        if (a > 0)
        {
            if(a%3==0)
            {
                Console.WriteLine("True");
            }else if (a%7 == 0)
            {
                Console.WriteLine("True");
            }else
            {
                Console.WriteLine("False");
            }
            
        }else
        {
            Console.WriteLine("Number is not positive");
        }

    }
    public static void main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        Check(a);

    }
}