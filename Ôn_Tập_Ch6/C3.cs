using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_Tập_Ch6
{
    class C3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;

            Console.WriteLine("Nhập vào số nguyên dương n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tổng các ước số của {n} = {TinhTongUocSo(n)}");
            Console.WriteLine($"Số lượng ước số của {n} = {SoLuong(n)}");
        }

        static int TinhTongUocSo(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static int SoLuong(int n)
        {
            int soLuong = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    soLuong++;
                }
            }
            return soLuong;
        }
    }
}
