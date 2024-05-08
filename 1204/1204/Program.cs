
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            grupa GRUPA = new grupa();

            GRUPA.Name = "Dimitar";
            GRUPA.Adres = "Ivan Vazov";
            GRUPA.Grades = 6;

            GRUPA.izhod();
            GRUPA.izhod1();
            GRUPA.izhod2();
         
            
        }
    }
}
