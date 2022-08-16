using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to get the century from a year.
 */

public class GetCenturyFromYear
{
    public static void Input(int year)
    {
        string fff = "False";
        if (year < 0)
        {
            Console.WriteLine(fff);
        }
        else if (year > 9999)
        {
            Console.WriteLine("Out of this scope");
        }
        else
        {
            int result = year / 100 + 1;
            Console.WriteLine(result);
        } 
    }
    public static void Main(String[] args)
    {
        int a = int.Parse(Console.ReadLine());
        Input(a);
    }
}