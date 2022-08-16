using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * C# Basic Exercises.
 *
 * Write a C# program to create a new string from a given string where the
 * first and last characters will change their positions.
 */

public class ChangeFirstAndLastChar
{
    public static string abc(string Meow)
    {

        string result = "";
        string first = Meow.Substring(0, 1);
        string last = Meow.Substring(Meow.Length - 1);
        string ss = Meow.Substring(1, Meow.Length - 2);
        result = last + Meow.Substring(1, Meow.Length - 1) + first;
        //return first;
        //return last;
        //return ss;
        return result;

    }
    //Change this Scope to make change => (main -> Main).
    public static void main(string [] args)
    {
        Console.WriteLine(abc("MMPPMMGG"));
    }
}
