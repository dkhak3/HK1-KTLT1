using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_BaiTap
{
    class bt3_cô_sửa
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());

            //kiểm tra số nguyên dương
            do
            {
                Console.WriteLine("Nhap sai, yeu cau nhap lai: ");
                Console.WriteLine("Nhap vao so nguyen duong: ");
                n = int.Parse(Console.ReadLine());

            } while (n <= 0) ;

            //kiểm tra số nguyên tố
                int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }

            //kiểm tra đếm số nguyên tố
            if (dem == 2)
            {
                Console.WriteLine($"{n} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to");
            }
        }
    }
}
