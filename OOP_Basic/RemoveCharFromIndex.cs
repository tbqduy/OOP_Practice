using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program remove specified a character from a non-empty string
 * using index of a character.
 */
public class RemoveCharFromIndex
{
    public static string Input(string s, int key)
    {
        string error = "Error";
        string newstring;
        if (key > s.Length)
        {
            return error;
        }else
        {
            return s.Remove(key, 1);
        }
    }
    public static void main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        Console.WriteLine(Input(s,x));
    }
}