using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolko bukvi she vavewdash");
            int n = int.Parse(Console.ReadLine());
            
            string[] bukvi=new string[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("bukvi=");
                bukvi[i] = Console.ReadLine();

            
            }
            for(int i=n-1;i >=0;i--)
            {
                Console.WriteLine(bukvi[i]);

            
           
            }
            Console.WriteLine("izhod 2 ");
            Console.WriteLine(bukvi[1]);
        }
    }
}
