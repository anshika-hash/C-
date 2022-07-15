using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Program
    {
        public int x;
        public Program(int x)
        {
            this.x = x;
            Console.WriteLine(x);
        }
        public Program(Program y)
        {
            Console.WriteLine(y.x);
        }

        static void Main(string[] args)
        {
            Program obj = new Program(10);
            Program obj2 = new Program(obj);
            Console.ReadLine();
        }
    }
}
