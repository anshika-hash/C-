using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
   public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project 2");
            Program obj1 = new Program();
            obj1.Test1();
            obj1.Test2();
            obj1.Test3();
            obj1.Test4();
            obj1.Test5();
            //
            Ref obj = new Ref();
            obj.Test1();
            obj.Test2();
            obj.Test3();
            obj.Test4();
            obj.Test5();
            Console.ReadLine();
        }
        public void Test1()
        {
            Console.WriteLine("Public");
        }
        private void Test2()
        {
            Console.WriteLine("Private");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected");
        }
        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal");
        }
         internal void Test5()
        {
            Console.WriteLine("Internal");
        }
    }

    public class Ref : Program
    {
        public void fun()
        {
            Console.WriteLine("Fun 2");
          
            Console.ReadLine();
        }
    }
}
