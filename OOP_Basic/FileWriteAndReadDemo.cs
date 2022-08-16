using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



public class FileWriteAndReadDemo
{
    public static void main(string[] args)
    {
        StreamWriter sw = new StreamWriter("Phuc.txt");
        sw.WriteLine("PhucDepTrai");
        sw.Close();

        //FileStream fs = File.OpenRead("Phuc.txt");

        

    }
}
