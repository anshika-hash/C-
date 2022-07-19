using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {

        public void test()
        {
            Console.WriteLine("Return Type Void Access Modifier Public");
        }
        private int test(int x)
        {
            Console.WriteLine("Return Type int Access Modifier Private");
            return x;
        }
        internal int test(int x, int y)
        {
            Console.WriteLine("Return Type int Access Modifier internal");
            return x + y;

        }
       /* protected int test(int y, int x)
        {
            Console.WriteLine("Return Type int Access Modifier protected");
            return x + y;
        }
        protected internal int test(int x, int y)
        {
            Console.WriteLine("Return Type int Access Modifier protected internal");
            return x + y;

        } */
        private protected string test(int x, String str)
        {
            Console.WriteLine("Return Type int,string Access Modifier protected internal");
            return x + str;
        }
        public static void main()
        {
            Program obj = new Program();
            obj.test(20);
        }
    }
}
