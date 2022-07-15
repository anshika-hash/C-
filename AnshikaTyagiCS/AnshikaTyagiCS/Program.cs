using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicProgramming;

namespace AnshikaTyagiCS
{
   public  class Program
    {
        static  Program()
        {
            Console.WriteLine("Program Constructor in AnshikaTyagiCS");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Project 1");
           Ref func = new Ref();
           func.fun();
            staticClass.statFun();
            Console.WriteLine(staticClass.x);
            Console.ReadLine();
        }
    }

    public static class staticClass
    {
         static staticClass()
        {
            Console.WriteLine("static ctor in  AnshikaTyagiCS");
        }
        public static int x = 100;
        public static void statFun()
        {
            Console.WriteLine("Static function in  AnshikaTyagiCS");
        }
    }
}
