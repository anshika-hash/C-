using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String To Permutate");
            string str = Console.ReadLine();
            permutation(str , "");
            Console.ReadLine();
        }
        public static void permutation( string ques,string asf)
        {
                if(ques.Length == 0)
                {
                    Console.WriteLine(asf);
                     return;
                }


            for(int i = 0; i < ques.Length; i++)
                {
                    char ch = ques[i];
                    string leftPart = ques.Substring(0, i);
                    string rightPart = ques.Substring(i + 1);
                    string restOfString = leftPart + rightPart;
                    permutation(restOfString , asf + ch);
                }
           
        }
    }
}
