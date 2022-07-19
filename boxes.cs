using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    class boxes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No Of Boxes");
            int Boxes = int.Parse(Console.ReadLine());
            fun(Boxes, "");
            Console.ReadLine();
        }
        public static void fun(int noBoxes, string asf)
        {
            if (noBoxes == 0)
            {
                Console.WriteLine(asf);
                return;
            }

                fun(noBoxes-1, asf + "-");
                fun(noBoxes-1, asf + "+");
            

        }
    }
}
