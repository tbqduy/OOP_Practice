using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program to print on screen the output of adding,
 * subtracting, multiplying and dividing of two numbers which will be entered
 * by the user.
 *
 */

public class Exers2
{
    public void Add(double number1, double number2)
    {
        Console.WriteLine(number1 + number2);
    }
    public void Sub(double number1, double number2)
    {
        Console.WriteLine(number1 - number2);
    }
    public void Mul(double number1, double number2)
    {
        Console.WriteLine(number2 * number1);
    }
    public void Div(double number1, double number2)
    {
        Console.WriteLine(number1 / number2);
    }
    //Change this Scope to make change => (main -> Main).
    public static void main(string[] args)
    {
        Console.WriteLine("Write your number here: ");
        double d1 = double.Parse(Console.ReadLine());
        double d2 = double.Parse(Console.ReadLine());

        
        Exers2 exers2 = new Exers2();
        exers2.Add(d1, d2);
        exers2.Sub(d1, d2);
        exers2.Mul(d1, d2);
        exers2.Div(d1, d2);


    }
}