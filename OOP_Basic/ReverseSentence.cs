using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to reverse the words of a sentence.
 */

public class ReverseSentence
{

    public static void main(string[] args)
    {
        string s = Console.ReadLine();
        char[] ss = new char [s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            ss[i] = s[i];
        }
        int length = ss.Length;
        char[] newstring = new char[100];
        for (int i = length; i > 0; i--)
        {
            newstring[i] = ss[length - i];
        }
        Console.WriteLine(newstring);
    }
}