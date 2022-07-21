using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Parent1
    {
        void fun();
    }
    interface Parent2
    {
        void fun();
    }
    class Child : Parent1, Parent2
    {
        void Parent1.fun()
        {
            Console.WriteLine("Child implemented parent1's function");
        }
        void Parent2.fun()
        {
            Console.WriteLine("Child implemented parent1's function");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent1 obj = new Child();
            obj.fun();
            

            Parent2 obj2 = new Child();
            obj2.fun();
            Console.ReadLine();
        }
    }
}
