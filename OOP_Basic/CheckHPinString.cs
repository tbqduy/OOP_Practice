using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if "HP" appears at second position in a string
 * and returns the string without "HP".
 */


public class CheckHPinString
{
    public static string Check(string s)
    {
        string a = "Yes";
        string b = "No";
        int ss = s.Length;
        string position = s.Substring(1, 2);
        if (position == "HP")
        {
            string meow = s.Remove(1, 2);
            return meow;
        }else
        {

            return b;
        }
    }
    public static void main(string[] args)
    {
        Console.WriteLine("Input String you want: ");
        string s = Console.ReadLine();
        Console.WriteLine(Check(s));
    }
}