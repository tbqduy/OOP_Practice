using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * C# Basic Exercises.
 *
 * Solve 1: Write a C# program to create a new string from a given string with the first
 * character added at the front and back.
 * Solve 2: Write a C# program to create a new string from a given string with the last character added double times to the back
 * Solve 3: Write a C# program to create a new string from a given string with the middel character added at the back 
*/
using System;

public class Meow
{
    public static string Solve1(string str)
    {
        //Cut first element 
        string change = str.Substring(0, 1);
        //Add String to the last character and front character.
        string result = change + str + change;
        return result;
    }

    public static string Solve2(string str)
    {
        //Number to multify
        int number = 2;
        string change = str.Substring(str.Length - 1, 1);

        //String temp to multify number times.
        string temp = String.Concat(Enumerable.Repeat(change, number));
        string result = str + temp;
        return result;
    }

    public static string Solve3(string str)
    {
        //bool abc = true;
        string change, change2;
        int number;
        string result;
        string bad = "Length must be over than 0";
        while (str.Length > 0)
        {
            if(str.Length % 2 == 0)
            {
                //abc = false;
                number = str.Length / 2;
                change = str.Substring(number -1, 1);
                change2 = str.Substring(number , 1);
                result = str + change + change2;
                return result;
            }
            else
            {
                //abc = true;
                number = (str.Length - 1) / 2;
                change = str.Substring(number, 1);
                result = str + change;
                return result;
            }
        }
        return bad;
    }
    //Change this Scope to make change => (main -> Main).
    public static void main(string[] args)
    {
        Console.WriteLine(Solve1("Phuc"));
        Console.WriteLine(Solve2("Minh"));
        Console.WriteLine(Solve3("PhucP"));
    }
}
