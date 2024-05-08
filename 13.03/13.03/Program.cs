using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n=int.Parse(Console.ReadLine());
            //int[] arr=new int[n];
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    Console.WriteLine("kolko arr");
            //    arr[i] = int.Parse(Console.ReadLine());
            //} 

            //for(int i= 0; i < arr.Length; i++)
            //{
            //    int swapVar = arr[i];
            //    int index = i;
            //    while (index > 0 && arr[index - 1] >= swapVar)
            //    {
            //        arr[index] = arr[index - 1];
            //        index--;

            //    }
            //    arr[index] = swapVar;
            //}
            //Console.WriteLine(string.Join(" ",arr));

            int n =int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));

            }
            for (int i = 0;i < list.Count;i++)
            {
                Console.WriteLine("list{[0]}={1}", i, list[i]);
            }
            for (int i = 0; i < n; i++)
            {
                list.Remove
                list.Remove(2);
                Console.WriteLine(string.Join(",", list));
            }
         
        }
    }
}
