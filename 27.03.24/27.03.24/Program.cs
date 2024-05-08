using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vhod");
            string str=Console.ReadLine();
            Console.WriteLine("izhod 1");
            Console.WriteLine(str.Length);

            Console.WriteLine("izhod 2");
            string a=Console.ReadLine();
            string b=Console.ReadLine();
            string.Concat( a, b);
            string.Concat( a+b);

            Console.WriteLine("izhod 3 ");
            string ime=Console.ReadLine();
            for(int i = ime.Length-1; i >=0; i--)
            {
                Console.WriteLine(ime[i]);  
            }

            Console.WriteLine("izhod 4 ");
            string str1=Console.ReadLine();
            string[] result = str1.Split();

        }
    }
}
