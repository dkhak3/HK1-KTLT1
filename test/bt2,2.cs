using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void nhap_so_n(ref int n)
        {
        lap:
            Console.WriteLine("nhap n = ");
            n = int.Parse(Console.ReadLine());
            if (n <= 0) goto lap;
        }
        static int test_so_nguyen_to(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return 0;
            }
            return 1;
        }
        static void test_n_so_nguyen_to(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (test_so_nguyen_to(i) == 1) Console.WriteLine(i);

            }
        }
        static void Main(string[] args)
        {

            int n = 0;


            //char Chon;
            //while (true)
            //{
            //    nhap_so_n(ref n);
            //    Console.Write("nhap so can test so nguyen to = ");
            //    int num1;
            //    num1 = int.Parse(Console.ReadLine());
            //    if (test_so_nguyen_to(num1) == 1) Console.WriteLine("la so nguyen to ");
            //    else Console.WriteLine("khong phai so nguyen to ");
            //    test_n_so_nguyen_to(n);
            //    Console.WriteLine("Bạn có muốn tiếp tục không ? (y/n)");
            //    Chon = Convert.ToChar(Console.ReadLine());
            //    if (Chon == 'n')
            //    {
            //        break;
            //    }
            //}
            nhap_so_n(ref n);
              Console.Write("nhap so can test so nguyen to = ");
              int num1;
             num1 = int.Parse(Console.ReadLine());
             if (test_so_nguyen_to(num1) == 1) Console.WriteLine("la so nguyen to ");
              else Console.WriteLine("khong phai so nguyen to ");
             test_n_so_nguyen_to(n);
        }
    }
}
