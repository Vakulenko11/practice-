using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {          
                string d = Console.ReadLine();
                int maxInd = 0;
                string[] dd = d.Split(' ');
                int max = dd[0].Length;
                for (int i = 0; i < dd.Length; i++)
                    if (max < dd[i].Length) { max = dd[i].Length; maxInd = i; }
                Console.WriteLine("самое длинное слово: {0} ", dd[maxInd]);
                Console.WriteLine("индекс самого длинного слова: {0} ", maxInd);
                Console.WriteLine("длинна: {0} ", dd[maxInd].Length);
                Console.ReadLine();
         }
    }
}