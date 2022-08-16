using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basic_2
{
    class People
    {
        public string name;
        public int age;
        public string sex;
    }
    class Student : People
    {
        public int id;
        public int total;
        //1 is male, 0 is female

        public Student (string a, int b, string c, int d)
        {
            name = a;
            age = b;
            sex = c;
            total = d;
        }
        public void Info()
        {
            Console.WriteLine(" Name is: " + name + "\n" + 
                              " Id Student is: " + id + "\n" +
                              " Age Student is: " + age + "\n" +
                              " Total student is: " + total + "\n" +
                              " Sex student is: " + sex);
        }
    }
    internal class StudentManagement
    {
        static void main(String[] args)
        {
            Student Phuc = new Student("Phuc", 22, "Male", 100);
            Phuc.Info();
        }
    }

    
}
