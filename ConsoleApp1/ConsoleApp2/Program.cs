using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("kolko chisla she vavewdash");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("kolko pati she zavyrtam");
            int k=int.Parse(Console.ReadLine());

            int[] chisla = new int [n];
            int[] sum = new int[n];

            int i;
            for ( i = 0; i<5; i++)
            {
                
                Console.WriteLine("vuvedi chisla");
                chisla[i]= int.Parse(Console.ReadLine());

                
              
            }
            Console.WriteLine("izhod bez posleden element");
           
            for(i = 0; i < 5; i++)
            {
                Console.WriteLine(chisla[i]);
            }

            for (i = 0; i < 4; i++)
            {
                chisla[i] = int.Parse(Console.ReadLine());
            } 
            for(i = 0;i < 5; i++)
            {
                Console.WriteLine(chisla[chisla[i] - 1]);
            }
            //zavurtane
            //sum[i]= 0;
            // for (int r = 1; r < n; r++)
            //{
            //    for (i = 0;i < n-1; i++)
            //    {
            //        sum[i] = sum[i] + i + r;
            //        sum[i] = sum[i] + r;
            //    }
            //    Console.WriteLine(sum[i]);
            //    for (i = 0; i < n-1; i++)
            //    {

            //    }
            
        }
    }
}
