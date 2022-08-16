using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a given string is a palindrome or not.
 */
public class CheckPalindrome
{
    public static void main(string[] args)
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        Console.WriteLine("Is a palindrome?: {0}", isPalindrome(text));
        Console.Write("\nPress any key to exit...");
        Console.ReadKey();
    }
    public static string middle(string s)
    {
        return s.Substring(1, s.Length - 2);
    }
    public static bool isPalindrome(string s)
    {

        if (s.Length <= 1)
        {
            return true;
        }
        if (!s[0].Equals(s[s.Length - 1]))
        {
            return false;
        }
        else
        {
            return isPalindrome(middle(s));
        }
    }

}