using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a given string contains ‘w’ character between
 * 1 and 3 times.
 */
public class Check3wInString
{
    //Change main
    public static void main(string[] args)
    {
        int count = 0;
        Console.WriteLine("Write a string input");
        string s = Console.ReadLine();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i].Equals('w'))
            {
                count++;
            }
        }

        if(count >= 1 && count <= 3)
        {
            Console.WriteLine("OK");
        }else
        {
            Console.WriteLine("Error");
        }
    }
}

