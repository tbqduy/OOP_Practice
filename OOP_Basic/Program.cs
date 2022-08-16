using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BASIC_1
{
    class Animal
    {
        public double Weight;
        public double Height;
        public void Info()
        {
            Console.WriteLine(" Height: " + Height + " Weight: " + Weight);
        }
    }

    class Cat
    {
        public double Wei;
        public double Hei;

        public Cat()
        {
            Wei = 1000;
            Hei = 2000;
        }

        //public Cat()
        //{
        //    Wei = 1000;
        //    Hei = 2000;
        //}

        public Cat(int w, int h)
        {
            Wei = w;
            Hei = h;
            //Console.WriteLine(" Height: " + Hei + " Weight: " + Wei);
        }

        public void Info()
        {
            Console.WriteLine(" Height: " + Hei + " Weight: " + Wei);
        }
    }

    internal class Program 
    {
        static void main(string[] args)
        {
            Animal Dog = new Animal();
            Dog.Weight = 50;
            Dog.Height = 60;

            Dog.Info();


            Cat WhiteCat = new Cat();
            WhiteCat.Info();

            Cat BlackCat = new Cat(400,500);
            BlackCat.Info();
            
        }
    }
}