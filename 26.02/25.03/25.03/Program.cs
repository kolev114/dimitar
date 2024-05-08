using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] pitie = new string[n];
            double[] kolicestvo = new double[n];
            int[] broika = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("kakvo pitie");
                pitie[i] = Console.ReadLine();
                Console.WriteLine("kakvo kolicestvo");
                kolicestvo[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("kakva broika");
                broika[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("ti piesh" + "/" + pitie[i] + "/" + "samo" + broika[i] + "/" + "broika");
            }
            Console.WriteLine("izhod 2 ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("tvoite" + kolicestvo[i] + "/" + "litra sa" + "/" + kolicestvo[i] * 1000 + "/" + "mililitra");
            }
            Console.WriteLine("izhod 3");
            for (int i = 0; i < n; i++)
            {
                if (broika[i] < 2)
                {
                    Console.WriteLine("ti piesh" + "/" + pitie[i] + "samo" + "/" + broika[i] + "/" + "broika");
                }
            }
            Console.WriteLine("izhod 4");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (broika[j] > broika[j + 1])
                    {
                        int swapVar = broika[j];
                        broika[j] = broika[j + 1];
                        broika[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(broika[i] + "");
            }
            Console.WriteLine("izhod 5");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (kolicestvo[j] > kolicestvo[j + 1])
                    {
                        double sWapVar1 = kolicestvo[j];
                        kolicestvo[j] = kolicestvo[j + 1];
                        kolicestvo[j+1]= sWapVar1;
                    }
                }
            }
            for(int i = 0; i < n ; i++)
            {
                Console.WriteLine(kolicestvo[i] + " ");
            }
            Console.WriteLine("izhod 6");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (kolicestvo[j] > kolicestvo[j + 1])
                    {
                        double sWapVar1 = kolicestvo[j];
                        kolicestvo[j] = kolicestvo[j + 1];
                        kolicestvo[j + 1] = sWapVar1;
                    }
                }

                if (kolicestvo[i] == kolicestvo[i])

                {
                    for (int j = 0; j < n; j++)
                    {
                        if (broika[j] > broika[j + 1])
                        {
                            double sWapVar2 = broika[j];
                            broika[j] = broika[j + 1];
                            broika[j + 1] = sWapVar2;
                        }
                        {
                            Console.WriteLine(kolicestvo[i] + " ");
                        }

                    }

                }
            }

        }
    }
}
