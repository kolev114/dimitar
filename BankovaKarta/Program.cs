using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovaKarta
{
    internal class Program
    {
         internal class Adres
        {
            public static string NaselenoMqsto;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("kolko danni she vavezdash");
            int n=int.Parse(Console.ReadLine());
            string[] NaseelnoMqsto=new string[n];
            string[] ime = new string[n];
            string[] familiq = new string[n];
            int[] NomerKarta= new int[n];
            double[] vkarqniPari= new double[n];
            double[] lixva = new double[n];
            double[] iztegleni = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("mqsto");
                Adres.NaselenoMqsto = Console.ReadLine();
                NaseelnoMqsto[i] = Adres.NaselenoMqsto;

                Console.WriteLine("imena");
                BankKarta.ime=Console.ReadLine();
                ime[i] = BankKarta.ime;

                Console.WriteLine("familii");
                BankKarta.familiq = Console.ReadLine();
                familiq[i]= BankKarta.familiq;

                Console.WriteLine("nomer na kartata");
                BankKarta.NomerKarta = int.Parse(Console.ReadLine());
                NomerKarta[i]=BankKarta.NomerKarta;

                Console.WriteLine("kolko vkarni pari");
                nalicnost.vkaraniPari = double.Parse(Console.ReadLine());
                vkarqniPari[i] = nalicnost.vkaraniPari;

                Console.WriteLine("kakva lixva");
                nalicnost.lixva=double.Parse(Console.ReadLine());
                lixva[i] = nalicnost.lixva;

                Console.WriteLine("kolko iztegleni pari");
                nalicnost.iztegleni = double.Parse(Console.ReadLine());
                iztegleni[i]=nalicnost.iztegleni;



            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"naseleno mqsto;{NaseelnoMqsto[i]} imeto;{ime[i]} familiqta;{familiq[i]} nomer na kartata;{NomerKarta[i]} vkarani pari;{vkarqniPari[i]}" +
                    $"kakva lixva;{lixva[i]} kolko iztegleni pari;{iztegleni[i]} ");
                double a =double.Parse(Console.ReadLine());

                //Console.WriteLine($"vkarani pari{vkarqniPari[i]} lixva;{lixva[i]} ostanali{vkarqniPari[i]*lixva[i]}" +
                    //$"v kraq na meseca {vkarqniPari[i]} { vkarqniPari[i]*lixva[i]}");
            }

        }
    }
}
