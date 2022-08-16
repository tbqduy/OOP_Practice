using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program to that takes three numbers(x,y,z) as input and
 * print the output of (x+y).z and x.y + y.z
 */
public class Exers3
{
    public void Solve1(double x, double y, double z)
    {
        Console.WriteLine((x + y) * z);
    }
    public void Solve2(double x, double y, double z)
    {
        Console.WriteLine(x * y + y * z);
    }
    //Change this Scope to make change => (main -> Main).
    public static void main(string[] args)
    {
        Exers3 ex = new Exers3();
        double d1 = double.Parse(Console.ReadLine());
        double d2 = double.Parse(Console.ReadLine());
        double d3 = double.Parse(Console.ReadLine());

        ex.Solve1(d1, d2, d3);
        ex.Solve2(d1, d2, d3);
    }
}
