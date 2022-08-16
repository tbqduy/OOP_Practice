using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write file in C#
//Revise in writing and reading file.

public class WriteFile
{
    public static void AddFile(FileStream fs, string value)
    {
        byte[] info = new UTF8Encoding(true).GetBytes(value);
        fs.Write(info, 0, info.Length);
    }
    public static void main(String[] args)
    {
        string path = @"C:\Users\ACER\Desktop\learnNet\OOP_Basic\OOP_Basic\bin\Debug\net6.0\Phuc.txt";
        if (File.Exists(path))
        {
            File.Delete(path);
        }

        using (FileStream fs = File.Create(path))
        {
            AddFile(fs, "PhucDepTraiVodoi");
            AddFile(fs, "Hello");
            AddFile(fs, "MeowMeow");
            AddFile(fs, "Hi");

            for (int i = 1; i < 120; i++)
            {
                AddFile(fs, Convert.ToChar(i).ToString());
            }
        }
        using (FileStream fs = File.OpenRead(path))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            while (fs.Read(b,0, b.Length) > 0)
            {   
                Console.WriteLine(temp.GetString(b));
            }
        }

    }
}