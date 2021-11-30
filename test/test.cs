using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class test
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao so n");
            int n = int.Parse(Console.ReadLine());

            ////in các số lẽ của n
            //Console.WriteLine("in cac so le cua n");
            //Console.Write($"Cac co le tu {n} la: ");
            //for (int i = 0; i <= n; i = i + 2)
            //{
            //    Console.Write(i + "\t");

            //}
            //Console.WriteLine();

            ////in từ n đến 0
            //Console.WriteLine("in tu n den 0");
            //Console.WriteLine();
            //for (int i = n; i >= 0; i--)
            //{
            //    Console.Write(i + "\t");

            //}
            //Console.WriteLine();

            ////in số lẽ từ n đến 0
            //Console.WriteLine("in so le tu n den 0");
            //Console.WriteLine();
            //for (int i = n; i >= 0; i--)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write(i + " ");
            //    }

            //}
            //Console.WriteLine();

            ////cách 2: in số lẽ từ n đến 0
            //Console.WriteLine("Cach 2: in so le tu n den 0");
            //Console.WriteLine();
            //for (int i = (n % 2 ==0 )? --n : n; i >= 0; i = i -2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            ////cách 3: in số lẽ từ n đến 0
            //Console.WriteLine("Cach 3: in so le tu n den 0");
            //Console.WriteLine();
            //for (int i = n; i >= 0; i++)
            //{
            //    if (n % 2 == 0)
            //    {
            //        n--;
            //    }
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //in bảng cửu chương
            Console.WriteLine("in bang cuu chuong");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = { i * j}");
                }
                Console.WriteLine();

            }
        }
    }
}
