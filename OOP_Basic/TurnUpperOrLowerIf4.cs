using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to create a new string where the first 4 characters will
 * be in lower case. If the string is less than 4 characters then make the
 * whole string in upper case.
 */
public class TurnUpperOrLowerIf4
{
    public static string Check(string s)
    {
        string newstring;
        int a = s.Length;
        if (a < 4)
        {
            return s.ToUpper();
        }else
        {
            return newstring = s.Substring(0,4).ToLower() + s.Substring(4, a-4);
        }
    }
    public static void main(string[] args)
    {
        string s = Console.ReadLine();
        Console.WriteLine(Check(s));
    }
}