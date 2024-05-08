using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._02
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            //zadelqne na pamet
            Console.WriteLine("vuvedi 3 elementa");
            int n=int.Parse(Console.ReadLine());
            string[] predmet = new string[3];
            int[]chas=new int[3];

            Console.WriteLine("vhod");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("vuvedi predmet");
                predmet[i] = Console.ReadLine();
                Console.WriteLine("vuvedi chas");
                chas[i]=int.Parse(Console.ReadLine());

            }
            Console.WriteLine("izho 1 ");


            for(int i = 0;i < n; i++)
            {

                Console.WriteLine(predmet[i] + "/" + chas[i]);
            }
            Console.WriteLine("izhod 2");

            for (int i = 0;i<n ; i++)
            {
                if (chas[i] >= 4)
                {
                    Console.WriteLine(predmet[i] + "/" + chas[i]);

                }
                Console.WriteLine("izhod 3");
                Array.Sort(chas);
                for(i = 0; i < n; i++)
                {
                    Console.WriteLine(predmet[i] + "/" + chas[i]);
                }
                Console.WriteLine("izhod 4 ");
                
                Array.Sort(predmet);
                for(i = 0; i < n; i++)
                {
                  
                    Console.WriteLine(predmet[i] + "/" + chas[i]);
                }
                Console.WriteLine("izhod 5");
                Array.Reverse(predmet);
                Array.Sort(predmet);
                for (i = 0; i < n; i++)
                {

                    Console.WriteLine(predmet[i] + "/" + chas[i]);
                }
                Console.WriteLine("izhod 6");
                string nov_Predmet = "matematika";
                for(i = 0; i < n; i++)
                {
                    if (predmet[i] == nov_Predmet)
                   
                }
                Console.WriteLine("izhod 7");
                for(i = 0; i < n;i++)
                {
                    
                    Console.WriteLine(predmet[i] + "/" + chas[i]);
                }
            }

        }

    }
}
