using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program that takes four numbers as input to calculate and
 * print the average.
 *
 */
public class AverageOfFourNumbersandNumberous
{
    //private static int[] meow = new int[100];
    
    public static void Input4Numbers(double d1, double d2, double d3, double d4)
    {
        double d5 = (d1 + d2 + d3 + d4) / 4;
        Console.WriteLine(d5);

    }

    //public static void InputNumberousNumber(int times, meow)
    //{

    //}
    //Change this Scope to make change => (main -> Main).
    public static void main(string[] args)
    {
        //double d1 = double.Parse(Console.ReadLine());
        //double d2 = double.Parse(Console.ReadLine());
        //double d3 = double.Parse(Console.ReadLine());
        //double d4 = double.Parse(Console.ReadLine());
        //Input4Numbers(d1, d2, d3, d4);

        
        Console.WriteLine("Length of Array []: ");
        int d5 = int.Parse(Console.ReadLine());
        int [] array = new int[100];
        for (int i = 0; i < d5; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < d5; i++)
        {
            Console.WriteLine("Array [" + i + "] " + array[i]);
        }
        int sum = 0;
        for (int i = 0; i < d5; i++)
        {  
            sum += array[i];
        }
        int result = sum / d5;
        Console.WriteLine("Your end result is: " + result);
    }
}
