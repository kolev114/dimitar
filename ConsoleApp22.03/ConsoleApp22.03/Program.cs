using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string[] ime = new string[n];
            int[] nomer = new int[n];
            string[] predmet= new string[n];
            double[] ocenka= new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("kakvo ime");
                ime[i] = Console.ReadLine();
                Console.WriteLine("koi nomer");
                nomer[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("koi predmet");
                predmet[i] = Console.ReadLine();
                Console.WriteLine("kakva ocenka");
                ocenka[i] =double.Parse( Console.ReadLine());
            }
        
        Console.WriteLine("izhod 1");
                for (int i = 0; i < n; i++)
                {
                Console.WriteLine($"az {ime[i]} s nomer v klas: {nomer[i]} po predmet {predmet[i]} imam {ocenka[i]} ");

                }
            Console.WriteLine("izhod 2");
            for(int i = 0;i < n; i++)
            {
                if (ocenka[i] >= 5.25)
                {
                    Console.WriteLine($"az {ime[i]} s nomer v klas: {nomer[i]} po predmet {predmet[i]} imam {ocenka[i]} ");

                }
                

            }
        
        Console.WriteLine("izhod 3");
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1-i; j++)
                {
                    if (ocenka[j] > ocenka[j+1])
                    {
                        double swapVar = ocenka[j];
                        ocenka[j]= ocenka[j+1];
                        ocenka[j+1] = swapVar;
                        

                    }
                }
            }
            for( int i = 0; i < ocenka.Length; i++)
            {
                Console.WriteLine(ocenka[i] + " ");
            }

            Console.WriteLine("izhod 4");

            for (int i = 0;i<n ; i++) 
            {
                if (ime[i] == "genadi" && nomer[i]>= 5 && nomer[i] <= 10)
                {
                    Console.WriteLine($"az {ime[i]} s nomer v klas: {nomer[i]} po predmet {predmet[i]} imam {ocenka[i]} ");

                }
            }
            Console.WriteLine("izhod 5");
            for( int i = 0;i<n-1 ; i++)
            {
                for( int j = 0;j < n-1-i; j++)
                {
                    if (string.Compare(ime[j] , ime[j + 1]) > 0)
                    {
                        string swapVar = ime[j];
                        ime[j] = ime[j+1];
                        ime[j + 1] = swapVar;

                    }
                }
            }
            for (int i = 0; i < ime.Length; i++)
            {
                Console.WriteLine(ime[i] + " ");
            }


            Console.WriteLine("izhod 6");


            for(int  i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (string.Compare(predmet[j], predmet[j + 1]) > 0)
                    {
                        string swapVar = predmet[j];
                        predmet[j] = predmet[j + 1];
                        predmet[j + 1] = swapVar;
                   }
                
                }
            }
            for(int i = 0;i < predmet.Length; i++)
            {
                Console.WriteLine(predmet[i]+" ");
            }

        }
    }
}
