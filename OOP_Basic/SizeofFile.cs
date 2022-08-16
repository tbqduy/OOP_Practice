using System;
using System.Collections.Generic;
using System.Linq;
//using CSharpLib;
using System.Text;
using System.Threading.Tasks;
/*
 * C# Basic Exercises.
 *
 * Write a C# program to find the size of a specified file in bytes.
 */

public class SizeofFile
{

    public static void main(string[] args)
    {
        FileInfo fileInfo = new FileInfo("C://Users//ACER//Desktop//learnNet//OOP_Basic//OOP_Basic//Exers2.cs");
        long size = fileInfo.Length;
        Console.WriteLine(size);
        //Console.WriteLine(fileInfo.FormatBytes());
    }
}