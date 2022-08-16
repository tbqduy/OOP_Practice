using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to convert a given string into lowercase.
 *
 * Author: Unai de la O
 */
public class StringToLowerCase
{
    public static string Check(string s)
    {
        string newstring = s.ToLower();
        return newstring;
    }
    public static void main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(Check(input));
    }
}