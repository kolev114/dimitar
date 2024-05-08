using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vyvedi ime");
            string str = "hello,dimitar v c#";
            string name=Console.ReadLine();
            Console.WriteLine("hi,"+name);
            Console.WriteLine("vyvedi 2 ime");
            string lastname=Console.ReadLine();
            Console.WriteLine("hi,{0}",name,lastname);
            Console.WriteLine(" ime 3 ");
            string familiname=Console.ReadLine();
            Console.WriteLine($"hi,{name} {lastname} {familiname}!");
            Console.WriteLine("result");
            int result=string.Compare(name,lastname,true);

            Console.WriteLine(result);
            string str1= string.Concat(name,familiname);
            Console.WriteLine(str1);

            int firsindex = str.IndexOf(",");
            Console.WriteLine(firsindex);

            int secontIndex = str.IndexOf("d",1);
            Console.WriteLine(secontIndex);

            int notFound = str.IndexOf("/");
            Console.WriteLine(notFound);

            string name1 = str.Substring(6/ 7);
            Console.WriteLine(name1);

            string replaced = str.Replace("v c#", "si otiva");
            Console.WriteLine(replaced);

        }
    }
}
