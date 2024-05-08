using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne na pamet
            int n = int.Parse(Console.ReadLine());
            string[] pitivo = new string[n];
            double[] cena = new double[n];
            int[] broi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vavedi pitie");
                pitivo [i] = Console.ReadLine();
                Console.WriteLine("vavedi cena");
                cena[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("vavedi broi");
                broi[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("izhod 1");


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("pitie" + pitivo[i] + "/" + "cena" + cena[i] + "/" + "broi" + broi[i]);
            }

                Console.WriteLine("izhod 2 ");


            for (int i = 0; i < n; i++)
            {
                if (broi[i] < 2.5)
                    Console.WriteLine("pitie" + pitivo[i] + "/" + "cena" + cena[i] + "/" + "broi" + broi[i]);

            }

            Console.WriteLine("izhod 3");


            for(int i = 0;i < n; i++)
            {
                if (cena[i] == 2 && pitivo[i] == "kafe")
                    Console.WriteLine("pitie" + pitivo[i] + "/" + "cena" + cena[i] + "/" + "broi" + broi[i]);
            }

            Console.WriteLine("izhod 4");


            Array.Sort(pitivo);
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("pitie" + pitivo[i] + "/" + "cena" + cena[i] + "/" + "broi" + broi[i]);
            }
            
            Console.WriteLine("izhod 6");
            int Firstvalue = 0;
            int midvalute = pitivo.Length / 2;
            int LastValue = pitivo.Length- 1;
             
            Console.WriteLine(pitivo[Firstvalue] + "/" + pitivo[midvalute]+ "/" + pitivo[LastValue]); 
              
            

            Console.WriteLine("izhod 7");

            for (int i = 0; i<n; i++)
            {
                if (pitivo[i] =="kafe")
                {
                    Console.WriteLine("chai");         
                        }
            }
        }
    }
}
