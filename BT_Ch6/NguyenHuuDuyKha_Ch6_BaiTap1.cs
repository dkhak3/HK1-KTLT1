using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Ch6
{
    class NguyenHuuDuyKha_Ch6_BaiTap1
    {
        static void Main(string[] args)
        {
            Cout();
        }
        static void Cout()
        {
            int n = 0;

            Console.Write("Nhap vao mot so nguyen duong: ");
            n = int.Parse(Console.ReadLine());

            while (n <=0 )
            {
                Console.Write("Nhap sai, yeu cau nhap lai: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"So ban vua nhap la {n}");
        }
    }
}
