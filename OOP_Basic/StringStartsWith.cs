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

public class StringStartsWith
{
    public static string CheckFirst(string s)
    {
        string firstkey = s.Substring(0, 1);
        return firstkey;
    }
    
    public static void main(string[] args)
    {
        Console.WriteLine("Input String: ");
        string s = Console.ReadLine();
        Console.WriteLine("Input First Key Word to Compare");
        string key = Console.ReadLine();
        if (key == CheckFirst(s))
        {
            Console.WriteLine("True");
        }else
        {
            Console.WriteLine("False");
        }
    }
}