using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] chisla = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("koloko chisla");
                chisla[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0;i < 10;i++)
            {
                if (chisla[i]%2 == 0)
                {
                    Console.WriteLine(chisla[i]);
                }
                else { Console.WriteLine("greshka"); }
            }
        }
    }
}
