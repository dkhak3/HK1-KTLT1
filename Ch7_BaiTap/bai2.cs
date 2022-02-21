using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[1000];
            int dem = 0;
            double temp = 0;
            do
            {
                Console.WriteLine("a[{0}] = ", dem);
                a[dem] = double.Parse(Console.ReadLine());
                while (a[dem] % 2 == 0)
                {
                    Console.WriteLine("nhap lai so : ");
                    a[dem] = double.Parse(Console.ReadLine());
                };
                temp = a[dem];
                dem++;
            } while (temp != (-1));

            for (int i = 0; i < dem; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }


        }
    }
}