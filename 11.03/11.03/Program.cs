using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03
{
    internal class Program
    {
        static void Main(string[] args)
        { 
         int n=int.Parse(Console.ReadLine());
            int[] nomer=new int[n];
            string[] ime=new string[n];
            for(int i = 0; i < n; i++)
            {

                Console.WriteLine("nomer");
                nomer[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("ime");
                ime[i] = Console.ReadLine();

            }
            //normalen izhod
            for(int i = 0;i < n; i++)
            {
                Console.WriteLine("nomer" + nomer[i] + "ime" + ime[i]);

            }
            // sortirane po nomer
            for (int i = 0; i < nomer.Length - 1; i++)
            {
                for (int j = 0; j < nomer.Length - 1; j++)
                {
                    if (nomer[j] > nomer[j + 1])
                    {
                        int swapVar = nomer[j];
                        nomer[j] = nomer[j + 1];
                        nomer[j + 1] = swapVar;
                    }
                }
            }
            for(int i = 0; i < n;i++)
            {
                Console.WriteLine(nomer[i] + " ");
            }


            Console.WriteLine("izhopd 3 ");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1-i; j++)
                {
                    if (nomer[j] <nomer[j + 1])
                    {
                        int swapVar = nomer[j];
                        nomer[j] = nomer[j + 1];
                        nomer[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(nomer[i] + " ");
            }
            Console.WriteLine("prqka selekciq");
            for (int i = 1; i < nomer.Length ; i++)
            {
              int k=i ;
                for (int j = i+1; j < nomer.Length; j++)
                    
                {
                    if (nomer[j] < nomer[k])
                        k = j;
                }
                int swapVar = nomer[i];
                nomer[i] = nomer[k];
                nomer[k] = swapVar;
            }
            Console.WriteLine(string.Join(" ", nomer,ime));
            
        }
    }
}
