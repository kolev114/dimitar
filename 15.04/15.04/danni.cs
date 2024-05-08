using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04
{
    internal class danni
    {
        private string ime;
        private int broika;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public int Broika
        {
            get { return broika; }
            set { broika = value; }
        }
        public int pari
        {
            get { return pari; }
            set { pari = value; }
        }
        public string pitie
        {
            get { return pitie; }
            set { pitie = value; }
        }
        public void izhod1()
        {
            Console.WriteLine($"ti dnes si ql ,{ime},i tvoqta hrana beshe,{broika},");
        }
        public void izhod2()
        {

        }
            
    }

}
