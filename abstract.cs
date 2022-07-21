using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    abstract class abstractClass
    {
        public abstract void ParentFun();
    } 
    class childClass : abstractClass
    {

        public override void ParentFun()
        {
            Console.WriteLine("Child accessed parent abstract fun");
        }
        public static void Main()
        {

            abstractClass objP = new abstractClass();
            childClass objC = new childClass();
            abstractClass objPC = new childClass();
            objC.ParentFun();
            objPC.ParentFun();
        }

    }
}
