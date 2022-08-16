using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to check two given numbers where one is less than 100 and
 * other is greater than 200.
 */
public class CheckGivenNumbers
{
    public static void main(string[] args)
    {
        Console.WriteLine("Input 1 Number you wanna read: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Input 2 Number you wanna read: ");
        double y = double.Parse(Console.ReadLine());
        if ((x < 100 && y > 200) || (x>200 && y < 100))
        {
            Console.WriteLine("Right");
        }else
        {
            Console.WriteLine("No");
        }
    }
}
