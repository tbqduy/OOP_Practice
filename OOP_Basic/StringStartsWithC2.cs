using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a string starts with a specified word.
 */
public class StringStartsWithC2
{
    public static bool Check(string s, string key)
    {
        if (s.Trim().StartsWith(key))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public static void main(string[] args)
    {
        string s = Console.ReadLine();
        string key = Console.ReadLine();
        if(Check(s, key))
        {
            Console.WriteLine("True");
        }else
        {
            Console.WriteLine("False");
        }
    }
}