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
        static void Cout() // hàm dùng để kiểm tra
        {
            int n = 0;
            do
            {
                Console.Write("Nhap vao so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0) ;

                Console.WriteLine($"So ban vua nhap la {n}");
        }
    }
}
