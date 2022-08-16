using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a given string starts with "w" and
 * immediately followed by two "ww".
 *
 * Author: Unai de la O
 */
public class CheckStartingString
{
    public static string Check(string s)
    {
        string ss;
        string check = s.Substring(0, 1);
        if (check == "w")
        {
            string check2 = s.Substring(1, 2);
            if (check2 == "ww")
            {
                return ss = "True";

            }
        }
        ss = "False";
        return ss;
    }
    public static void main(string[] args)
    {
        string s = Console.ReadLine();
        Console.WriteLine(Check(s));

    }
}
