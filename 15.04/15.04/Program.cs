using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            danni A = new danni();
            Console.Write("kakvo qde dnes ");
            A.Ime = Console.ReadLine();
            Console.Write("kolok puti qde");
            A.Broika = int.Parse(Console.ReadLine());
            A.izhod1();


            if (A.Broika > 5)
            {
                A.Broika = A.Broika * 5;
                Console.WriteLine("ti si ql s natrubvane:{0}", A.Broika);
            }

            else
            {
                Console.WriteLine("broikata ti e pod 5");
            }
            A.izhod2();
           


            Console.Write("pil li si neshto dnes;da/ne");
             string da = Console.ReadLine();
            if (da == "da")

            {
                Console.WriteLine("kakvo si pil izberi cifra ot 0 do 3");
              //   A.pitie = Console.ReadLine();
                int chisla = int.Parse(Console.ReadLine());
               
                switch(chisla)
                {
                        case 1: Console.WriteLine("ti si pil vodka");break;
                        case 2: Console.WriteLine("ti si pil martini");break;
                        case 3: Console.WriteLine("ti si pil voda");break;
                        case 4: Console.WriteLine("ti si pil uiski");break;
                        default: Console.WriteLine("error");break;
                }
            }
            else
            {
                Console.WriteLine("ako ne lek den ");
            }
           
           
        }
        }
    }

