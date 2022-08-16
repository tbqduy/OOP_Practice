using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class WriteReadFile
{
    public static void Check(FileStream fs, string valute)
    {
        byte[] info = new UTF8Encoding(true).GetBytes(valute);
        fs.Write(info, 0, info.Length);
    }
    public static void main()
    {
        string path = @"C:\Users\ACER\Desktop\learnNet\OOP_Basic\OOP_Basic\bin\Debug\net6.0\Phuc.txt";
        if (File.Exists(path))
        {
            File.Delete(path);
        }

        using (FileStream fs = File.Create(path))
        {
            Check(fs, "Hello");
            Check(fs, " HI");
            for (int i = 1; i < 120; i++)
            {
                Check(fs,Convert.ToChar(i).ToString());
            }
        }
    }
}